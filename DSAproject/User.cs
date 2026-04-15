using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAproject
{
        public abstract class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string PasswordHash { get; set; } 
            public string Name { get; set; }
            public string Role { get; protected set; }
        }

    }

