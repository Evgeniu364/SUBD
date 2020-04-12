using MySql.Data.MySqlClient;

namespace MedicalWebApplication.Services
{
    public class Human
    {
        private readonly MySqlConnection _connection;

        public Human(DataBaseConnect connect)
        {
            _connection = connect.SetConnection();
        }
        public void RegistrationHuman(string first_name, string last_name, string patronamic, int activity,
            string login, string password, int role)
        {

            using (_connection)
            {
                //call mydb.procedure_registration('Андрей', 'Козицкий','Сергеевич',1,'koneckonca', '123456',1 );
                string sqlCommand = string.Format("call mydb.procedure_registration(\'{0}\',\'{1}\',\'{2}\',\'{3}\'," +
                                                  "\'{4}\',\'{5}\',\'{6}\');",first_name,last_name,patronamic,activity,login,password,role);

                _connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand(sqlCommand, _connection);
                command.ExecuteNonQuery();
            }
            
        }
    }
}