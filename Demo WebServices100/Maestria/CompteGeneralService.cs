using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Maestria
{
    public class CompteGeneralServiceDemo
    {
        #region Données membres

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public CompteGeneralServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion


        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des comptes généraux.
        /// </summary>
        public void GetCompteGeneralList()
        {
            CompteGeneralService service = new CompteGeneralService(_webServiceUrl);

            //Récupération de la liste des comptes généraux
            List<CompteGeneral> compteGeneralList = service.GetList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des comptes généraux selon un critère.
        /// </summary>
        public void GetCompteGeneralListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Intitule", ComparisonOperator.Like, "%fo%");

            CompteGeneralService service = new CompteGeneralService(_webServiceUrl);
            
            //Récupération de la liste des comptes généraux filtrée
            List<CompteGeneral> compteGeneralList = service.GetList(criteria);
            
        }

        /// <summary>
        /// Cette méthode montre comment obtenir une page d'une liste de comptes généraux.
        /// </summary>
        public void GetCompteGeneralListPaged()
        {
            //Définition de la page à obtenir et du nombre d'éléments par page
            int pageIndex = 5;
            int itemsByPage = 8;

            CompteGeneralService service = new CompteGeneralService(_webServiceUrl);

            //Récupération de la page de comptes généraux
            List<CompteGeneral> compteGeneralList = service.GetList(pageNumber: pageIndex, rowsPerPage: itemsByPage);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de comptes généraux triée sur une propriété.
        /// </summary>
        public void GetCompteGeneralListOrdered()
        {
            //Définition du tri
            List<Order> orders = new List<Order>() { new Order("NatureCompte", OrderType.Asc) };

            CompteGeneralService service = new CompteGeneralService(_webServiceUrl);
            
            //Récupération de la liste des comptes généraux triée
            List<CompteGeneral> compteGeneralList = service.GetList(orders: orders);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir un compte général par son identifiant.
        /// </summary>
        public void GetCompteGeneralById()
        {
            //Définition de l'identifiant du compte général
            string numCompte = "2772000";


            CompteGeneralService service = new CompteGeneralService(_webServiceUrl);

            //Récupération du compte général
            CompteGeneral compteGeneral = service.GetCompteGeneral(numCompte);
            
        }

        /// <summary>
        /// Cette méthode montre comment insérer un compte général sans utiliser 
        /// le process de Sage pour alimenter les champs non renseignés.
        /// </summary>
        public void InsertCompteGeneralWithoutSageProcess()
        {
            //Définition du compte général à insérer
            CompteGeneral compteGeneral = new CompteGeneral()
            {
                EstAnalytique = true,
                EstEnSommeil = false,
                NatureCompte = TypeNatureCompte.Charge,
                Intitule = "TestInsert_WebService",
                NumeroCompte = "6660066600",
                ReportCompte = TypeReportCompte.Aucun,
                TypeCompte = TypeCompte.Detail
            };
            
            CompteGeneralService service = new CompteGeneralService(_webServiceUrl);
            
            //Insertion du compte général dans la base
            CompteGeneral compteGeneralFromDB = service.Insert(compteGeneral, false);
            
        }

        /// <summary>
        /// Cette méthode montre comment insérer un compte général dans la base
        /// en utilisant le process de Sage pour alimenter les champs non renseignés.
        /// </summary>
        public void InsertCompteGeneralWithSageProcess()
        {
            //Définition du compte général à insérer
            CompteGeneral compteGeneral = new CompteGeneral()
            {
                Intitule = "TestInsert_WebService",
                NumeroCompte = "6660066600"
            };
            
            CompteGeneralService service = new CompteGeneralService(_webServiceUrl);
            
            //Insertion du compte général dans la base
            CompteGeneral compteGeneralFromDB = service.Insert(compteGeneral, true);

        }

        #endregion
    }
}
