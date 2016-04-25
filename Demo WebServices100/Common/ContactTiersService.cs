using System;
using System.Linq;
using System.Collections.Generic;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;

namespace DemoWebServices100.Common
{
    public class ContactTiersServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public ContactTiersServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des contacts de tiers
        /// </summary>
        public void GetContactTiersList()
        {
            ContactTiersService service = new ContactTiersService(_webServiceUrl);

            //Récupération de la liste des contacts de tiers
            IList<ContactTiers> contact = service.GetList();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des contacts d'un tiers
        /// </summary>
        public void GetContactTiersListByIdTiers()
        {
            //Définition du tiers
            string numTiers = "BAGUES";

            ContactTiersService service = new ContactTiersService(_webServiceUrl);

            //Récupération de la liste des contacts du tiers
            IList<ContactTiers> contact = service.GetListByTiers(numTiers);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des contacts de tiers répondant à un critère
        /// </summary>
        public void GetContactTiersListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Fonction", ComparisonOperator.Like, "Gérant");

            ContactTiersService service = new ContactTiersService(_webServiceUrl);

            //Récupération de la liste de contacts de tiers répondant au critère
            IList<ContactTiers> contact = service.GetList(criteria);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de la liste des contacts de tiers
        /// </summary>
        public void GetContactTiersListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 1;
            int itemsPerPage = 10;

            ContactTiersService service = new ContactTiersService(_webServiceUrl);

            //Récupération de la page de la liste des contacts de tiers
            IList<ContactTiers> contact = service.GetList(pageNumber: pageIndex, rowsPerPage: itemsPerPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste triée de contacts de tiers
        /// </summary>
        public void GetContactTiersListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroTiers", OrderType.Asc) };

            ContactTiersService service = new ContactTiersService(_webServiceUrl);

            //Récupération de la liste triée de contacts de tiers
            IList<ContactTiers> contactAsc = service.GetList(orders: orders);
        }

        /// <summary>
        /// Méthode démontrant comment obtenir le nombre de contacts de tiers
        /// </summary>
        public void GetContactTiersListCount()
        {

            ContactTiersService service = new ContactTiersService(_webServiceUrl);

            //Récupération du nombre de contacts de tiers
            int nb = service.GetCount();

        }


        /// <summary>
        /// Méthode démontrant comment obtenir le nombre de contacts de tiers répondant à un critère
        /// </summary>
        public void GetContactTiersListCountByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Fonction", ComparisonOperator.Like, "Gérant");

            ContactTiersService service = new ContactTiersService(_webServiceUrl);

            //Récupération du nombre de contacts de tiers répondant au critère
            int nb = service.GetCount(criteria);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir un contact de tiers
        /// </summary>
        public void GetContactTiers_Exist_Data_Ok()
        {
            //Définition du tiers et de l'identifiant du contact
            string numTiers = "BAGUES";
            int indexContact = 1;

            ContactTiersService service = new ContactTiersService(_webServiceUrl);

            //Récupération du contact de tiers
            ContactTiers contact = service.GetContactTiers(numTiers, indexContact);

        }

        /// <summary>
        /// Méthode démontrant comment insérer un contact de tiers dans la base
        /// </summary>
        public void InsertContactTiers()
        {
            //Définition du contact de tiers
            ContactTiers contact = CreateContactTiers();
            contact.Nom = contact.Nom + new Random().Next().ToString();

            ContactTiersService service = new ContactTiersService(_webServiceUrl);

            //Insertion du contact de tiers dans la base
            contact = service.Insert(contact);

        }

        /// <summary>
        /// Méthode démontrant comment mettre à jour un contact de tiers dans la base
        /// </summary>
        public void UpdateContactTiers()
        {
            //Définition du numéro de tiers et de l'index de son contact
            string numTiers = "BAGUES";
            int indexContact = 1;

            ContactTiersService service = new ContactTiersService(_webServiceUrl);

            //Récupération du contact de tiers depuis la base
            ContactTiers contact = service.GetContactTiers(numTiers, indexContact);

            //Modification du contact de tiers
            contact.Nom = "Di Muzio111";
            contact.Prenom = "Valerian111";
            contact.Fonction = "Gérant";
            contact.Civilite = Civilite.M;
            contact.Gsm = "+352 691 573 370";
            contact.Fax = "+352 26 31 32 51";
            contact.Telephone = "+352 26 31 32 51";
            contact.Email = "info@proconsult.lu";

            //Mise à jour du contact de tiers dans la base
            service.Update(contact);

        }


        /// <summary>
        /// Méthode démontrant comment supprimer un contact de tiers dans la base
        /// </summary>
        public void DeleteContactTiers()
        {
            //Définition du numéro de tiers et de l'index de contact
            string numTiers = "BAGUES";
            int indexContact = 1;

            ContactTiersService service = new ContactTiersService(_webServiceUrl);

            //Suppression du contact de tiers de la base
            service.Delete(numTiers, indexContact);
        }

        #endregion

        #region Privée

        /// <summary>
        /// Méthode de construction d'un nouveau tiers
        /// </summary>
        /// <returns></returns>
        private static ContactTiers CreateContactTiers()
        {
            ContactTiers contact = new ContactTiers();
            contact.Id = 0;
            contact.NumeroTiers = "BAGUES";
            contact.Nom = "Di Muzio" + new Random().Next().ToString();
            contact.Prenom = "Valerian";
            contact.Fonction = "Gérant";
            contact.Civilite = Civilite.M;
            contact.Fax = "+352 26 31 32 51";
            contact.Telephone = "+352 26 31 32 51";
            contact.Gsm = "+352 691 573 370";
            contact.Email = "info@proconsult.lu";

            return contact;
        }

        #endregion
    }
}
