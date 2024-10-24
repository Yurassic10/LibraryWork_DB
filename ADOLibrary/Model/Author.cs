using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOLibrary.Model
{
    public class Author
    {
        public int Id { get; set; } = 0;
        public string Firstname { get; set; } = "";
        public string Lastname { get; set; } = "";
        public DateTime DateOfBirthd { get; set; }

        public string InformationStr()
        {
            return "Id: " + Id + "\tName: " + Firstname + "\tLastName: " + Lastname + "\tBithday: " + DateOfBirthd;
        }
    }
}
