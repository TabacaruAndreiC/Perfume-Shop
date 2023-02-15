using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfumeShop
{
    internal class Perfume
    {
        private string name;
        private string company;
        private string gender;
        private double price;
        public Perfume(string name, string company, string gender, double price)
        {
            this.name = name;
            this.company = company;
            this.gender = gender;
            this.price = price;
        }
    }
}
