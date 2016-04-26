using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Gecomaes
{
    public class TarifServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public TarifServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des tarifs d'article d'un article par sa référence.
        /// </summary>
        public void GetTarifArticleList()
        {
            //Définition de la référence d'article
            string refArticle = "BRAAR10";

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération des tarif d'article liés à la référence d'article
            List<TarifArticle> tarifArticleList = service.GetListTarifArticle(refArticle);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des tarifs article répondant à un critère.
        /// </summary>
        public void GetTarifArticleListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("RefArticle", ComparisonOperator.Like, "%10%");

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération des tarifs d'article
            List<TarifArticle> tarifArticleList = service.GetListTarifArticles(criteria);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste triée de tarifs d'article.
        /// </summary>
        public void GetTarifArticleListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("PrixVente", OrderType.Desc) };

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la liste triée
            List<TarifArticle> tarifArticleList = service.GetListTarifArticles(orders: orders);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une page d'une liste de tarifs d'article.
        /// </summary>
        public void GetTarifArticleListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 6;

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la page de tarifs d'article
            List<TarifArticle> tarifArticleList = service.GetListTarifArticles(pageNumber: pageIndex, rowsPerPage: itemsPerPage);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de tarifs d'article en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetTarifArticleListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("RefArticle", ComparisonOperator.Like, "%10%");

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("PrixVente", OrderType.Desc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 6;

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la liste de tarifs d'article
            List<TarifArticle> tarifArticleList = service.GetListTarifArticles(criteria, orders, pageIndex, itemsPerPage);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des tarifs d'un client.
        /// </summary>
        public void GetTarifClientListByRefClient()
        {
            //Définition de la référence du client
            string refClient = "CARAT";

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la liste des tarifs client
            List<TarifClient> tarifClientList = service.GetListTarifClient(refClient);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des tarifs client.
        /// </summary>
        public void GetTarifClientList()
        {
            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la liste des tarifs client
            List<TarifClient> tarifClientList = service.GetListTarifClients();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des tarifs client répondant à un critère.
        /// </summary>
        public void GetTarifClientListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("TypePrix", ComparisonOperator.Equals, TypePrix.TTC);

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération des tarifs client répondants au critère
            List<TarifClient> tarifClientList = service.GetListTarifClients(criteria);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de tarifs client triée selon un propriété.
        /// </summary>
        public void GetTarifClientListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("PrixVente", OrderType.Asc) };

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la liste triée
            List<TarifClient> tarifClientList = service.GetListTarifClients(orders: orders);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une page de liste de tarifs client.
        /// </summary>
        public void GetTarifClientListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 2;
            int itemsPerPage = 2;

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la page de tarifs client
            List<TarifClient> tarifClientList = service.GetListTarifClients(pageNumber: pageIndex, rowsPerPage: itemsPerPage);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de tarifs client en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetTarifClientListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("TypePrix", ComparisonOperator.Equals, TypePrix.TTC);

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("PrixVente", OrderType.Asc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 2;
            int itemsPerPage = 2;

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la liste de tarifs client
            List<TarifClient> tarifClientList = service.GetListTarifClients(criteria, orders, pageIndex, itemsPerPage);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des tarifs fournisseur d'un article et d'un fournisseur.
        /// </summary>
        public void GetTarifFournisseurListByRefArticleAndRefFournisseur()
        {
            //Définition de la référence d'article et du numéro de fournisseur
            string refArticle = "BAOR01";
            string numFournisseur = "BILLO";

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la liste des tarifs fournisseur
            List<TarifFournisseur> tarifFournisseurList = service.GetListTarifFournisseurs(numFournisseur, refArticle);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des tarifs fournisseur.
        /// </summary>
        public void GetTarifFournisseurList()
        {
            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la liste des tarifs fournisseur
            List<TarifFournisseur> tarifFournisseurList = service.GetListTarifFournisseursCritere();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des tarifs fournisseur répondant à un critère.
        /// </summary>
        public void GetTarifFournisseurListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("PrixAchat", ComparisonOperator.GreaterThanOrEqualTo, 27M);

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la liste des tarifs fournisseur répondant au critère
            List<TarifFournisseur> tarifFournisseurList = service.GetListTarifFournisseursCritere(criteria);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des tarifs fournisseur triée selon une propriété.
        /// </summary>
        public void GetTarifFournisseurListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("IdFournisseur", OrderType.Asc) };

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la liste des tarifs fournisseur triée
            List<TarifFournisseur> tarifFournisseurList = service.GetListTarifFournisseursCritere(orders: orders);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une page de liste de tarifs fournisseur.
        /// </summary>
        public void GetTarifFournisseurListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la page de tarifs fournisseur
            List<TarifFournisseur> tarifFournisseurList = service.GetListTarifFournisseursCritere(pageNumber: pageIndex, rowsPerPage: itemsPerPage);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de tarifs fournisseur en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetTarifFournisseurListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("PrixAchat", ComparisonOperator.GreaterThanOrEqualTo, 27M);

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("IdFournisseur", OrderType.Asc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération de la page de tarifs fournisseur
            List<TarifFournisseur> tarifFournisseurList = service.GetListTarifFournisseursCritere(criteria, orders, pageIndex, itemsPerPage);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir le tarif article d'un article par sa référence et sa catégorie tarifaire.
        /// </summary>
        public void GetTarifArticleByRefArticle_IdCatTarifaire()
        {
            //Définition de la référence d'article et de la catégorie tarifaire
            string refArticle = "BRAAR10";
            short idCatTarifaire = 2;

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération du tarif article
            TarifArticle tarifArticle = service.GetTarifArticle(refArticle, idCatTarifaire);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir le tarif article d'un article à gamme par sa référence, ses identifiants de gamme et sa catégorie tarifaire.
        /// </summary>
        public void GetTarifArticleGammeByRefArticle_IdGamme_IdCatTarifaire()
        {
            //Définition de la référence article, ses identifiants de gamme et de la catégorie tarifaire
            string refArticle = "CHAAR/VAR";
            int idGamme1 = 6;
            int idGamme2 = 7;
            short idCatTarifaire = 2;

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération du tarif article
            TarifArticle tarifArticle = service.GetTarifArticleGamme(refArticle, idCatTarifaire, idGamme1, idGamme2);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir le tarif article d'un article à gamme par sa référence, ses intitulés de gamme et sa catégorie tarifaire.
        /// </summary>
        public void GetTarifArticleGammeByRefArticle_IntituleGamme_IdCatTarifaire()
        {
            //Définition de la référence article, ses intitulés de gamme et de la catégorie tarifaire
            string refArticle = "CHAAR/VAR";
            string intituleGamme1 = "42 cm";
            string intituleGamme2 = "Classique";
            short idCatTarifaire = 2;

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération du tarif article
            TarifArticle tarifArticle = service.GetTarifArticleGammeIntitule(refArticle, idCatTarifaire, intituleGamme1, intituleGamme2);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir le tarif client d'un article par sa référence et la référence du fournisseur.
        /// </summary>
        public void GetTarifClientByRefArticleAndRefFournisseur()
        {
            //Définition de la référence d'article et de la référence du tiers
            string refArticle = "BRAAR10";
            string numTiers = "CARAT";

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération du tarif client
            TarifClient tarifClient = service.GetTarifClient(refArticle, numTiers);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir le tarif client d'un article à gamme 
        /// par sa référence d'article, ses identifiants de gamme et sa référence client.
        /// </summary>
        public void GetTarifClientGammeIdGamme1()
        {
            //Définition de la référence d'article, de l'identifiant de gamme et du numéro de client
            string refArticle = "BAOR01";
            int idGamme1 = 3;
            string numTiers = "CISEL";

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération du tarif client
            TarifClient tarifClient = service.GetTarifClientGamme(refArticle, numTiers, idGamme1);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir le tarif client d'un article à gamme 
        /// par sa référence d'article, ses intitulés de gamme et sa référence client.
        /// </summary>
        public void GetTarifClientGammeIntituleGamme1()
        {
            //Définition de la référence d'article, de l'intitulé de gamme et du numéro de client
            string refArticle = "BAOR01";
            string numTiers = "CISEL";
            string intituleGamme1 = "Saphir";

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération du tarif client
            TarifClient tarifClient = service.GetTarifClientGammeIntitule(refArticle, numTiers, intituleGamme1);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir le tarif fournisseur d'un article
        ///  par sa référence d'article et sa référence de fournisseur.
        /// </summary>
        public void GetTarifFournisseurArticleStandard()
        {
            //Définition de la référence d'article et du numéro de fournisseur
            string refArticle = "BRAAR10";
            string numTiers = "BRELO";

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération du tarif fournisseur
            TarifFournisseur tarifFournisseur = service.GetTarifFournisseur(numTiers, refArticle);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir un tarif fournisseur d'article à gamme
        /// par sa référence article, ses identifiants de gamme et son identifiant de fournisseur.
        /// </summary>
        public void GetTarifFournisseur_ArticleGamme()
        {
            //Définition de la référence d'article à gamme, les identifiants de gamme et de la référence fournisseur
            string refArticle = "CHAAR/VAR";
            int idGamme1 = 6;
            int idGamme2 = 7;
            string refFournisseur = "BILLO";

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération du tarif fournisseur
            TarifFournisseur tarifFournisseur = service.GetTarifFournisseur(refFournisseur, refArticle, idGamme1, idGamme2);

        }

        /// <summary>
        /// Cette méthode montre comment insérer un tarif article, ou le mettre à jour s'il existe déjà, dans la base.
        /// </summary>
        public void TarifArticleInsertOrUpdate()
        {
            //Définition du tarif article
            TarifArticle tarifArticle = new TarifArticle()
            {
                Coefficient = 2,
                IdGamme1 = 6,
                IdGamme2 = 7,
                IdCategorieTarifaire = 3,
                PrixVente = 123.45M,
                RefArticle = "CHAAR/VAR",
                TypePrix = TypePrix.TTC
            };

            TarifService service = new TarifService(_webServiceUrl);

            //Insertion, ou mise à jour si existe, du tarif article
            service.InsertOrUpdateTarifArticle(tarifArticle);

        }

        /// <summary>
        /// Cette méthode montre comment insérer un tarif client, ou le mettre à jour s'il existe déjà, dans la base.
        /// </summary>
        public void TarifClientInsertOrUpdate()
        {
            //Définition du tarif client
            TarifClient tarifClient = new TarifClient()
            {
                Coefficient = 2,
                IdGamme1 = 6,
                IdGamme2 = 7,
                PrixVente = 123.45M,
                RefArticle = "CHAAR/VAR",
                TypePrix = TypePrix.TTC,
                NumeroTiers = "CARAT",
                Remise = 3,
                RefArticleClient = "TEST"
            };

            TarifService service = new TarifService(_webServiceUrl);

            //Insertion, ou mise à jour si existe, du tarif client
            service.InsertOrUpdateTarifClient(tarifClient);

        }

        /// <summary>
        /// Cette méthode montre comment supprimer un tarif client d'article à gamme de la base.
        /// </summary>
        public void TarifClientGammeDelete()
        {
            //Définition de la référence article, des identifiants de gamme et de la référence client
            string refArticle = "CHAAR/VAR";
            int idGamme1 = 6;
            int idGamme2 = 7;
            string numeroTiers = "CARAT";

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération du tarif client
            TarifClient tarifClient = service.GetTarifClientGamme(refArticle, numeroTiers, idGamme1, idGamme2);

            //Suppression du tarif client de la base
            service.DeleteTarifClient(tarifClient);

        }

        /// <summary>
        /// Cette méthode montre comment supprimer un tarif client de la base.
        /// </summary>
        public void TarifClientDelete()
        {
            //Définition de la référence article et de la référence client
            string refArticle = "BRAAR10";
            string numeroTiers = "CARAT";

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération du tarif client
            TarifClient tarifClient = service.GetTarifClient(refArticle, numeroTiers);

            //Suppression du tarif client de la base
            service.DeleteTarifClient(tarifClient);

        }

        /// <summary>
        /// Cette méthode montre comment supprimer un tarif article de la base.
        /// </summary>
        public void TarifArticleDelete()
        {
            //Définition de la référence d'article, de ses identifiants de gamme et de la catégorie tarifaire
            string refArticle = "CHAAR/VAR";
            int idGamme1 = 6;
            int idGamme2 = 7;
            short idCatTarif = 3;

            TarifService service = new TarifService(_webServiceUrl);

            //Récupération du tarif article
            TarifArticle tarifArticle = service.GetTarifArticleGamme(refArticle, idCatTarif, idGamme1, idGamme2);

            //Suppression du tarif article
            service.DeleteTarifArticle(tarifArticle);

        }

        #endregion
    }
}
