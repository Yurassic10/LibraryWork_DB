using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOLibrary.Model
{
    public class Client
    {
        public int Id { get; set; } = 0;
        public DateTime Arriving { get; set; }
        public string Name { get; set; } = "";
        public string Lastname { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";



        public string InformationSrt()
        {
            return "Id: " + Id + "\tName: " + Name + "\tArriving: " + Arriving;
        }
    }
}
