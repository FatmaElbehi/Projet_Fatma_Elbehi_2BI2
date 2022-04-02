using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Fatma_Elbehi_2BI2.Models
{
    public class Produits
    {
        //produit a une seul categorie
        //categorie contient plusieurs produits
        public int Id { get; set; }
        public string ProduitNom { get; set; }
        public string ProduitDescription { get; set; }

        public int CategorieId { get; set; }
        public virtual Categories Categories { get; set; }

        public Produits(int id, string produitNom, string produitDescription)
        {
            Id = id;
            ProduitNom = produitNom;
            ProduitDescription = produitDescription;
        }

        public Produits()
        {
        }
    }
}
