using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projet_Fatma_Elbehi_2BI2.Models;

namespace Projet_Fatma_Elbehi_2BI2.Data
{
    public class Projet_Fatma_Elbehi_2BI2Context : DbContext
    {
        public Projet_Fatma_Elbehi_2BI2Context (DbContextOptions<Projet_Fatma_Elbehi_2BI2Context> options)
            : base(options)
        {
        }

        public DbSet<Projet_Fatma_Elbehi_2BI2.Models.Client> Client { get; set; }

        public DbSet<Projet_Fatma_Elbehi_2BI2.Models.Produits> Produits { get; set; }

        public DbSet<Projet_Fatma_Elbehi_2BI2.Models.Categories> Categories { get; set; }

        public DbSet<Projet_Fatma_Elbehi_2BI2.Models.Ordres> Ordres { get; set; }
    }
}
