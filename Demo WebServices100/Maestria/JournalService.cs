using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Maestria
{
    public class JournalServiceDemo
    {

        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public JournalServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode démontrant comment obtenir un journal par son code.
        /// </summary>
        public void GetJournalByCode()
        {
            //Définition du code journal
            string codeJournal = "ACH";

            JournalService service = new JournalService(_webServiceUrl);

            //Récupération du journal
            Journal journal = service.GetJournal(codeJournal);
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des journaux.
        /// </summary>
        public void GetJournalList()
        {
            JournalService service = new JournalService(_webServiceUrl);

            //Récupération de la liste des journaux
            List<Journal> journalList = service.GetList();
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste de journaux répondants à un critère.
        /// </summary>
        public void GetJournalListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("TypeNumerotationPiece", ComparisonOperator.NotEqualTo, TypeNumerotationPieceJournal.ContinueJournal);

            JournalService service = new JournalService(_webServiceUrl);
            
            //Récupération de la liste des journaux répondants au critère
            List<Journal> journalList = service.GetList(criteria);
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste triée de journaux selon une propriété.
        /// </summary>
        public void GetJournalListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("CompteGeneral", OrderType.Desc) };

            JournalService service = new JournalService(_webServiceUrl);

            //Récupération de la liste triée
            List<Journal> journalList = service.GetList(orders: orders);
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de liste de journaux.
        /// </summary>
        public void GetJournalListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 2;
            int rowsPerPage = 6;
            
            JournalService service = new JournalService(_webServiceUrl);

            //Récupération de la page de journaux
            List<Journal> journalList = service.GetList(rowsPerPage: rowsPerPage, pageNumber: pageIndex);
            
        }

        #endregion
    }
}
