using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace UniDataReader
{
    public partial class TimeoutForm : Form
    {
        private readonly Func<string> _getConnString; // делегат обращения к методу 1-ой формы
        private readonly string _connectionString; // строка подключения (только для чтения)
        private DbProviderFactory _providerFactory;
        private int _timeinseconds = 31; // начальное значение времени ожидания

        public int TimeOut { get => _timeinseconds; set => _timeinseconds = value; }
        public TimeoutForm(Func<string> GetConnString, DbProviderFactory providerFactory)
        {
            InitializeComponent();
            _getConnString = GetConnString;
            _providerFactory = providerFactory;
            _connectionString = _getConnString();
            TimedMark.ForeColor = Color.Red;
            TimedMark.Visible = false;
            CreateTimer();
        }
        private void CreateTimer()
        {
            TimeoutTimer.Interval = 1000;
            TimedMark.Visible = true;
            TimeoutTimer.Start();
        }
        private void TimeoutTimer_Tick(object sender, EventArgs e)
        {
            if (TimeOut > 0)
            {
                TimeOut--;
                TimedMark.Text = $"{TimeOut} сек.";
            }
            else
            {
                TimeoutTimer.Stop();
                AttemptReconnection();
            }
        }
        private void Button_RetryConnection_Click(object sender, EventArgs e)
        {
            TimeoutTimer.Stop();
            AttemptReconnection();
        }
        private void AttemptReconnection()
        {
            try
            {
                var connection = _providerFactory.CreateConnection();
                if (connection != null)
                {
                    connection.ConnectionString = _connectionString;
                    connection.Open();

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                        MessageBox.Show("Переподключение прошло успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось создать подключение", "Критическая Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка при переподключении: {ex.Message}", "Критическая Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Close(); }
        }
    }
}
