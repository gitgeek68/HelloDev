using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloDev.Models;//reference ajouté
/*clic droit HelloDev_Test,ajouter reference,projet et cocher la projet*/

    //ajouter connectionstaing dans app.config

namespace HelloDev_Test // 4* Test
{
    [TestClass]
    public class UnitTest1
    {
        DataAccessLayer dal = new DataAccessLayer();

        [TestMethod]
        public void TestMethod1()
        {


            Restaurant resto1 = new Restaurant();

            resto1.Nom = "L'alsace";
            resto1.Specialite = "alsace";
            resto1.Telephone = "+33898989898";

            int nbResto = dal.GetRestaurants().Count;

            dal.AddRestaurant(resto1);

            Assert.AreEqual((nbResto + 1), dal.GetRestaurants().Count);

        }
    }
}
