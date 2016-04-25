using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Maestria
{

    public class EcritureServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public EcritureServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Ecriture

        /// <summary>
        /// Méthode démontrant comment obtenir une écriture comptable par son identifiant.
        /// </summary>
        public void GetEcritureById()
        {
            //Définition de l'identifiant de l'écriture
            int idEcriture = 103;

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de l'écriture
            Ecriture ecriture = service.GetEcriture(idEcriture);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des écritures comptables.
        /// </summary>
        public void GetEcritureList()
        {
            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la liste des écritures comptables
            List<Ecriture> ecritureList = service.GetListEcritures();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des écritures comptables répondants à un critère.
        /// </summary>
        public void GetEcritureListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("EstLettree", ComparisonOperator.NotEqualTo, true);

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la liste des écritures comptables répondant au critère
            List<Ecriture> ecritureList = service.GetListEcritures(criteria);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste triée des écritures comptables suivant une propriété.
        /// </summary>
        public void GetEcritureListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroFacture", OrderType.Asc) };

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la liste des écritures comptables
            List<Ecriture> ecritureList = service.GetListEcritures(orders: orders);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page d'écritures comptables.
        /// </summary>
        public void GetEcritureListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int rowsPerPage = 5;

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la page d'écritures comptables
            List<Ecriture> ecritureList = service.GetListEcritures(rowsPerPage: rowsPerPage, pageNumber: pageIndex);

        }

        #region ByCompteGeneral

        /// <summary>
        /// Méthode démontrant comment obtenir les écritures comptables d'un compte général.
        /// </summary>
        public void GetEcritureListByCompteGeneral()
        {
            //Définition du numéro de compte général
            string numCompteGeneral = "4010000";

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération des écritures
            List<Ecriture> ecritureList = service.GetEcrituresByCompteGeneral(numCompteGeneral);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir les écritures comptables d'un compte général sur une période.
        /// </summary>
        public void GetEcritureListByCompteGeneral_Periode()
        {
            //Définition du numéro de compte général et de la période
            string numCompteGeneral = "4010000";
            DateTime dateDebut = new DateTime(2014, 1, 1);
            DateTime dateFin = new DateTime(2014, 12, 31);
            Periode periode = new Periode(dateDebut, dateFin, false);

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la liste des écritures
            List<Ecriture> ecritureList = service.GetEcrituresByCompteGeneral(numCompteGeneral, periode);

        }


        public void GetEcritureListByCompteGeneralOrdered()
        {
            //Définition du numéro de compte général
            string numCompteGeneral = "4010000";

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("Montant", OrderType.Asc) };

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la liste triée des écritures comptables
            List<Ecriture> ecritureList = service.GetEcrituresByCompteGeneral(numCompteGeneral, orders: orders);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page d'écritures comptables d'un compte général.
        /// </summary>
        public void GetEcritureListByCompteGeneralPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 4;
            int rowsPerPage = 10;

            //Définition du numéro de compte général
            string numCompteGeneral = "4010000";

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la page des écritures comptable
            List<Ecriture> ecritureList = service.GetEcrituresByCompteGeneral(numCompteGeneral, pageNumber: pageIndex, rowsPerPage: rowsPerPage);

        }

        #endregion

        #region ByCodeJournal

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des écritures comptables d'un journal.
        /// </summary>
        public void GetEcritureListByJournal()
        {
            //Définition du code journal
            string codeJournal = "ACH";

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération des écritures du journal
            List<Ecriture> ecritureList = service.GetEcrituresByJournal(codeJournal);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des écritures comptables d'un journal sur une période.
        /// </summary>
        public void GetEcritureListByCodeJournal_AndPeriode()
        {
            //Définition du code journal et de la période
            string codeJournal = "VTE";
            DateTime dateDebut = new DateTime(2013, 1, 1);
            DateTime dateFin = new DateTime(2013, 12, 31);
            Periode periode = new Periode(dateDebut, dateFin, false);

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération des écritures
            List<Ecriture> ecritureList = service.GetEcrituresByJournal(codeJournal, periode);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste triée des écritures comptables d'un journal.
        /// </summary>
        public void GetEcritureListByCodeJournalOrdered()
        {
            //Définition du code journal
            string codeJournal = "ACH";

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroPiece", OrderType.Asc) };

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la liste triée des écritures comptables
            List<Ecriture> ecritureList = service.GetEcrituresByJournal(codeJournal, orders: orders);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de la liste des écritures comptables d'un journal.
        /// </summary>
        public void GetEcritureListByCodeJournalPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 4;
            int rowsPerPage = 10;

            //Définition du code journal
            string codeJournal = "VTE";

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la liste des écritures
            List<Ecriture> ecritureList = service.GetEcrituresByJournal(codeJournal, pageNumber: pageIndex, rowsPerPage: rowsPerPage);

        }

        #endregion

        #region ByCodeTiers

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des écritures comptables d'un tiers.
        /// </summary>
        public void GetEcritureListByCodeTiers()
        {
            //Définition du numéro de tiers
            string numtiers = "ECLAT";

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération des écritures comptables du tiers
            List<Ecriture> ecritureList = service.GetEcrituresByTiers(numtiers);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des écritures comptables d'un tiers sur une période.
        /// </summary>
        public void GetEcritureListByCodeTiersAndPeriode()
        {
            //Définition du numéro de tiers et de la période
            string numTiers = "BILLO";
            DateTime dateDebut = new DateTime(2014, 1, 1);
            DateTime dateFin = new DateTime(2014, 12, 31);
            Periode periode = new Periode(dateDebut, dateFin, false);

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la liste des écritures comptables
            List<Ecriture> ecritureList = service.GetEcrituresByTiers(numTiers, periode);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste triée des écritures comptables d'un tiers.
        /// </summary>
        public void GetEcrituresByCodeTiersOrdered()
        {
            //Définition du code tiers
            string numTiers = "TOPAZ";

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("Id", OrderType.Asc) };

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la liste des écritures comptables
            List<Ecriture> ecritureList = service.GetEcrituresByTiers(numTiers, orders: orders);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page d'écritures comptables d'un tiers.
        /// </summary>
        public void GetEcritureListByCodeTiersPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageNumber = 4;
            int rowsPerPage = 10;

            //Définition du code tiers.
            string numTiers = "CARAT";

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la liste des écritures comptables
            List<Ecriture> ecritureList = service.GetEcrituresByTiers(numTiers, pageNumber: pageNumber, rowsPerPage: rowsPerPage);

        }

        #endregion

        /// <summary>
        /// Méthode démontrant comment insérer une liste d'écritures comptables dans la base.
        /// </summary>
        public void InsertEcritureList()
        {
            //Définition de la liste d'écritures comptables
            List<Ecriture> ecritureList = GetPiece3Ecritures();

            EcritureService service = new EcritureService(_webServiceUrl);

            //Insertion de la liste d'écritures comptables dans la base
            service.InsertEcritures(ecritureList);

        }

        /// <summary>
        /// Méthode démontrant comment insérer une pièce comptable dans la base avec le paramètre useSageProcess à true.
        /// </summary>
        public void InsertPiece_SageProcessTrue()
        {
            bool useSageProcess = true;

            //Définition de la pièce comptable
            Ecriture piece = GetNewPiece(useSageProcess);

            /*
            Nota: une écriture de pièce est une écriture contenant
            tout ce qui est nécessaire afin de générer la liste d'écritures comptables
            */

            EcritureService service = new EcritureService(_webServiceUrl);

            //Insertion de la pièce comptable
            List<Ecriture> ecrituresPiece = service.InsertPiece(piece, useSageProcess);
        }

        /// <summary>
        /// Méthode démontrant comment lettrer des écritures comptables.
        /// </summary>
        public void LettrerEcritureList()
        {
            //Définition des identifiants des écritures à lettrer ensemble
            int idEcriture1 = 1171;
            int idEcriture2 = 1188;

            EcritureService service = new EcritureService(_webServiceUrl);

            //Définition d'un critère afin de récupérer les écritures à lettrer ensemble
            Criteria criteriaId1 = new CriteriaComparison("Id", ComparisonOperator.Equals, idEcriture1);
            Criteria criteriaId2 = new CriteriaComparison("Id", ComparisonOperator.Equals, idEcriture2);
            Criteria criteria = new CriteriaLogical(criteriaId1, LogicalOperator.Or, criteriaId2);

            //Récupération des écritures à lettrer ensemble
            List<Ecriture> ecritureList = service.GetListEcritures(criteria);

            //Lettrage des écritures
            service.LettrerEcritures(ecritureList);

        }

        #endregion

        #region Ecriture analytique

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des écritures analytiques associées à une écriture comptable.
        /// </summary>
        public void GetEcritureAnalytiqueList()
        {
            //Définition de l'identifiant d'écriture comptable
            int idEcriture = 51;

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération des écritures analytiques
            List<EcritureAnalytique> ecritureAnalytiqueList = service.GetListAnalytique(idEcriture);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des écritures analytiques, associées à une écriture comptable, d'un plan.
        /// </summary>
        public void GetEcritureAnalytiqueListByPlan()
        {
            //Définition de l'identifiant de l'écriture comptable et du numéro de plan analytique
            int idEcriture = 127;
            int idPlan = 1;

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la liste des écritures analytiques
            List<EcritureAnalytique> ecritureAnalytiqueList = service.GetListAnalytiqueByPlan(idEcriture, idPlan);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des écritures analytiques, associées à une écriture comptable, d'une section analytique.
        /// </summary>
        public void GetEcritureAnalytiqueListBySection()
        {
            //Définition de l'identifiant de l'écriture comptable et du numéro de section analytique
            int idPlan = 3;
            string numSection = "950BIJO";

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération de la liste des écritures analytiques
            List<EcritureAnalytique> ecritureAnalytiqueList = service.GetListAnalytiqueBySection(idPlan, numSection);

        }

        /// <summary>
        /// Méthode démontrant comment insérer une liste d'écritures analytiques dans la base.
        /// </summary>
        public void InsertEcritureAnalytiqueList()
        {
            //Définition de l'identifiant d'écritures comptables
            int idEcriture = 1195;

            //Définition de la liste d'écritures analytiques
            List<EcritureAnalytique> ecritureAnalytiqueList = GetNewEcritureAnalytiqueList(idEcriture);

            EcritureService service = new EcritureService(_webServiceUrl);

            //Insertion de la liste d'écritures analytiques
            service.InsertAnalytiques(ecritureAnalytiqueList);

        }

        /// <summary>
        /// Méthode démontrant comment supprimer de la base, les écritures analytiques d'une écriture comptable.
        /// </summary>
        public void DeleteEcrituresAnalytiquesByIdEcritureComptable()
        {

            //Définition de l'identifiant de l'écriture analytique
            int idEcriture = 1195;

            EcritureService service = new EcritureService(_webServiceUrl);

            //Suppression des écritures analytiques de l'écriture dans la base
            service.DeleteAnalytique(idEcriture);

        }

        /// <summary>
        /// Méthode démontrant comment supprimer de la base, les écritures analytiques d'une écriture comptable et d'un plan.
        /// </summary>
        public void DeleteEcrituresAnalytiquesByIdEcritureComptableAndByPlan()
        {
            //Définition de l'identifiant de l'écriture comptable et de l'identifiant du plan analytique
            int idEcriture = 1195;
            int idPlan = 1;

            EcritureService service = new EcritureService(_webServiceUrl);

            //Suppression des écritures analytiques
            service.DeleteAnalytiqueByPlan(idEcriture, idPlan);

        }

        #endregion

        /// <summary>
        /// Méthode démontrant comment obtenir le dernier numéro de pièce comptable d'un journal.
        /// </summary>
        public void GetLastPiece()
        {
            //Définition du code journal
            string codeJournal = "VTE";

            //Définition de la date. (permet de déterminer le mois dans le cas de journal en numérotation mensuel).
            DateTime date = new DateTime(2014, 6, 8);

            EcritureService service = new EcritureService(_webServiceUrl);

            //Récupération du dernier numéro de pièce comptable
            string lastPiece = service.GetLastPiece(codeJournal, date);
        }

        #region static


        /// <summary>
        /// Méthode de fabrication d'une liste de 3 écritures comptables représentant une pièce comptable.
        /// </summary>
        /// <returns></returns>
        private static List<Ecriture> GetPiece3Ecritures()
        {
            List<Ecriture> list = new List<Ecriture>();

            // Ecriture tiers
            Ecriture ecriture = new Ecriture();
            ecriture.Id = 0;
            ecriture.CodeJournal = "ACH";
            ecriture.NumeroPiece = String.Empty;
            ecriture.DateEcriture = new DateTime(2014, 1, 15);
            ecriture.DateEcheance = new DateTime(2014, 3, 2);

            ecriture.NumeroFacture = "FACT10000";
            ecriture.Reference = "REF 123456";
            ecriture.Intitule = "Ecritures de test";

            ecriture.CompteGeneral = "";
            ecriture.CompteGeneralContrepartie = null;
            ecriture.NumeroTiers = "ECLAT";
            ecriture.NumeroTiersContrepartie = null;

            ecriture.Montant = 1196;
            ecriture.Sens = SensEcriture.Credit;

            ecriture.Parite = 0;
            ecriture.MontantDevise = 0;
            ecriture.IdDevise = 0;

            ecriture.CodeTaxe = null;
            ecriture.IdReglement = 4;

            list.Add(ecriture);

            // Ecriture HT
            ecriture = new Ecriture();
            ecriture.Id = 0;
            ecriture.CodeJournal = "ACH";
            ecriture.NumeroPiece = String.Empty;
            ecriture.DateEcriture = new DateTime(2014, 1, 15);

            ecriture.NumeroFacture = "FACT10000";
            ecriture.Reference = "REF 123456";
            ecriture.Intitule = "Ecritures de test";

            ecriture.CompteGeneral = "607100";
            ecriture.CompteGeneralContrepartie = "4010000";
            ecriture.NumeroTiers = null;
            ecriture.NumeroTiersContrepartie = "ECLAT";

            ecriture.Montant = 1000;
            ecriture.Sens = SensEcriture.Debit;

            ecriture.Parite = 0;
            ecriture.MontantDevise = 0;
            ecriture.IdDevise = 0;

            ecriture.CodeTaxe = "C19";
            ecriture.IdReglement = 0;

            list.Add(ecriture);

            // Ecriture taxe
            ecriture = new Ecriture();
            ecriture.Id = 0;
            ecriture.CodeJournal = "ACH";
            ecriture.NumeroPiece = String.Empty;
            ecriture.DateEcriture = new DateTime(2014, 1, 15);

            ecriture.NumeroFacture = "FACT10000";
            ecriture.Reference = "REF 123456";
            ecriture.Intitule = "Ecritures de test";

            ecriture.CompteGeneral = "4456619";
            ecriture.CompteGeneralContrepartie = "4010000";
            ecriture.NumeroTiers = null;
            ecriture.NumeroTiersContrepartie = "ECLAT";

            ecriture.Montant = 196;
            ecriture.Sens = SensEcriture.Debit;

            ecriture.Parite = 0;
            ecriture.MontantDevise = 0;
            ecriture.IdDevise = 0;

            ecriture.CodeTaxe = "C19";
            ecriture.IdReglement = 0;

            list.Add(ecriture);

            return list;

        }

        /// <summary>
        /// Méthode de fabrication d'une liste d'écritures analytiques
        /// </summary>
        /// <param name="idEcriture">identifiant de l'écriture comptable de destination</param>
        /// <returns></returns>
        private static List<EcritureAnalytique> GetNewEcritureAnalytiqueList(int idEcriture)
        {
            List<EcritureAnalytique> list = new List<EcritureAnalytique>();

            EcritureAnalytique ecriture = new EcritureAnalytique();
            ecriture.IdEcriture = idEcriture;
            ecriture.IdPlanAnalytique = 1;
            ecriture.Montant = 200;
            ecriture.Section = "921SI1";
            list.Add(ecriture);

            ecriture = new EcritureAnalytique();
            ecriture.IdEcriture = idEcriture;
            ecriture.IdPlanAnalytique = 1;
            ecriture.Montant = 300;
            ecriture.Section = "921SI2";
            list.Add(ecriture);

            ecriture = new EcritureAnalytique();
            ecriture.IdEcriture = idEcriture;
            ecriture.IdPlanAnalytique = 2;
            ecriture.Montant = 250;
            ecriture.Section = "9301AR";
            list.Add(ecriture);

            ecriture = new EcritureAnalytique();
            ecriture.IdEcriture = idEcriture;
            ecriture.IdPlanAnalytique = 2;
            ecriture.Montant = 250;
            ecriture.Section = "9301OR";
            list.Add(ecriture);

            return list;
        }

        /// <summary>
        /// Méthode de fabrication d'une écriture comptable contenant tout ce qui est nécessaire
        /// afin de fabriquer une pièce comptable.
        /// </summary>
        /// <param name="useSageProcess"></param>
        /// <returns></returns>
        private static Ecriture GetNewPiece(bool useSageProcess)
        {
            Ecriture piece = new Ecriture();
            piece.CodeJournal = "ACH";
            //piece.NumeroPiece = String.Empty;
            piece.DateEcriture = new DateTime(2015, 1, 15);
            piece.NumeroFacture = "FACT10000";
            piece.Reference = "REF 123456";
            piece.Intitule = "Ecriture piece";
            piece.CompteGeneralContrepartie = "701019";
            piece.Montant = 1200;
            piece.NumeroTiers = "BILLO";
            piece.Sens = SensEcriture.Debit;

            if (!useSageProcess)
            {
                piece.CodeTaxe = "VL17";
                piece.CompteGeneral = "44210000";
                piece.DateEcheance = new DateTime(2016, 3, 5);
            }

            return piece;
        }

        #endregion
    }
}
