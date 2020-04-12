using System.Data;
using MySql.Data.MySqlClient;
namespace MedicalWebApplication.Services
{
    public class DataBaseConnect
    {
        private readonly MySqlConnection connection;

        public  DataBaseConnect()
        {
            this.connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=root;database=MedicalDB");
        }

        public MySqlConnection SetConnection()
        {
            return this.connection;
        }
    }
}