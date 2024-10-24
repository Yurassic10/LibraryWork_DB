using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOLibrary.Model
{
    public class Staff
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public int Rating { get; set; } = 0;
        public string Role { get; set; } = "";
        public string InformationStr()
        {
            return "Id: " + Id + "\tName: " + Name + "\tRole: " + Role;
        }
    }
}
