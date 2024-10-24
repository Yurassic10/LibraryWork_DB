using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOLibrary.Model
{
    public class Hall
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public int GenreId { get; set; } = 0;
        public int PersonId { get; set; } = 0;

        public string InformationStr()
        {
            return "Id: " + Id + "\tName: " + Name + "\tGenreId: " + GenreId;
        }
    }
}
