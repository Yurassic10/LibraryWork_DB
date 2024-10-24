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
    public class BookRepository : IRepositoryModel<Book>
    {
        List<Book> books;
        private string connectionStr;
        public BookRepository()
        {
            books = new List<Book>();
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
                        comm.CommandText = "select BookId,BookName,AuthorId," +
                            "GenreId,Rating,Price,ClientId from Book";

                        SqlDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            Book tempB = new Book();
                            tempB.Id = (int)reader["BookId"];
                            tempB.Name = (string)reader["BookName"];
                            tempB.AuthorId = (int)reader["AuthorId"];
                            tempB.GenreId = (int)reader["GenreId"];
                            tempB.Rating = (int)reader["Rating"];
                            tempB.Price = (int)reader["Price"];
                            tempB.ClientId = (int)reader["ClientId"];

                            books.Add(tempB);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during read from databased: {ex.Message}");
            }
        }
        public void AddObj(Book tempObj)
        {
            books.Add(tempObj);

            using (SqlConnection connectionSql = new SqlConnection(connectionStr))
            {
                using (SqlCommand comm = connectionSql.CreateCommand())
                {
                    connectionSql.Open();
                    comm.CommandText = "insert into Book(BookName,AuthorId,GenreId,Rating,Price,ClientId) " +
                      "values(@bookName,@author,@genre,@rating,@price,@client)";
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@bookName", tempObj.Name);
                    comm.Parameters.AddWithValue("@author", tempObj.AuthorId);
                    comm.Parameters.AddWithValue("@genre", tempObj.GenreId);
                    comm.Parameters.AddWithValue("@rating", tempObj.Rating);
                    comm.Parameters.AddWithValue("@price", tempObj.Price);
                    comm.Parameters.AddWithValue("@client",tempObj.ClientId);

                    int rowAffected = comm.ExecuteNonQuery();


                }
            }
        }


        public void DeleteObject(int id)
        {
            var tempObj = books.Where(x => x.Id == id).SingleOrDefault();
            if (tempObj != null)
            {
                books.Remove(tempObj);
                using (SqlConnection connectionSql = new SqlConnection(connectionStr))
                {
                    using (SqlCommand comm = connectionSql.CreateCommand())
                    {
                        connectionSql.Open();
                        comm.CommandText = "delete from Book where BookId=@bookId";
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@bookId", tempObj.Id);
                        int rowAffected = comm.ExecuteNonQuery();

                    }
                }
            }
        }

        public Book GetObj(int idT)
        {
            var tempObj = books.Where(x => x.Id == idT).SingleOrDefault();
            return tempObj;
        }

        public List<Book> GetProducts()
        {
            return books;
        }

        public void ChangeValueObj(int id, string newName)
        {
            if (books != null)
            {
                if (newName == "+")
                {
                    using (SqlConnection connectionSql = new SqlConnection(connectionStr))
                    {
                        using (SqlCommand comm = connectionSql.CreateCommand())
                        {
                            connectionSql.Open();
                            comm.CommandText = "CREATE TRIGGER Book_INSERT_UPDATE" +
                                "ON Book AFTER INSERT,UPDATE " +
                                "AS " +
                                "UPDATE Book " +
                                "SET Price = Price + 230 " +
                                "WHERE Price < 200";
                            comm.Parameters.Clear();
                            //int rowAffected = comm.ExecuteNonQuery();

                        }
                    }
                }
                else if (newName == "-")
                {
                    using (SqlConnection connectionSql = new SqlConnection(connectionStr))
                    {
                        using (SqlCommand comm = connectionSql.CreateCommand())
                        {
                            connectionSql.Open();
                            comm.CommandText = "UPDATE Book " +
                                "SET Price = Price - 100 " +
                                "WHERE Price > 200";
                            comm.Parameters.Clear();
                            //int rowAffected = comm.ExecuteNonQuery();

                        }
                    }
                }
                else
                {
                    using (SqlConnection connectionSql = new SqlConnection(connectionStr))
                    {
                        using (SqlCommand comm = connectionSql.CreateCommand())
                        {
                            connectionSql.Open();
                            comm.CommandText = "UPDATE Book " +
                                "SET Price = Price + 230 " +
                                "WHERE Price < 200";
                            comm.Parameters.Clear();
                            //int rowAffected = comm.ExecuteNonQuery();

                        }
                    }
                }
            }
        }

        public void GreateViewWithJoin()
        {
            using (SqlConnection connectionSql = new SqlConnection(connectionStr))
            {
                using (SqlCommand comm = connectionSql.CreateCommand())
                {
                    connectionSql.Open();
                    string BookGenreAuthor = "create view BookGenreAuthor as select BookName,GenreType,AuthorFname,AuthorSname from Book b join Genre g on b.GenreId = g.GenreId join Author a on a.AuthorId = b.BookId";
                    comm.CommandText = BookGenreAuthor;
                    int rowAff = comm.ExecuteNonQuery();


                }
            }
        }

        public void GetItemsExplain()
        {
            using (SqlConnection connectionSql = new SqlConnection(connectionStr))
            {
                using (SqlCommand comm = connectionSql.CreateCommand())
                {
                    connectionSql.Open();
                    comm.CommandText = "explain select * from Book where Book.Price>400 or Book.AuthorId=3";
                    int rowAff = comm.ExecuteNonQuery();


                }
            }
        }
    }
}
