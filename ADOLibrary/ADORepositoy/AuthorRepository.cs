using ADOLibrary.Interface;
using ADOLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOLibrary.ADORepository
{
    public class AuthorRepository : IRepositoryModel<Author>
    {
        List<Author> authors;
        private string connectionStr;
        public AuthorRepository()
        {
            authors = new List<Author>();
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
                        comm.CommandText = "select AuthorId,AuthorFname,AuthorSname," +
                            "DateOfBirth from Author"; // explain select

                        SqlDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            Author tempA = new Author();
                            tempA.Id = (int)reader["AuthorId"];
                            tempA.Firstname = (string)reader["AuthorFname"];
                            tempA.Lastname = (string)reader["AuthorSname"];
                            tempA.DateOfBirthd = (DateTime)reader["DateOfBirth"];

                            authors.Add(tempA);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during read from databased: {ex.Message}");
            }
        }

        public void AddObj(Author tempObj)
        {
            authors.Add(tempObj);
            using (SqlConnection connectionSql = new SqlConnection(connectionStr))
            {
                using (SqlCommand comm = connectionSql.CreateCommand())
                {
                    connectionSql.Open();
                    comm.CommandText = "insert into Author (AuthorFname,AuthorSname,DateOfBirth) " +
                        "values(@authorName,@authorSName,@dateOfB)";
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@authorName", tempObj.Firstname);
                    comm.Parameters.AddWithValue("@authorSName", tempObj.Lastname);
                    comm.Parameters.AddWithValue("@dateOfB", tempObj.DateOfBirthd);

                    comm.ExecuteNonQuery();
                }
            }
        }

        public void DeleteObject(int id)
        {
            var tempObj = authors.Where(x => x.Id == id).SingleOrDefault();
            if (tempObj != null)
            {
                authors.Remove(tempObj);
                using (SqlConnection connectionSql = new SqlConnection(connectionStr))
                {
                    using (SqlCommand comm = connectionSql.CreateCommand())
                    {
                        connectionSql.Open();
                        comm.CommandText = "delete from Author where AuthorId=@authorId";
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@authorId", tempObj.Id);
                        int rowAffected = comm.ExecuteNonQuery();

                    }
                }
            }
        }

        public Author GetObj(int idT)
        {
            var tempObj = authors.Where(x => x.Id == idT).SingleOrDefault();
            return tempObj;
        }

        public List<Author> GetProducts()
        {
            return authors;
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
            using (SqlConnection connectionSql = new SqlConnection(connectionStr))
            {
                using (SqlCommand comm = connectionSql.CreateCommand())
                {
                    connectionSql.Open();
                    comm.CommandText = "explain select * from Author where Author.AuthorFname = Stephen";
                    int rowAff = comm.ExecuteNonQuery();


                }
            }
        }
    }
}
