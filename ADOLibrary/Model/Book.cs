using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOLibrary.Model
{
    public class Book
    {
        public int Id { get; set; } = 0;
        public int AuthorId { get; set; } = 0;
        public int GenreId { get; set; } = 0;
        public int ClientId { get; set; } = 0; // Було 7
        public int Price { get; set; } = 0;
        public string Name { get; set; } = "";
        public int Rating { get; set; } = 0;

        public string InformationStr()
        {
            return "Id: " + Id + "\tName: " + Name + "\tAuthor: " + AuthorId;
        }
    }
}
