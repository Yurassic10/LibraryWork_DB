using System;
using ADOLibrary.Model;
using ADOLibrary.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOLibrary.ADORepository
{
    public class StaffRepository : IRepositoryModel<Staff>
    {
        List<Staff> staffs;
        private string connectionStr;
        public StaffRepository()
        {
            staffs = new List<Staff>();
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
                        comm.CommandText = "select PersonId,PersonName,Rating," +
                            "PersonRole from Staff";

                        SqlDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            Staff tempSt = new Staff();
                            tempSt.Id = (int)reader["PersonId"];
                            tempSt.Name = (string)reader["PersonName"];
                            tempSt.Rating = (int)reader["Rating"];
                            tempSt.Role = (string)reader["PersonRole"];

                            staffs.Add(tempSt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during read from databased: {ex.Message}");
            }
        }
        public void AddObj(Staff tempObj)
        {
            staffs.Add(tempObj);

            using (SqlConnection connectionSql = new SqlConnection(connectionStr))
            {
                using (SqlCommand comm = connectionSql.CreateCommand())
                {
                    connectionSql.Open();
                    comm.CommandText = "insert into Staff(PersonName,Rating,PersonRole) " +
                      "values(@personName,@rating,@role)";
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@personName", tempObj.Name);
                    comm.Parameters.AddWithValue("@rating", tempObj.Rating);
                    comm.Parameters.AddWithValue("@role", tempObj.Role);
                    int rowAffected = comm.ExecuteNonQuery();


                }
            }
        }

        public void DeleteObject(int id)
        {
            var tempObj = staffs.Where(x => x.Id == id).SingleOrDefault();
            if (tempObj != null)
            {
                staffs.Remove(tempObj);
                using (SqlConnection connectionSql = new SqlConnection(connectionStr))
                {
                    using (SqlCommand comm = connectionSql.CreateCommand())
                    {
                        connectionSql.Open();
                        comm.CommandText = "delete from Staff where PersonId=@staffId";
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@staffId", tempObj.Id);
                        int rowAffected = comm.ExecuteNonQuery();

                    }
                }
            }
        }

        public Staff GetObj(int idT)
        {
            var tempObj = staffs.Where(x => x.Id == idT).SingleOrDefault();
            return tempObj;
        }

        public List<Staff> GetProducts()
        {
            return staffs;
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
