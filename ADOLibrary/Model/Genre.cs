using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOLibrary.Model
{
    public class Genre
    {
        public int Id { get; set; } = 0;
        public string Type { get; set; } = "";

        public string InformationStr()
        {
            return "Id: " + Id + "\tType: " + Type;
        }
    }
}
