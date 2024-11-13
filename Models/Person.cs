

namespace HealthClinic.Models
{
    public class Person
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
        public string Telephone { get; private set; }
        protected DateTime DateOfBirth { get; private set; }
        protected string NIF { get; private set; }

        public Person(int id, string name, string address, DateTime dateOfBirth, string email, string telephone, string nif)
        {
            ID = id;
            Name = name;
            Address = address;
            DateOfBirth = dateOfBirth;
            Email = email;
            Telephone = telephone;
            NIF = nif;
        }

        public DateTime GetDateOfBirth()
        {
            return DateOfBirth;
        }

        public string GetNIF()
        {
            return NIF;
        }
    }
}
