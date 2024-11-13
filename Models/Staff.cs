using HealthClinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.Models
{
    public class Staff : Person
    {
        public string Role { get; private set; }

        public Staff(int id, string name, string address, DateTime dateOfBirth, string email, string telephone, string nif, string role)
            : base(id, name, address, dateOfBirth, email, telephone, nif)
        {
            Role = role;
        }
    }
}
