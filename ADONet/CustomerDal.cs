using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ADONet
{
    class CustomerDal
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        private void TryConnect()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        
        public List<Customer> GetAll()
        {
            /*connection kısmını bir kere tanımlamamız yeterlidir. Bu database Visual Studio nun kendi SQL Server Object Explorer aracı ile üretilmiştir.*/
            connection = new SqlConnection(@"server = (localdb)\MSSQLLocalDB;Initial Catalog=MyAdoDatabase;Integrated Security=True");

            TryConnect();  //Bağlantı açık mı?

            string commandText = "Select * from Customer";        //komut texti oluşturuldu.
            command = new SqlCommand(commandText, connection);    //connection bağlantısına bu komut text i gönderildi.

            reader = command.ExecuteReader();   //Okuma komutu. Bu komut yardımı ile database içindeki veriler okunur.

            /*Database deki verilere karşılık gelecek şekilde bir class oluşturuldu. Bu class tan bir liste yapıldı ve databasedeki veriler önce bu listeye 
             toplanıp daha sonra datagrieview aracına aktarılacak.*/
            List<Customer> customers = new List<Customer>();

            while (reader.Read())
            {
                Customer customer = new Customer
                {
                    ID = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Number = Convert.ToInt32(reader["Number"])
                };
                customers.Add(customer);
            }

            reader.Close();     //Okuma sonlandırıldı.
            connection.Close(); //Bağlantı kapatıldı.
            return customers;
        }

        public void _Update(Customer customer)
        {
            TryConnect();
            string sql = "update Customer set Name=@name,LastName=@lastName,Number=@number where Id=@id";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@lastName", customer.LastName);
            command.Parameters.AddWithValue("@number", customer.Number);
            command.Parameters.AddWithValue("@id", customer.ID);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void _Insert(Customer customer)
        {
            TryConnect();
            string sql = "insert into Customer values(@name,@lastName,@number)";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@lastName", customer.LastName);
            command.Parameters.AddWithValue("@number", customer.Number);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void _Delete(int id)
        {
            TryConnect();
            string sql = "delete from Customer where Id=@id";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
