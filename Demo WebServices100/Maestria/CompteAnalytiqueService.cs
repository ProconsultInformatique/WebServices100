using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Maestria
{

    public class CompteAnalytiqueServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public CompteAnalytiqueServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des comptes analytiques.
        /// </summary>
        public void GetCompteAnalytiqueList()
        {
            CompteAnalytiqueService service = new CompteAnalytiqueService(_webServiceUrl);

            //Récupération de la liste des comptes analytiques
            List<CompteAnalytique> compteAnalytiqueList = service.GetList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des comptes analytiques répondant à un critère.
        /// </summary>
        public void GetCompteAnalytiqueListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Intitule", ComparisonOperator.Like, "%dir%");

            CompteAnalytiqueService service = new CompteAnalytiqueService(_webServiceUrl);

            //Récupération de la liste des comptes analytiques répondant au critère
            List<CompteAnalytique> compteAnalytiqueList = service.GetList(criteria);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste triée selon une propriété de comptes analytiques.
        /// </summary>
        public void GetCompteAnalytiqueListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("IdPlanAnalytique", OrderType.Asc) };

            CompteAnalytiqueService service = new CompteAnalytiqueService(_webServiceUrl);

            //Récupération de la liste triée des comptes analytiques
            List<CompteAnalytique> compteAnalytiqueList = service.GetList(orders: orders);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une page de la liste des comptes analytiques.
        /// </summary>
        public void GetCompteAnalytiqueListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 6;

            CompteAnalytiqueService service = new CompteAnalytiqueService(_webServiceUrl);

            //Récupération de la page de la liste des comptes analytiques
            List<CompteAnalytique> compteAnalytiqueList = service.GetList(pageNumber: pageIndex, rowsPerPage: itemsPerPage);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste des comptes analytiques en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetCompteAnalytiqueListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Intitule", ComparisonOperator.Like, "%dir%");

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("IdPlanAnalytique", OrderType.Asc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 6;

            CompteAnalytiqueService service = new CompteAnalytiqueService(_webServiceUrl);

            //Récupération de la liste des comptes analytiques
            List<CompteAnalytique> compteAnalytiqueList = service.GetList(criteria, orders, pageIndex, itemsPerPage);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir un compte analytique par ses identifiants.
        /// </summary>
        public void GetCompteAnalytiqueById()
        {
            //Définition de l'identifiant du compte analytique (numéro de compte et numéro de plan)
            string numCompte = "9331ORF";
            short numPlan = 2;

            CompteAnalytiqueService service = new CompteAnalytiqueService(_webServiceUrl);

            //Récupération du compte analytique
            CompteAnalytique compteAnalytique = service.GetCompteAnalytique(numPlan, numCompte);

        }

        #endregion
    }
}
