using System;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;

namespace MedicalWebApplication.Services
{
    public class HumanServices
    {
        private readonly MySqlConnection _connection;
        

        

        public HumanServices(DataBaseConnect connect)
        {
            _connection = connect.GetConnection();
        }
        public void RegistrationHuman(string first_name, string last_name, string patronamic, int activity,
            string login, string password, int role)
        {

            using (_connection)
            {
                //call mydb.procedure_registration('Андрей', 'Козицкий','Сергеевич',1,'koneckonca', '123456',1 );
                string sqlCommand = string.Format("call mydb.procedure_registration(\'{0}\',\'{1}\',\'{2}\',\'{3}\'," +
                                                  "\'{4}\',\'{5}\',\'{6}\');",first_name,last_name,patronamic,login,password,role,activity);

                _connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand(sqlCommand, _connection);
                command.ExecuteNonQuery();
            }
            
        }

        public int AuthorizationHuman(string login, string password)
        {
            int active;
            using (_connection)
            {
                
                string sqlCommand = string.Format("call mydb.procedure_authoriztion(\'{0}\',\'{1}\');",login,password);
                _connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand(sqlCommand, _connection);
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                active = Convert.ToInt32(table.AsEnumerable().ToArray()[0].ItemArray[0].ToString());
            }

            return active;
        }

        public void UpdateHuman(string login, string firstname, string lastname, string pat, string password)
        {
            using (_connection)
            {
                string sqlCommand = string.Format("call mydb.proc_update(\'{0}\',\'{1}\',\'{2}\',\'{3}\',\'{4}\');",firstname,lastname,pat,login,password);
                _connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand(sqlCommand, _connection);
                command.ExecuteNonQuery();
            }
        }

        public void BlockOnTime(int id, int time)
        {
            using (_connection)
            {
                string sqlCommand = string.Format("update mydb.human set mydb.human.active = 3  where mydb.human.id = \'{0}\'; CREATE EVENT IF NOT EXISTS mydb.qwe ON SCHEDULE AT DATE_ADD(NOW(),INTERVAL  \'{1}\'  second) DO update mydb.human set mydb.human.active = 1 where mydb.human.id = \'{2}\';",id,time,id);
                _connection.Open();
                MySqlCommand command = new MySqlCommand(sqlCommand, _connection);
                command.ExecuteNonQuery();
            }
        }
    }
}