using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;
using System.Linq;

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
        /// Cette méthode montre comment obtenir un collaborateur par son identifiant.
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
        /// Cette méthode montre comment obtenir le nombre de collaborateur.
        /// </summary>
        public void GetCollaborateurCount()
        {

            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            //Récupération du nombre de collaborateur
            int count = service.GetCount();
        }

        /// <summary>
        /// Cette méthode montre comment obtenir le nombre de collaborateurs répondant à un critère.
        /// </summary>
        public void GetCollaborateurCountByCriteria()
        {
            //Définition du critère
            Criteria criteriaPays = new CriteriaComparison("Pays", ComparisonOperator.Like, "France");
            Criteria criteriaRole = new CriteriaComparison("EstAcheteur", ComparisonOperator.Equals, true);
            CriteriaLogical criteria = new CriteriaLogical(criteriaPays, LogicalOperator.And, criteriaRole);

            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            //Récupération du nombre de collaborateurs répondant au critère
            int count = service.GetCount(criteria);
        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de collaborateurs répondant à un critère.
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
        /// Cette méthode montre comment obtenir une liste de collaborateur triée sur une propriété.
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
        /// Cette méthode montre comment obtenir une page de liste de collaborateurs.
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
        /// Cette méthode montre comment obtenir une page de liste de collaborateurs comprenant l'ensemble des paramètres.
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
        /// Cette méthode montre comment insérer un collaborateur dans la base.
        /// </summary>
        public void InsertCollaborateur()
        {
            //Définition du collaborateur à insérer
            Collaborateur collaborateur = new Collaborateur()
            {
                Matricule = "PROINFO",
                Adresse = "Rue de la Libération 17",
                CodePostal = "L3510",
                Complement = string.Empty,
                Email = "Info@Proconsult.lu",
                EstAcheteur = false,
                EstCaissier = false,
                EstChargeRecouvrement = true,
                EstControleur = false,
                EstResponsableFinancier = false,
                EstVendeur = true,
                Fax = "+352 26 31 32 51",
                Fonction = "Gérant",
                Gsm = "03.12.21",
                Nom = "Di Muzio",
                Pays = "Luxembourg",
                Prenom = "Valerian",
                Service = "Achat",
                Telephone = "+352 26 31 32 51",
                Ville = "Dudelange"
            };
            
            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            //Insertion du collaborateur
            Collaborateur collaborateurFromDb = service.Insert(collaborateur);

        }

        /// <summary>
        /// Cette méthode montre comment mettre à jour un collaborateur.
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
        /// Cette méthode montre comment supprimer un collaborateur.
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

        #region Méthodes métiers

        /// <summary>
        /// Cette méthode montre comment mettre à jour l'adresse d'un collaborateur.
        /// </summary>
        public void DemonstrationMiseAJourCollaborateur()
        {
            //Définition du critère
            Criteria critereNom = new CriteriaComparison("Nom", ComparisonOperator.Equals, "CHEVALIER");
            Criteria criterePrenom = new CriteriaComparison("Prenom", ComparisonOperator.Equals, "Eric");
            Criteria criteria = new CriteriaLogical(critereNom, LogicalOperator.And, criterePrenom);

            CollaborateurService service = new CollaborateurService(_webServiceUrl);

            Collaborateur collaborateur = service.GetList(criteria).FirstOrDefault();

            collaborateur.CodePostal = "L3510";
            collaborateur.Adresse = "17 Rue de la Libération";
            collaborateur.Email = "Info@Proconsult.lu";
            collaborateur.Fax = "+352 26 31 32 51";
            collaborateur.Telephone = "+352 26 31 32 51";
            collaborateur.Ville = "Dudelange";

            collaborateur = service.Update(collaborateur);
        }

        public void DemonstrationSuppressionCollaborateur()
        {

        }

        #endregion
    }
}
