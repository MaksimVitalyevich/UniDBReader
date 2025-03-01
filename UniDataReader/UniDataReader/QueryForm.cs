using System;
using System.Windows.Forms;

namespace UniDataReader
{
    public partial class QueryForm : Form
    {
        private readonly Func<string> _getConnString;
        private string _providername = "System.Data.SqlClient"; // по умолчанию используется SQLClient
        public QueryForm(Func<string> getconnString)
        {
            InitializeComponent();
            Button_ExecuteNonQuery.Enabled = false;
            _getConnString = getconnString ?? throw new ArgumentNullException(nameof(getconnString));
        }
        private void MultiQueryBox_TextChanged(object sender, EventArgs e)
        {
            if (MultiQueryBox.Text.Length >= 12)
                Button_ExecuteNonQuery.Enabled = true;
            else
                Button_ExecuteNonQuery.Enabled = false;
        }
        private async void Button_ExecuteNonQueryAsync_Click(object sender, EventArgs e)
        {
            string query = MultiQueryBox.Text;
            string connString = _getConnString();

            if (_getConnString == null)
            {
                MessageBox.Show("Делегат не содержит ссылок, невозможно установить подключение!", "Критическая Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (query == null)
            {
                MessageBox.Show("Строка запроса была пуста!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var cmdFactory = new CmdDbFactory(_providername);
            var readerLogic = new DataReaderLogic(cmdFactory);

            try
            {
                await readerLogic.SetConnection(connString).SetQuery(query).SetCallback((dataTable) =>
                {
                    Invoke((Action)(() =>
                    {
                        DataGridView.DataSource = dataTable;
                    }));
                }).ExecuteAsync();
                MessageBox.Show("Запрос выполнен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения: {ex.Message}", "Критическая Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button_ShowTable_Click(object sender, EventArgs e)
        {
            string query = MultiQueryBox.Text;
            string connString = _getConnString();

            if (_getConnString == null)
            {
                MessageBox.Show("Делегат не содержит ссылок, невозможно установить подключение!", "Критическая Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] forbiddenkeycommands = { "CREATE", "DELETE", "DROP", "UPDATE", "ALTER", "INSERT", };
            foreach (var keyword in forbiddenkeycommands)
            {
                if (query.ToUpper().Contains(keyword))
                {
                    MessageBox.Show($"Запрос содержит запрещенную команду '{keyword}'!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            try
            {
                var cmdFactory = new CmdDbFactory(_providername);
                var readerLogic = new DataReaderLogic(cmdFactory);

                readerLogic.SetConnection(connString).SetQuery(query).SetCallback((dataTable) =>
                {
                    Invoke((Action)(() =>
                    {
                        DataGridView.DataSource = dataTable;
                    }));
                }).ExecuteSync();
                TabMain.SelectedTab = DataTablePage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка в отображении таблицы: {ex.Message}", "Критическая Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
