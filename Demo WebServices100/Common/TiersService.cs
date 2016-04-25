using System;
using System.Linq;
using System.Collections.Generic;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;
using System.Threading.Tasks;

namespace DemoWebServices100.Common
{
    public class TiersServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public TiersServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des tiers.
        /// </summary>
        public void GetTiersList()
        {
            TiersService service = new TiersService(_webServiceUrl);

            //Récupération de la liste des tiers
            IList<Tiers> tiers = service.GetList();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des tiers répondant à un critère.
        /// </summary>
        public void GetTiersListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("TypeTiers", ComparisonOperator.Equals, TypeTiers.Client);

            TiersService service = new TiersService(_webServiceUrl);

            //Récupération de la liste des tiers répondant au critère
            IList<Tiers> tiers = service.GetList(criteria);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de la liste des tiers.
        /// </summary>
        public void GetTiersListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 1;
            int rowsPerPage = 10;

            TiersService service = new TiersService(_webServiceUrl);

            //Récupération de la page de la liste de tiers
            IList<Tiers> tiers = service.GetList(pageNumber: pageIndex, rowsPerPage: rowsPerPage);
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste triée de tiers.
        /// </summary>
        public void GetTiersListeOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroTiers", OrderType.Asc) };

            TiersService service = new TiersService(_webServiceUrl);

            //Récupération de la liste triée
            IList<Tiers> tiersAsc = service.GetList(orders: orders);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir le nombre de tiers
        /// </summary>
        public void GetTiersListCount()
        {
            TiersService service = new TiersService(_webServiceUrl);
            
            //Récupération du nombre de tiers
            int nb = service.GetCount();
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir un tiers par son identifiant.
        /// </summary>
        public void GetTiersByID()
        {
            //Définition de l'identifiant du tiers
            string refTiers = "BAGUES";

            TiersService service = new TiersService(_webServiceUrl);

            //Récupération du tiers
            Tiers tiers = service.GetTiers(refTiers);
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des clients.
        /// </summary>
        public void GetTiersClientList()
        {
            TiersService service = new TiersService(_webServiceUrl);

            //Récupération de la liste des clients
            IList<Client> tiers = service.GetListClient();
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des fournisseurs.
        /// </summary>
        public void GetTiersFournisseurList()
        {
            TiersService service = new TiersService(_webServiceUrl);

            //Récupération de la liste des fournisseurs
            IList<Fournisseur> tiers = service.GetListFournisseur();
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des salariés.
        /// </summary>
        public void GetTiersSalarieList()
        {
            TiersService service = new TiersService(_webServiceUrl);

            //Récupération de la liste des salariés
            IList<Salarie> tiers = service.GetListSalarie();
            
        }

        /// <summary>
        /// Méthode démontrant comment insérer un client dans la base.
        /// </summary>
        public void InsertClient()
        {
            //Définition du client
            Client client = CreateNewClient();

            TiersService service = new TiersService(_webServiceUrl);

            //Insertion du tiers
            Tiers tiersFromDb = service.Insert(client);

        }

        /// <summary>
        /// Méthode démontrant comment insérer un fournisseur dans la base.
        /// </summary>
        public void InsertFournisseur()
        {
            //Définition du fournisseur
            Fournisseur fournisseur = CreateNewFournisseur();

            TiersService service = new TiersService(_webServiceUrl);
            
            //Insertion du tiers
            Tiers tiersFromDb = service.Insert(fournisseur);

        }

        /// <summary>
        /// Méthode démontrant comment insérer un salarié dans la base.
        /// </summary>
        public void InsertSalarie()
        {
            //Définition du salarié
            Salarie salarie = CreateNewSalarie();

            TiersService service = new TiersService(_webServiceUrl);

            //Insertion du salarié
            Tiers tiersFromDb = service.Insert(salarie);

        }

        /// <summary>
        /// Méthode démontrant comment mettre à jour un tiers.
        /// </summary>
        public void UpdateTiers()
        {
            //Définition de l'identifiant du tiers
            string numTiers = "BAGUES";

            TiersService service = new TiersService(_webServiceUrl);

            //Récupération du tiers
            Tiers tiers = service.GetTiers(numTiers);

            //TODO voir les modifications
            //Modification du tiers
            tiers.Intitule = "toto";
            tiers.Adresse = "toto";
            tiers.CodeEdi = "toto";
            tiers.CodePostal = "toto";
            tiers.Commentaire = "toto";
            tiers.Complement = "toto";
            tiers.Contact = "toto";
            tiers.Email = "toto";
            tiers.Fax = "toto";
            tiers.NumeroTva = "toto";
            tiers.Pays = "toto";
            tiers.Qualite = "toto";
            tiers.Region = "toto";
            tiers.NumeroSiret = "toto";
            tiers.SiteWeb = "toto";
            tiers.Telephone = "toto";
            tiers.Ville = "toto";
            tiers.IdModeExpedition = 2;
            tiers.IdConditionLivraison = 2;
            tiers.IdCategorieTarifaire = 2;
            tiers.IdCategorieComptable = 2;

            //Mise à jour du tiers
            Tiers tiersFromDb = service.Update(tiers);

        }

        #endregion

        #region Privées

        /// <summary>
        /// Méthode de construction d'un nouveau client
        /// </summary>
        /// <returns></returns>
        private static Client CreateNewClient()
        {
            Client client = new Client();
            client.NumeroTiers = "C" + Guid.NewGuid().ToString("N").Substring(0, 15).ToUpper();
            client.Intitule = "Toto test";
            client.Adresse = "Rue de la liberation 17";
            client.CodeEdi = "CodeEDI";
            client.CodePostal = "3510";
            client.Commentaire = "Commentaire";
            client.Complement = "boite 3";
            client.Contact = "Di Muzio Valerian";
            client.Email = "info@proconsult.lu";
            client.Fax = "+352 26 31 32 51";
            client.NumeroTva = "FR7332047770600016";
            client.Pays = "Luxembourg";
            client.Qualite = "Société";
            client.Region = "Luxembourg";
            client.NumeroSiret = "";
            client.SiteWeb = "http://www.proconsult.lu/";
            client.Telephone = "+352 26 31 32 51";
            client.Ville = "Dudelange";

            return client;
        }

        /// <summary>
        /// Méthode de construction d'un nouveau fournisseur
        /// </summary>
        /// <returns></returns>
        private static Fournisseur CreateNewFournisseur()
        {
            Fournisseur fournisseur = new Fournisseur();
            fournisseur.NumeroTiers = "F" + Guid.NewGuid().ToString("N").Substring(0, 15).ToUpper();
            fournisseur.Intitule = "Toto test";
            fournisseur.Adresse = "Rue de la liberation 17";
            fournisseur.CodeEdi = "CodeEDI";
            fournisseur.CodePostal = "3510";
            fournisseur.Commentaire = "Commentaire commentaire";
            fournisseur.Complement = "boite 3";
            fournisseur.Contact = "Di Muzio Valerian";
            fournisseur.Email = "info@proconsult.lu";
            fournisseur.Fax = "+352 26 31 32 51";
            fournisseur.NumeroTva = "FR7332047770600016";
            fournisseur.Pays = "Luxembourg";
            fournisseur.Qualite = "Société";
            fournisseur.Region = "Luxembourg";
            fournisseur.NumeroSiret = "";
            fournisseur.SiteWeb = "http://www.proconsult.lu/";
            fournisseur.Telephone = "+352 26 31 32 51";
            fournisseur.Ville = "Dudelange";

            return fournisseur;
        }

        /// <summary>
        /// Méthode de construction d'un nouveau salarié
        /// </summary>
        /// <returns></returns>
        private static Salarie CreateNewSalarie()
        {
            Salarie salarie = new Salarie();
            salarie.NumeroTiers = "E" + Guid.NewGuid().ToString("N").Substring(0, 15).ToUpper();
            salarie.Intitule = "Toto test";
            salarie.Adresse = "Rue de la liberation 17";
            salarie.CodeEdi = "CodeEDI";
            salarie.CodePostal = "3510";
            salarie.Commentaire = "Commentaire commentaire";
            salarie.Complement = "boite 3";
            salarie.Contact = "Di Muzio Valerian";
            salarie.Email = "info@proconsult.lu";
            salarie.Fax = "+352 26 31 32 51";
            salarie.NumeroTva = "FR7332047770600016";
            salarie.Pays = "Luxembourg";
            salarie.Qualite = "Société";
            salarie.Region = "Luxembourg";
            salarie.NumeroSiret = "";
            salarie.SiteWeb = "http://www.proconsult.lu/";
            salarie.Telephone = "+352 26 31 32 51";
            salarie.Ville = "Dudelange";
            salarie.CompteCollectif = "421PARI";

            return salarie;
        }

        #endregion

    }
}
