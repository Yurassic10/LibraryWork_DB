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
    public class HallRepository : IRepositoryModel<Hall>
    {
        List<Hall> halls;
        private string connectionStr;
        public HallRepository()
        {
            halls = new List<Hall>();
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
                        comm.CommandText = "select Hall_Id,HallName,GenreId,PersonId from Hall";

                        SqlDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            Hall tempH = new Hall();
                            tempH.Id = (int)reader["Hall_Id"];
                            tempH.Name = (string)reader["HallName"];
                            tempH.GenreId = (int)reader["GenreId"];
                            tempH.PersonId = (int)reader["PersonId"];

                            halls.Add(tempH);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during read from databased: {ex.Message}");
            }
        }
        public void AddObj(Hall tempObj)
        {
            halls.Add(tempObj);

            using (SqlConnection connectionSql = new SqlConnection(connectionStr))
            {
                using (SqlCommand comm = connectionSql.CreateCommand())
                {
                    connectionSql.Open();
                    comm.CommandText = "insert into Hall(HallName,GenreId,PersonId) " +
                      "values(@hallName,@genre,@person)";
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@hallName", tempObj.Name);
                    comm.Parameters.AddWithValue("@genre", tempObj.GenreId);
                    comm.Parameters.AddWithValue("@person", tempObj.PersonId);
                    int rowAffected = comm.ExecuteNonQuery();


                }
            }
        }

        public void DeleteObject(int id)
        {
            var tempObj = halls.Where(x => x.Id == id).SingleOrDefault();
            if (tempObj != null)
            {
                halls.Remove(tempObj);
                using (SqlConnection connectionSql = new SqlConnection(connectionStr))
                {
                    using (SqlCommand comm = connectionSql.CreateCommand())
                    {
                        connectionSql.Open();
                        comm.CommandText = "delete from Hall where Hall_Id=@halId";
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@halId", tempObj.Id);
                        int rowAffected = comm.ExecuteNonQuery();

                    }
                }
            }
        }

        public Hall GetObj(int idT)
        {
            var tempObj = halls.Where(x => x.Id == idT).SingleOrDefault();
            return tempObj;
        }

        public List<Hall> GetProducts()
        {
            return halls;
        }

        public void ChangeValueObj(int id, string newName)
        {
            throw new NotImplementedException();
        }

        public void GreateViewWithJoin()
        {
            using (SqlConnection connectionSql = new SqlConnection(connectionStr))
            {
                using (SqlCommand comm = connectionSql.CreateCommand())
                {
                    connectionSql.Open();
                    string HallStaffGenre = "create view HallStaff as select HallName,GenreType,PersonName,PersonRole,Rating from Hall h join Genre g on h.GenreId = g.GenreId join Staff s on s.PersonId = h.PersonId ";
                    comm.CommandText = HallStaffGenre;
                    int rowAff = comm.ExecuteNonQuery();


                }
            }

        }

        public void GetItemsExplain()
        {
            throw new NotImplementedException();
        }
    }
}
