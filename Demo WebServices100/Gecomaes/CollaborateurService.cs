using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Gecomaes
{
    public class CollaborateurServiceDemo
    {

        #region Données membre


        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public CollaborateurServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode démontrant comment obtenir un collaborateur par son identifiant
        /// </summary>
        public void GetCollaborateurById()
        {
            //Définition de l'identifiant du collaborateur
            int idCollaborateur = 11;

            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            //Récupération du collaborateur
            Collaborateur collaborateur = service.GetCollaborateur(idCollaborateur);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir le nombre de collaborateur
        /// </summary>
        public void GetCollaborateurCount()
        {

            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            //Récupération du nombre de collaborateur
            int count = service.GetCount();
        }

        /// <summary>
        /// Méthode démontrant comment obtenir le nombre de collaborateurs répondant à un critère
        /// </summary>
        public void GetCollaborateurCountByCriteria()
        {
            //Définition du critère
            Criteria criteriaPays = new CriteriaComparison("Pays", ComparisonOperator.Like, "France");
            Criteria criteriaRole = new CriteriaComparison("EstAcheteur", ComparisonOperator.Equals, true);
            CriteriaLogical criteria = new CriteriaLogical(criteriaPays, LogicalOperator.And, criteriaRole);

            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            //Récupération du nombre de collaborateurs répondants au critère
            int count = service.GetCount(criteria);
        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste de collaborateurs répondant à un critère
        /// </summary>
        public void GetCollaborateurListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Fonction", ComparisonOperator.Like, "Repré%");

            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            //Récupération de la liste de collaborateurs répondant au critère
            List<Collaborateur> collaborateurList = service.GetList(criteria);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste de collaborateur triée sur une propriété
        /// </summary>
        public void GetCollaborateurListOrdered()
        {
            //Définition du tri
            List<Order> orders = new List<Order>() { new Order("CodePostal", OrderType.Desc) };

            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            //Récupération de la liste de collaborateurs triée 
            List<Collaborateur> collaborateurList = service.GetList(orders: orders);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de liste de collaborateurs
        /// </summary>
        public void GetCollaborateurListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 2;
            int itemsPerPage = 3;

            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            //Récupération de la page de liste de collaborateur
            List<Collaborateur> collaborateurList = service.GetList(pageNumber: pageIndex, rowsPerPage: itemsPerPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de liste de collaborateurs comprenant l'ensemble des paramètres.
        /// </summary>
        public void GetCollaborateurListComplex()
        {

            //Définition du critère
            Criteria criteria = new CriteriaComparison("Fonction", ComparisonOperator.Like, "Repré%");

            //Définition du tri
            List<Order> orders = new List<Order>() { new Order("CodePostal", OrderType.Desc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 2;
            int itemsPerPage = 3;

            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            //Récupération de la page de liste de collaborateur
            List<Collaborateur> collaborateurList = service.GetList(criteria, orders, pageIndex, itemsPerPage);

        }

        /// <summary>
        /// Méthode démontrant comment insérer un collaborateur dans la base
        /// </summary>
        public void InsertCollaborateur()
        {
            //Définition du collaborateur à insérer
            Collaborateur collaborateur = new Collaborateur()
            {
                Matricule = "AABB",
                Adresse = "71 rue de la canne",
                CodePostal = "L3510",
                Complement = string.Empty,
                Email = "EricPinon@yahoo.com",
                EstAcheteur = false,
                EstCaissier = false,
                EstChargeRecouvrement = true,
                EstControleur = false,
                EstResponsableFinancier = false,
                EstVendeur = true,
                Fax = "00.00.00.00",
                Fonction = "Testeur",
                Gsm = "03.12.21",
                Nom = "PINON",
                Pays = "Luxembourg",
                Prenom = "Eric",
                Service = "Achat",
                Telephone = "352525252",
                Ville = "Mismak"
            };

            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            //Insertion du collaborateur
            Collaborateur collaborateurFromDb = service.Insert(collaborateur);

        }

        /// <summary>
        /// Méthode démontrant comment mettre à jour un collaborateur
        /// </summary>
        public void UpdateCollaborateur()
        {
            //Définition de l'identifiant du collaborateur
            int idCollaborateur = 17;

            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            //Récupération du collaborateur
            Collaborateur collaborateur = service.GetCollaborateur(idCollaborateur);

            //Modification du collaborateur
            collaborateur.Fonction = collaborateur.Fonction + "__Test";

            //Mise à jour du collaborateur dans la base
            service.Update(collaborateur);

        }

        /// <summary>
        /// Méthode démontrant comment supprimer un collaborateur
        /// </summary>
        public void DeleteCollaborateur()
        {
            //Définition de l'identifiant du collaborateur
            int idCollaborateur = 17;

            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            //Suppression du collaborateur dans la base
            service.Delete(idCollaborateur);

        }

        #endregion
    }
}
