using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Fatma_Elbehi_2BI2.Models
{
    public class Ordres
    {
        public int Id { get; set; }

        public string prix { get; set; }

        public int ProduitId { get; set; }
        public virtual Produits Produits { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public Ordres(int id, string prix)
        {
            Id = id;
            this.prix = prix;
        }

        public Ordres()
        {
        }
    }
}
