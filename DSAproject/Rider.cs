using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAproject
{
    public class Rider : User
    {
        public Rider()
        {
            Role = "Rider";
        }

        public string Name { get; set; }   // 👈 add this
        public double Salary { get; set; }
        public int DeliveriesCompleted { get; set; }
    }


}

