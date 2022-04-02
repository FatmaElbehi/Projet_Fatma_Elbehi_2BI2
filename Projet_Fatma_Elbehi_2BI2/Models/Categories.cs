using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Fatma_Elbehi_2BI2.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string CategorieNom { get; set; }
        public string CategorieDescription { get; set; }

        public Categories(int id, string categorieNom, string categorieDescription)
        {
            Id = id;
            CategorieNom = categorieNom;
            CategorieDescription = categorieDescription;
        }

        public Categories()
        {
        }
    }
}
