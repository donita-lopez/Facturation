using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Facturation.MODEL;

namespace Facturation.ENTITE
{
    public abstract class Facture 
    {
        public List<Product> products;
        public int id { get; set; }

        public Client client;

        public DateTime DateFacture { get; set; }


        public Facture(int id, Client client)
        {
            products = new List<Product>();
            this.id = id;
            this.client = client;
            products = new List<Product>();
            this.DateFacture = DateTime.Now;

        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);

        }

        public void AddProduct(params Product[] products)
        {
            this.products.AddRange(products);
        }
            

        public abstract int MontantPayer();
        public abstract int MontantTotal();
        public abstract int MontantRemise();
        public abstract int MontantTva();


        public override string ToString()
        {
            StringBuilder sortie = new StringBuilder();

            foreach (Product p in products)
            {

            }

            return sortie.ToString();

        }

    } 
}
