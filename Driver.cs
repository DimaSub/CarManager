using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager
{
    public class Driver
    {
        private int id;
        private string name;
        private string family;
        private string address;
        private int phone;
        private string email;
        private List<string> travel;

        public Driver(int id, string name, string family, string address, int phone, string email)
        {
            this.id = id;
            this.name = name;
            this.family = family;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Family { get => family; set => family = value; }
        public string Address { get => address; set => address = value; }
        public int Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public List<string> Travel { get => travel; set => travel = value; }
    }
}
