using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PerfumeShop
{
    public class User
    {
        private int id;
        private string email;
        private string password;
        
        public User() { }
        public User(int id, string email, string password)
        {
            this.id = id;
            this.email = email;
            this.password = password;
        }

        public string GetEmail()
        {
            return email;
        }

        public int GetId()
        {
            return id;
        }
    }
}
