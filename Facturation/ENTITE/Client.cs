using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set;  }

        public string Email { get; set; }

        public string Adresse { get; set; }


        public Client ( int id,string nom,string email,string adresse) 
        {
            Id = id;
            Nom = nom;
            Email = email;
            Adresse = adresse;
        }

    }
}
