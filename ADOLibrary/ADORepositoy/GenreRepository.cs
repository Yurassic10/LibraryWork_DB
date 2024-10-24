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
    public class GenreRepository : IRepositoryModel<Genre>
    {
        List<Genre> genres;
        private string connectionStr;
        public GenreRepository()
        {
            genres = new List<Genre>();
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
                        comm.CommandText = "select GenreId,GenreType from Genre";

                        SqlDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            Genre tempG = new Genre();
                            tempG.Id = (int)reader["GenreId"];
                            tempG.Type = (string)reader["GenreType"];

                            genres.Add(tempG);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during read from databased: {ex.Message}");
            }
        }
        public void AddObj(Genre tempObj)
        {
            genres.Add(tempObj);

            using (SqlConnection connectionSql = new SqlConnection(connectionStr))
            {
                using (SqlCommand comm = connectionSql.CreateCommand())
                {
                    connectionSql.Open();
                    comm.CommandText = "insert into Genre(GenreType) values(@type)";
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@type", tempObj.Type);

                    int rowAffected = comm.ExecuteNonQuery();


                }
            }
        }

        public void DeleteObject(int id)
        {
            var tempObj = genres.Where(x => x.Id == id).SingleOrDefault();
            if (tempObj != null)
            {
                genres.Remove(tempObj);
                using (SqlConnection connectionSql = new SqlConnection(connectionStr))
                {
                    using (SqlCommand comm = connectionSql.CreateCommand())
                    {
                        connectionSql.Open();
                        comm.CommandText = "delete from Genre where GenreId=@genreId";
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@genreId", tempObj.Id);
                        int rowAffected = comm.ExecuteNonQuery();

                    }
                }
            }
        }

        public Genre GetObj(int idT)
        {
            var tempObj = genres.Where(x => x.Id == idT).SingleOrDefault();
            return tempObj;
        }

        public List<Genre> GetProducts()
        {
            return genres;
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
