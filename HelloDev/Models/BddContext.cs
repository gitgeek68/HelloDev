using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
/*d abord le lier dans outlis,gestionnaire package nuget,gerer les packages nugets
 *parcourir,entity framework dans rechercher puis choisir celui de microsoft */


namespace HelloDev.Models//2eme etape (contexte base de données)
{
    public class BddContext:DbContext//lié à une table
    {
       public DbSet<Restaurant>Restaurants { get; set; }
        //le dal accede directement à cette entrée

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<BddContext>(null);
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BddContext>());
            base.OnModelCreating(modelBuilder);
            //si la base de donnée change le modele change automatiquement en ajoutant ou enlevant les champs
        }
    }
}