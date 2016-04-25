using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Gecomaes
{
    public class ArticleServiceDemo
    {
        #region Données membres

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public ArticleServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes Articles

        /// <summary>
        /// Méthode démontrant comment obtenir la liste de tous les articles
        /// </summary>
        public void GetAllArticleList()
        {
            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de la liste d'articles
            IList<Article> articleList = service.GetList();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste d'article selon un critère
        /// </summary>
        public void GetAllArticleListByCriteria()
        {
            //Création du critère
            string codeFamille = "BIJOUXOR";
            Criteria criteria = new CriteriaComparison("CodeFamille", ComparisonOperator.Equals, codeFamille);

            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de la liste d'articles
            IList<Article> articleList = service.GetList(criteria);
        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste d'article triée
        /// </summary>
        public void GetAllArticleOrderByReference()
        {
            //Creation du tri
            List<Order> methodeTri = new List<Order>() { new Order { FieldName = "Reference", OrderType = OrderType.Desc } };

            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de la liste d'articles triée
            IList<Article> articleList = service.GetList(orders: methodeTri);
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de liste d'article
        /// </summary>
        public void GetPageListArticle()
        {
            //Définition de la page et du nombre d'article par page
            int itemByPage = 10;
            int pageNumber = 2;

            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de la page de liste d'article
            IList<Article> articleList = service.GetList(pageNumber: pageNumber, rowsPerPage: itemByPage);
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir un article
        /// </summary>
        public void GetArticleByReference()
        {
            //Définition de la référence d'article recherchée
            string refArticle = "CHAOR42";

            ArticleService service = new ArticleService(_webServiceUrl);
            
            //Récupération de l'article
            Article article = service.GetArticle(refArticle);
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir le nombre d'articles répondant à un critère
        /// </summary>
        public void GetCountArticleByCriteria()
        {

            //Définition du critère
            string codeFamille = "BIJOUXOR";
            Criteria criteria = new CriteriaComparison("CodeFamille", ComparisonOperator.Equals, codeFamille);

            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération du nombre d'article répondant au critère
            int count = service.GetCount(criteria);
            
        }

        /// <summary>
        /// Méthode démontrant comment ajouter un article dans la base
        /// </summary>
        public void InsertArticle()
        {
            //Définition des propriétés minimales d'un article standard
            Article article = new ArticleStandard();
            article.Reference = "TEST1";
            article.Intitule = "new article test";
            article.CodeFamille = "BIJOUXOR";

            ArticleService service = new ArticleService(_webServiceUrl);

            //Insertion de l'article
            service.Insert(article);

        }

        /// <summary>
        /// Méthode démontrant comment mettre à jour un article
        /// </summary>
        public void UpdateArticle()
        {
            //Définition de la référence d'article
            string refArticle = "CHAOR42";

            ArticleService service = new ArticleService(_webServiceUrl);
            
            //Récupération de l'article depuis la base
            Article article = service.GetArticle(refArticle);

            //Modification de l'article
            article.Intitule = article.Intitule += "TestUpDate";

            //Mise à jour de l'article dans la base
            service.Update(article);

        }

        /// <summary>
        /// Méthode démontrant comment supprimer un article
        /// </summary>
        public void DeleteArticle()
        {
            //Définition de la référence d'article
            string refArticle = "CHAOR42";

            ArticleService service = new ArticleService(_webServiceUrl);

            //Suppression de l'article dans la base
            service.Delete(refArticle);

        }

        #endregion

        #region Unité de vente

        /// <summary>
        /// Méthode démontrant comment récupérer une unité de vente par son identifiant
        /// </summary>
        public void GetUniteVenteById()
        {
            //Définition de l'identifiant de l'unité de vente
            int idUniteVente = 4;

            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de l'unité de vente
            UniteVente uniteVente = service.GetUniteVenteById(idUniteVente);

        }

        /// <summary>
        /// Méthode démontrant comment récupérer une unité de vente par son nom
        /// </summary>
        public void GetUniteVenteByName()
        {
            //Définition du nom de l'unité de vente
            string nomUnitevente = "Douzaine";

            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de l'unité de vente
            UniteVente uniteVente = service.GetUniteVenteByName(nomUnitevente);

        }

        /// <summary>
        /// Méthode démontrant comment récupérer la liste des unités de vente
        /// </summary>
        public void GetUniteVenteList()
        {
            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de la liste des unités de vente
            List<UniteVente> uniteVenteList = service.GetUniteVenteList();

        }

        #endregion

        #region Article fournisseur

        /// <summary>
        /// Méthode démontrant comment obtenir les données d'article fournisseur
        /// </summary>
        public void GetArticleFournisseur()
        {
            //Définition des paramètres
            string refArticle = "CHAOR42";
            string numFournisseur = "ECLAT";

            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de l'article fournisseur
            ArticleFournisseur articleFournisseur = service.GetArticleFournisseur(refArticle, numFournisseur);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste d'article fournisseur selon un critère
        /// </summary>
        public void GetArticleFournisseurListByCriteria()
        {
            //Définition du critère
            string refArticle = "CHAOR42";
            Criteria criteria = new CriteriaComparison("IdArticle", ComparisonOperator.Equals, refArticle);

            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de la liste d'article fournisseur filtrée
            List<ArticleFournisseur> articleFournisseurList = service.GetArticleFournisseurList(criteria);

        }

        #endregion

        #region Statistiques

        /// <summary>
        /// Méthode démontrant comment récupérer une statistique d'article
        /// </summary>
        public void GetStatistiqueArticle()
        {
            //Définition de l'identifiant de la statistique
            short idChamp = 2;

            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de la statistique
            StatistiqueArticle statistiqueArticle = service.GetStatistiqueArticleListByIdChamp(idChamp);

        }

        /// <summary>
        /// Méthode démontrant comment récupérer la liste des statistiques d'article
        /// </summary>
        public void GetStatistiqueList()
        {
            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de la liste des statistiques d'article
            List<StatistiqueArticle> statistiqueArticleList = service.GetStatistiqueList();

        }

        #endregion

        #region Catalogue

        /// <summary>
        /// Méthode démontrant comment obtenir un catalogue par son identifiant
        /// </summary>
        public void GetCatalogueById()
        {
            //Définition de l'identifiant du catalogue
            int idCatalogue = 2;

            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération du catalogue
            Catalogue catalogue = service.GetCatalogue(idCatalogue);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir les catalogues
        /// </summary>
        public void GetCatalogueList()
        {
            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de la liste de catalogue
            List<Catalogue> catalogueList = service.GetCatalogueList();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des catalogues enfants d'un catalogue
        /// </summary>
        public void GetCatalogueListByParentId()
        {
            //Définition de l'identifiant du catalogue parent
            int idCatalogueParent = 6;

            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de la liste des catalogues enfants
            List<Catalogue> catalogueList = service.GetCataloguesByParent(idCatalogueParent);

        }

        #endregion

        #region Nomenclature

        /// <summary>
        /// Méthode démontrant comment récupérer la nomenclature d'un article
        /// </summary>
        public void GetNomenclature()
        {
            //Définition de la référence d'article à nomenclature
            string refArticle = "CHORFA";

            ArticleService service = new ArticleService(_webServiceUrl);

            //Récupération de la liste de NomenclatureArticle liée à la référence d'article
            IList<NomenclatureArticle> nomenclature = service.GetNomenclature(refArticle);

        }

        #endregion 
    }
}
