using System;
using System.Collections.Generic;
using System.Text;
using Facturation.ENTITE;
using Facturation.MODEL;

namespace Facturation.DAO
{
 public interface facturationDao
    {
        Product[] GetProducts();
        Boolean AddProduct();

        //coir comment récupére les donnée de base de donnée
    }
}
