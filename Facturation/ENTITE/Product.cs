using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation.ENTITE
{
   public class Product
    {
        public int Id { get; set; }

        public  string References { get; set; }

        public string Designation { get; set; }

        public int Prix { get; set; }

        public int Quantité { get; set; }

        public Product()
        {
            this.Quantité = 1;
        }

        public Product (int id,string references,string designation,int prix)
        {
            this.Id = id;
            this.References = references;
            this.Designation = designation;
            this.Prix = prix;
            this.Quantité = 1;
        }

        public override string ToString()
        {
            return String.Format("Product (0)+(1)+(2)+(3)+(4)\n", Id, References, Designation, Prix,Quantité);
        }

    }
}
