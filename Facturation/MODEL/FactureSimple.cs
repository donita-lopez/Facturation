using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Facturation.ENTITE;

namespace Facturation.MODEL
{
    class FactureSimple : Facture
    {
       public int TauxRemise { get; set; }
       public int TauxTva { get; set; }

        public FactureSimple (int id, Client client ):base(id, client) { }
        public override int MontantPayer()

        { return MontantPayer() + MontantTva() + MontantRemise(); }

        public override int MontantTotal()
        {
            int total = 0;
            foreach (var p in products)
            {
              total +=  (p.Prix) * (p.Quantité);
                
            }
            return total;
        }

        public override int MontantRemise()
        {
            return ((TauxRemise * MontantTotal()) / 100);
        }

        public override int MontantTva ()
        {
            return ((TauxTva * MontantTotal()) / 100);
        }
    }
}
