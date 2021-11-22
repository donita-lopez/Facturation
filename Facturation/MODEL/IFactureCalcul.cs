using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Facturation.ENTITE;

namespace Facturation.MODEL
{
  interface IFactureCalcul
    {
        void AddProduct(Product pro);
        int MontantPayer(params Product [] pro);
        int MontantTotal();
        int MontantRemise();
        int MontantTva();
    }
}
