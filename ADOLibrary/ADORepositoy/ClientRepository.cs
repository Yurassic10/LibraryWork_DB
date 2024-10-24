using ADOLibrary.Model;
using System;
using ADOLibrary.Interface;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOLibrary.ADORepository
{
    public class ClientRepository : IRepositoryModel<Client>
    {
        List<Client> clients;
        private string connectionStr;
        public ClientRepository()
        {
            clients = new List<Client>();
            connectionStr = "Data Source=DESKTOP-NALH133;Initial Catalog=Library;Integrated Security=True";

            ReadFromDataBase();
        }
        public void ReadFromDataBase()
        {
            try
            {
                using (SqlConnection connectionSql = new SqlConnection(connectionStr))
                {
                    using (SqlCommand comm = connectionSql.CreateCommand())
                    {
                        connectionSql.Open();
                        comm.CommandText = "select ClientId,ClientFirstname,ClientLastname," +
                            "ClientArriving,ClientEmail,ClientPassword from Client";

                        SqlDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            Client tempCl = new Client();
                            tempCl.Id = (int)reader["ClientId"];
                            tempCl.Name = (string)reader["ClientFirstname"];
                            tempCl.Lastname = (string)reader["ClientLastname"];
                            tempCl.Arriving = (DateTime)reader["ClientArriving"];
                            tempCl.Email = (string)reader["ClientEmail"];
                            tempCl.Password = (string)reader["ClientPassword"];

                            clients.Add(tempCl);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during read from databased: {ex.Message}");
            }
        }
        public void AddObj(Client tempObj)
        {
            clients.Add(tempObj);

            using (SqlConnection connectionSql = new SqlConnection(connectionStr))
            {
                using (SqlCommand comm = connectionSql.CreateCommand())
                {
                    connectionSql.Open();
                    comm.CommandText = "insert into Client(ClientFirstname,ClientLastname," +
                        "ClientArriving,ClientPassword,ClientEmail) values(@personName,@perLastname,@arriving,@password,@email)";
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@personName", tempObj.Name);
                    comm.Parameters.AddWithValue("@perLastname", tempObj.Lastname);
                    comm.Parameters.AddWithValue("@arriving", tempObj.Arriving);
                    comm.Parameters.AddWithValue("@password", tempObj.Password);
                    comm.Parameters.AddWithValue("@email", tempObj.Email);
                    int rowAffected = comm.ExecuteNonQuery();


                }
            }
        }

        public void DeleteObject(int id)
        {
            var tempObj = clients.Where(x => x.Id == id).SingleOrDefault();
            if (tempObj != null)
            {
                clients.Remove(tempObj);
                using (SqlConnection connectionSql = new SqlConnection(connectionStr))
                {
                    using (SqlCommand comm = connectionSql.CreateCommand())
                    {
                        connectionSql.Open();
                        comm.CommandText = "delete from Client where ClientId=@clientId";
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@clientId", tempObj.Id);
                        int rowAffected = comm.ExecuteNonQuery();

                    }
                }
            }
        }

        public Client GetObj(int idT)
        {
            var tempObj = clients.Where(x => x.Id == idT).SingleOrDefault();
            return tempObj;
        }

        public List<Client> GetProducts()
        {
            return clients;
        }

        public void ChangeValueObj(int id, string newName)
        {
            throw new NotImplementedException();
        }

        public void GreateViewWithJoin()
        {
            throw new NotImplementedException();
        }

        public void GetItemsExplain()
        {
            throw new NotImplementedException();
        }
    }
}
