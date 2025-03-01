using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniDataReader
{
    public class DataReaderLogic
    {
        private readonly CmdDbFactory _cmdFactory; // объект фабрики команд для чтения
        private DbConnection _connection;
        private string _query; // строка запросов
        private Action<DataTable> _callback; // метод обратного вызова
        private int _timeoutsecs;

        public DataReaderLogic(CmdDbFactory cmdFactory)
        {
            _cmdFactory = cmdFactory ?? throw new ArgumentNullException(nameof(cmdFactory)); // тернарный оператор с исключением выкидывающий сообщение типа объекта
            _timeoutsecs = 10; // 10 секунд по умолчанию
        }
        public DataReaderLogic SetConnection(string connectionString)
        {
            _connection = _cmdFactory.CreateConnection(connectionString);
            return this;
        }
        public DataReaderLogic SetQuery(string query)
        {
            _query = query ?? throw new ArgumentNullException(nameof(query));
            return this;
        }
        public DataReaderLogic SetCallback(Action<DataTable> callback)
        {
            _callback = callback ?? throw new ArgumentNullException(nameof(callback));
            return this;
        }
        public void ExecuteSync()
        {
            if (_connection == null || string.IsNullOrWhiteSpace(_query) || _callback == null)
                throw new InvalidOperationException("Перед выполнением запроса, необходимо настроить подключение, запрос и обратный вызов");

            try
            {
                _connection.Open();

                using (var command = _cmdFactory.GetCommand(_connection))
                {
                    command.CommandText = _query;

                    using (var reader = command.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                        _callback.Invoke(table);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка в выполнении запроса: {ex.Message}", "Критическая Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_connection.State != ConnectionState.Closed)
                    _connection.Close();
            }
        }
        public async Task ExecuteAsync()
        {
            if (_connection == null || string.IsNullOrWhiteSpace(_query) || _callback == null)
                throw new InvalidOperationException("Перед выполнением запроса, необходимо настроить подключение, запрос и обратный вызов");

            try
            {
                await _connection.OpenAsync();

                using (var command = _cmdFactory.GetCommand(_connection))
                {
                    command.CommandText = _query;
                    command.CommandTimeout = _timeoutsecs;

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        var table = new DataTable();
                        table.Load(reader); // загружаем данные
                        _callback.Invoke(table); // callback для передачи результата
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Возникла ошибка в выполнении запроса: {ex.Message}", "Критическая Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_connection.State != ConnectionState.Closed)
                    _connection.Close();
            }
        }
    }
}
