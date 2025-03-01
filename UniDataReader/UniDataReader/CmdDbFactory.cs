using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace UniDataReader
{
    public class CmdDbFactory
    {
        private readonly string _providername;
        private readonly DbProviderFactory _ProviderFactory;

        public CmdDbFactory(string providername)
        {
            if (string.IsNullOrWhiteSpace(providername))
                throw new ArgumentNullException(nameof(providername));

            _providername = providername;

            _ProviderFactory = DbProviderFactories.GetFactory(_providername) ??
                throw new InvalidOperationException($"Провайдер {providername} не найден!");
        }
        public DbConnection CreateConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            var connection = _ProviderFactory.CreateConnection();
            if (connection == null)
                throw new InvalidOperationException($"Не получилось создать соединение для провайдера {_providername}.");

            connection.ConnectionString = connectionString;
            return connection;
        }
        public DbCommand GetCommand(DbConnection connection)
        {
            var command = _ProviderFactory.CreateCommand();
            if (command == null)
                throw new InvalidOperationException("Команду создать не удалось!");

            command.Connection = connection;
            return command;
        }
        public DbTransaction GetTransaction(DbConnection connection)
        {
            try { return connection.BeginTransaction(); }
            catch (Exception ex) { throw new InvalidOperationException("Транзакцию не удалось создать!", ex); }
        }

        // Асинхронные версии методов GetCommand и GetTransaction
        public async Task<DbCommand> GetCommandAsync(DbConnection connection)
        {
            if (connection is null)
                throw new ArgumentNullException(nameof(connection));

            if (connection.State != ConnectionState.Open)
                await connection.OpenAsync();

            var command = _ProviderFactory.CreateCommand();
            if (command == null)
                throw new InvalidOperationException("Команду создать не удалось!");

            command.Connection = connection;
            return command;
        }
        public async Task<DbTransaction> GetTransactionAsync(DbConnection connection)
        {
            if (connection is null)
                throw new ArgumentNullException(nameof(connection));

            if (connection.State != ConnectionState.Open)
                await connection.OpenAsync();

            try { return connection.BeginTransaction(); }
            catch (Exception ex) { throw new InvalidOperationException("Транзакцию не удалось создать!", ex); }
        }
    }
}
