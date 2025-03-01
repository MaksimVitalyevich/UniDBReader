using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniDataReader
{
    public partial class ProviderConnForm : Form
    {
        private DbConnection _basicconnection = null; // базовый образец подключения
        private DbProviderFactory _providerfactory; // образец фабрики подключения
        private string _connectionName = null; // имя строки для подключения

        public ProviderConnForm()
        {
            InitializeComponent();
            Button_ConnectAsync.Enabled = false;
            ProviderLoadFailure.ForeColor = Color.Red;
            ConnectionTextBox.Visible = false;
            ProviderLoadFailure.Visible = false;
        }
        private string GetConnStrByProvider(string Provider)
        {
            string connString = null;
            ConnectionStringSettingsCollection stringSettings = ConfigurationManager.ConnectionStrings;

            if (stringSettings != null)
            {
                foreach (ConnectionStringSettings settingString in stringSettings)
                {
                    if (settingString.ProviderName == Provider)
                    {
                        connString = settingString.ConnectionString;
                        break;
                    }
                }
            }
            return connString;
        }
        public string GetConnectionString()
        {
            foreach (ConnectionStringSettings settings in ConfigurationManager.ConnectionStrings)
            {
                if (settings.Name == "SqlConnString") // по умолчанию настроено на SQL Server
                    return settings.ConnectionString;
            }
            return string.Empty;
        }
        private void Button_LoadAvailableProviders_Click(object sender, EventArgs e)
        {
            DataTable providerTable = DbProviderFactories.GetFactoryClasses();
            ProviderListBox.Items.Clear();

            foreach (DataRow dataRow in providerTable.Rows)
            {
                ProviderListBox.Items.Add(dataRow["InvariantName"]);
            }

            if (ProviderListBox.Items.Count > 0)
               ProviderListBox.SelectedIndex = 0;
            ConnectionTextBox.Visible = true;
        }

        private void ProviderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProviderListBox.SelectedItem == null)
            {
                ProviderLoadFailure.Visible = true;
                return;
            }
            ProviderLoadFailure.Visible = false;

            _providerfactory = DbProviderFactories.GetFactory(ProviderListBox.SelectedItem.ToString());
            _connectionName = GetConnStrByProvider(ProviderListBox.SelectedItem.ToString());
            ConnectionTextBox.Text = _connectionName;
        }
        private void ConnectionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ConnectionTextBox.Text.Length >= 10)
                Button_ConnectAsync.Enabled = true;
            else
                Button_ConnectAsync.Enabled = false;
        }

        private async void Button_ConnectAsync_Click(object sender, EventArgs e)
        {
            var queryForm = new QueryForm(() => ConnectionTextBox.Text);
            TimeoutForm timeoutForm = new TimeoutForm(GetConnectionString, _providerfactory);
            Button_ConnectAsync.Enabled = false;
            try
            {
                _basicconnection = _providerfactory.CreateConnection();
                _basicconnection.ConnectionString = ConnectionTextBox.Text;
                if (_basicconnection.State != ConnectionState.Open)
                {
                    timeoutForm.Show(); // отображаем форму ожидания (скрытно)
                    await _basicconnection.OpenAsync(); // асинхронное открытие соединения
                    await Task.Delay(timeoutForm.TimeOut);
                    timeoutForm.Close(); // и тут же закрываем

                    queryForm.Show();
                }
                else
                {
                    MessageBox.Show("Соединение уже открыто и настроено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка на этапе подключения: {ex.Message}", "Ошибка Подключения",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                timeoutForm.Visible = false; // поскольку нельзя отображать в модальном режиме уже открытую форму
                timeoutForm.ShowDialog();
            }
            finally { Button_ConnectAsync.Enabled = true; }
        }
        private void Button_Disconnect_Click(object sender, EventArgs e)
        {
            if (_basicconnection is null)
                return;

            if (_basicconnection.State == ConnectionState.Open)
                _basicconnection.Close();

            MessageBox.Show($"Соединение с {ProviderListBox.SelectedItem.ToString()} - закрыто! Программа закрывается...", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
