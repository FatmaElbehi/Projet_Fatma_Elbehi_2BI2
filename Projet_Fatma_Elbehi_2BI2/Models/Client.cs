using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Fatma_Elbehi_2BI2.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string telephone { get; set; }

        public Client(int id, string nom, string prenom, string email, string password, string telephone)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            this.email = email;
            this.password = password;
            this.telephone = telephone;
        }

        public Client()
        {
        }
    }
}
