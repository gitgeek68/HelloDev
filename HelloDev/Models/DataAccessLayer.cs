using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloDev.Models//3eme etape DAL

    /* 9* lier le connectionstring dans web config */
{
    public class DataAccessLayer : IDisposable// 3.1*
                                              //Contrat avec l interface Idisposable,oblige d implementer Dispos()
    {

        private BddContext dbContext;// 1*

        public DataAccessLayer()// 2*
        {
            dbContext = new BddContext();
        }

        public void Dispose()// 3.2*
        {
            dbContext.Dispose();
            //libere les ressources de la base de données
        }

        /*signature de methode CRUD dans un 1er temps create read update delete*/
        public void GetRestaurant(int _id)// 4*
        {
            dbContext.Restaurants.FirstOrDefault(x => (x.Id == _id));

        }
        public void AddRestaurant(Restaurant _resto)// 5*
        {
            dbContext.Restaurants.Add(_resto);
            //ajoute le client
            //== insert into en sql
            dbContext.SaveChanges();
            //sauvegarde
        }

        public void UpdateRestaurant(Restaurant _resto)// 6*
        {

            Restaurant exist = dbContext.Restaurants.FirstOrDefault(x => (x.Id == _resto.Id));
            //va rechercher dans la liste de produits,puis compare les identidifiants pour retrouver le meme
            if (exist != default(Restaurant))//preferer default à "null" pour les cas ou le retour est 0 ou autre
            {
                exist.Nom = _resto.Nom;
                exist.Specialite = _resto.Specialite;
                exist.Telephone = _resto.Telephone;
                dbContext.SaveChanges();

            }
        }

        public void DeleteRestaurant(int _id)// 7*
        {
            Restaurant exist = dbContext.Restaurants.FirstOrDefault(x => (x.Id == _id));
            if (exist != default(Restaurant))
            {
                dbContext.Restaurants.Remove(exist);
                dbContext.SaveChanges();
            }
        }

        public List<Restaurant> GetRestaurants()// 8*
        {
            return dbContext.Restaurants.ToList();
            //== select * from Restaurants en sql
        }

        public void TruncatRestaurants() // 10*
        {
            dbContext.Database.ExecuteSqlCommand("TRUNCATE TABLE Restaurants;");
            //efface la table sql Clients
            dbContext.SaveChanges();
        }




    }
}