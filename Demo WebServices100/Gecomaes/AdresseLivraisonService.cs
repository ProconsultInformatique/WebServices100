using System;
using System.Linq;
using System.Collections.Generic;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;

namespace DemoWebServices100.Gecomaes
{
    public class AdresseLivraisonServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public AdresseLivraisonServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des adresses de livraison
        /// </summary>
        public void GetAdresseLivraisonList()
        {
            AdresseLivraisonService service = new AdresseLivraisonService(_webServiceUrl);

            //Récupération de la liste des adresses de livraison
            IList<AdresseLivraison> AdresseLivraison = service.GetList();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des adresses de livraison d'un tiers
        /// </summary>
        public void GetAdresseLivraisonListByIdTiers()
        {
            //Définition de l'identifiant du tiers
            string idTiers = "BAGUES";

            AdresseLivraisonService service = new AdresseLivraisonService(_webServiceUrl);

            //Récupération de la liste des adresses de livraison du tiers
            IList<AdresseLivraison> AdresseLivraison = service.GetListByTiers(idTiers);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste d'adresse de livraison répondant à un critère
        /// </summary>
        public void GetAdresseLivraisonListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Pays", ComparisonOperator.Like, "France");

            AdresseLivraisonService service = new AdresseLivraisonService(_webServiceUrl);

            //Récupération de la liste des adresses de livraison répondant au critère
            IList<AdresseLivraison> AdresseLivraison = service.GetList(criteria);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de liste d'adresses de livraison
        /// </summary>
        public void GetAdresseLivraisonListPaged()
        {
            //Définition de l'index de la page et du nombre d'élément par page
            int pageIndex = 2;
            int adresseParPage = 10;

            AdresseLivraisonService service = new AdresseLivraisonService(_webServiceUrl);

            //Récupération de la page de liste d'adresses de livraison
            IList<AdresseLivraison> AdresseLivraison = service.GetList(pageNumber: pageIndex, rowsPerPage: adresseParPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste d'adresse de livraison triée par une propriété
        /// </summary>
        public void GetAdresseLivraisonListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> ordersAsc = new List<Order>() { new Order("NumeroTiers", OrderType.Asc) };

            AdresseLivraisonService service = new AdresseLivraisonService(_webServiceUrl);

            //Récupération de la liste d'adresses de livraison triée
            IList<AdresseLivraison> AdresseLivraisonAsc = service.GetList(orders: ordersAsc);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste d'adresse de livraison en combinant l'ensemble des paramètres.
        /// </summary>
        public void GetAdresseLivraisonListComplex()
        {
            //Définition de la méthode de tri
            List<Order> ordersAsc = new List<Order>() { new Order("NumeroTiers", OrderType.Asc) };

            //Définition de l'index de la page et du nombre d'élément par page
            int pageIndex = 2;
            int itemsPerPage = 10;

            //Définition du critère
            Criteria criteria = new CriteriaComparison("Pays", ComparisonOperator.Like, "France");

            AdresseLivraisonService service = new AdresseLivraisonService(_webServiceUrl);

            //Récupération de la liste d'adresses de livraison
            IList<AdresseLivraison> AdresseLivraisonAsc = service.GetList(criteria, ordersAsc, pageIndex, itemsPerPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir le nombre d'adresses de livraison répondant à un critère
        /// </summary>
        public void GetAdresseLivraisonCountByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Pays", ComparisonOperator.Like, "France");


            AdresseLivraisonService service = new AdresseLivraisonService(_webServiceUrl);

            //Récupération du nombre d'adresses de livraison
            int nbAdressesLivraison = service.GetCount(criteria);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une adresse de livraison
        /// </summary>
        public void GetAdresseLivraison()
        {
            //Définition de l'identifiant de l'adresse de livraison
            string idTiers = "BAGUES";
            int idAdresse = 1;

            AdresseLivraisonService service = new AdresseLivraisonService(_webServiceUrl);

            //Récupération de l'adresse de livraison
            AdresseLivraison AdresseLivraison = service.GetAdresseLivraison(idTiers, idAdresse);

        }


        /// <summary>
        /// Méthode démontrant comment insérer une adresse de livraison dans la base
        /// </summary>
        public void InsertAdresseLivraison()
        {
            //Définition de l'adresse de livraison à insérer
            AdresseLivraison adresse = new AdresseLivraison();
            adresse.Id = 0;
            adresse.Intitule = "Toto Intitule ";
            adresse.Contact = "Di Muzio Valerian";
            adresse.Adresse = "Rue de la liberation 17";
            adresse.Complement = "boite 3";
            adresse.CodePostal = "3510";
            adresse.Ville = "Dudelange";
            adresse.Pays = "Luxembourg";
            adresse.Region = "Luxembourg";
            adresse.Fax = "+352 26 31 32 51";
            adresse.Telephone = "+352 26 31 32 51";
            adresse.Email = "info@proconsult.lu";
            adresse.NumeroTiers = "BAGUES";

            AdresseLivraisonService service = new AdresseLivraisonService(_webServiceUrl);

            //Insertion de l'adresse de livraison dans la base
            AdresseLivraison adresseLivraisonFromDb = service.Insert(adresse);

        }

        /// <summary>
        /// Méthode démontrant comment mettre à jour une adresse de livraison
        /// </summary>
        public void UpdateAdresseLivraison()
        {
            //Définition de l'identifiant de l'adresse de livraison
            string idTiers = "BAGUES";
            int idAdresse = 1;

            AdresseLivraisonService service = new AdresseLivraisonService(_webServiceUrl);

            //Récupération de l'adresse de livraison
            AdresseLivraison adresse = service.GetAdresseLivraison(idTiers, idAdresse);

            //Modification de l'adresse de livraison            
            adresse.Intitule = "TestUpdateAdress";
            adresse.Contact = "contact modifié";

            //Mise à jour de l'adresse de livraison dans la base
            AdresseLivraison adresse2 = service.Update(adresse);

        }

        /// <summary>
        /// Méthode démontrant comment supprimer une adresse de livraison
        /// </summary>
        public void DeleteAdresseLivraison()
        {
            //Définition de l'identifiant de l'adresse de livraison
            string idTiers = "BAGUES";
            int idAdresse = 1;

            AdresseLivraisonService service = new AdresseLivraisonService(_webServiceUrl);

            //Suppression de l'adresse de livraison de la base
            service.Delete(idTiers, idAdresse);
        }

        #endregion  
    }
}
