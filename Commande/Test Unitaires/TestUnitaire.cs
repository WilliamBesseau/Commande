using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionCommande.controleur;
using System.Linq;
using System.Collections.ObjectModel;
using GestionCommande.model;

namespace Commandes.Test_Unitaires
{
    /// <summary>
    /// Description résumée pour TestUnitaire
    /// </summary>
    [TestClass]
    public class TestUnitaire
    {
        [TestMethod]
        public void CreerClient()
        {
            Controleur controleur = new CommandeControleur();
            controleur.CreerClient("Besseau", "William", "williambesseau@gmail.com");
            Assert.AreEqual(controleur.GetClients().Last().Nom, "Besseau");
            Assert.AreEqual(controleur.GetClients().Last().Prenom, "William");
            Assert.AreEqual(controleur.GetClients().Last().Mail, "williambesseau@gmail.com");
        }
        [TestMethod]
        public void CreerProduit()
        {
            Controleur controleur = new CommandeControleur();
            controleur.CreerUnProduit("Carotte", 500);
            Assert.AreEqual(controleur.GetProduits().Last().Designation, "Carotte");
            Assert.AreEqual(controleur.GetProduits().Last().Prix, 500);
        }
        [TestMethod]
        public void CreerCommande()
        {
            Controleur controleur = new CommandeControleur();
            List<LigneCommande> Produit = new List<LigneCommande>();
            controleur.CreerCommande(controleur.GetClients().Last(), Produit);
            Assert.AreEqual(controleur.GetCommandes().Last().LignesCommande, Produit);
            Assert.AreEqual(controleur.GetCommandes().Last().Client, controleur.GetClients().Last());
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active, ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
                
    }
}
