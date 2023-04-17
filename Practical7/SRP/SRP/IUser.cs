using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SRP
{
    internal interface IUser
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public bool Login(string username, string password);
        public bool Register(string username, string password, string name);
    }
}
