using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.Models
{
    public class Specialty
    {
        public int ID { get; private set; }
        public string SpecialtyName { get; private set; }

        public Specialty(int id, string specialtyName)
        {
            ID = id;
            SpecialtyName = specialtyName;
        }
    }
}

