using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolLibrary.SQL
{
    public class Users
    {
        public int UserId{ get; set; }
        public string UserFirstname{ get; set; }
        public string UserSecondName { get; set; }
        public string Password { get; set; }
        public bool AccessToManagement { get; set; }
    }
}
