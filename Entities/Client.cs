using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsOrdering.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        { 
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder ClientSb = new StringBuilder();
            ClientSb.AppendLine("Client: " + Name + " (" + BirthDate.ToString("dd/MM/yyyy") + ") " + Email);
            return ClientSb.ToString();
        }
    }
}
