using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Gecomaes
{
    public class FamilleServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public FamilleServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des familles
        /// </summary>
        public void GetFamilleList()
        {
            FamilleService service = new FamilleService(_webServiceUrl);

            //Récupération de la liste des familles
            List<Famille> familleList = service.GetList();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des familles répondant à un critère
        /// </summary>
        public void GetFamilleListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Intitule", ComparisonOperator.Like, "MONTRE%");

            FamilleService service = new FamilleService(_webServiceUrl);

            //Récupération de la liste des familles répondant au critère
            List<Famille> familleList = service.GetList(criteria);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de la liste des familles
        /// </summary>
        public void GetFamilleListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 2;
            int itemsPerPage = 5;

            FamilleService service = new FamilleService(_webServiceUrl);

            //Récupération de la page de la liste des familles
            List<Famille> familleList = service.GetList(pageNumber: pageIndex, rowsPerPage: itemsPerPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste triée selon une propriété des familles
        /// </summary>
        public void GetFamilleListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order() { FieldName = "Intitule", OrderType = OrderType.Desc } };

            FamilleService service = new FamilleService(_webServiceUrl);

            //Récupération de la liste de familles triée
            List<Famille> familleList = service.GetList(orders: orders);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste de familles en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetFamilleListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Intitule", ComparisonOperator.Like, "MONTRE%");

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order() { FieldName = "Intitule", OrderType = OrderType.Desc } };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 2;
            int itemsPerPage = 5;

            FamilleService service = new FamilleService(_webServiceUrl);

            //Récupération de la liste de familles
            List<Famille> familleList = service.GetList(criteria, orders, pageIndex, itemsPerPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste de famille selon leur type
        /// </summary>
        public void GetFamilleListByType()
        {
            //Definition du type de famille
            TypeFamille typeFamille = TypeFamille.Detail;

            FamilleService service = new FamilleService(_webServiceUrl);

            //Récupération de la liste des familles du type
            List<Famille> familleList = service.GetByType(typeFamille);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste de famille triée, suivant une propriété, selon leur type 
        /// </summary>
        public void GetFamilleListByTypeOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order() { FieldName = "Intitule", OrderType = OrderType.Desc } };

            //Définition du type de famille
            TypeFamille typeFamille = TypeFamille.Detail;

            FamilleService service = new FamilleService(_webServiceUrl);

            //Récupération de la liste de familles
            List<Famille> familleList = service.GetByType(typeFamille, orders);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de la liste de famille par type
        /// </summary>
        public void GetFamilleListByTypePaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 2;
            int itemsByPage = 5;

            //Définition du type de famille
            TypeFamille typeFamille = TypeFamille.Detail;

            FamilleService service = new FamilleService(_webServiceUrl);

            //Récupération de la page de la liste de famille
            List<Famille> familleList = service.GetByType(typeFamille, pageNumber: pageIndex, rowsPerPage: itemsByPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste de famille par type en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetFamilleListByTypeComplex()
        {
            //Définition du type de famille
            TypeFamille typeFamille = TypeFamille.Detail;

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 2;
            int itemsByPage = 5;

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order() { FieldName = "Intitule", OrderType = OrderType.Desc } };

            FamilleService service = new FamilleService(_webServiceUrl);

            //Récupération de la liste de familles
            List<Famille> familleList = service.GetByType(typeFamille, orders, pageIndex, itemsByPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une famille par son identifiant
        /// </summary>
        public void GetFamilleById()
        {
            //Définition de l'identifiant de la famille
            string codeFamille = "PRESTSAV";

            FamilleService service = new FamilleService(_webServiceUrl);

            //Récupération de la famille
            Famille famille = service.GetFamille(codeFamille);

        }

        #endregion
    }
}
