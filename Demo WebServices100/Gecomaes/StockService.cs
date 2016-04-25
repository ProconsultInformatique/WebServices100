using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Gecomaes
{
    public class StockServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public StockServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Dépot

        /// <summary>
        /// Méthode démontrant comment obtenir un dépot par son identifiant
        /// </summary>
        public void GetDepotById()
        {
            //Definition de l'identifiant du dépot
            int idDepot = 1;

            StockService service = new StockService(_webServiceUrl);

            //Récupération du dépot
            Depot depot = service.GetDepot(idDepot);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des dépots
        /// </summary>
        public void GetDepotList()
        {
            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des dépots
            List<Depot> depotList = service.GetListDepot();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste de dépot répondant à un critère
        /// </summary>
        public void GetDepotListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Id", ComparisonOperator.Equals, 1);

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des dépots répondant au critère
            List<Depot> depotList = service.GetListDepot(criteria);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste de dépot triée selon un propriété
        /// </summary>
        public void GetDepotListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orderList = new List<Order>() { new Order("Id", OrderType.Desc) };

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste de dépot triée
            List<Depot> depotList = service.GetListDepot(orders: orderList);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de liste de dépot
        /// </summary>
        public void GetDepotListPaged()
        {

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 2;
            int itemsPerPage = 1;

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la page de la liste des dépots
            List<Depot> depotList = service.GetListDepot(pageNumber: pageIndex, rowsPerPage: itemsPerPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste de dépots en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetDepotListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Email", ComparisonOperator.Like, "%fr");

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("Id", OrderType.Desc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 2;
            int itemsPerPage = 1;

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la page de la liste des dépots
            List<Depot> depotList = service.GetListDepot(criteria, orders, pageIndex, itemsPerPage);

        }

        #endregion

        #region Emplacement

        /// <summary>
        /// Méthode démontrant comment obtenir l'emplacement d'un dépot
        /// </summary>
        public void GetEmplacementDepot()
        {
            //Définition des identifiants du dépot et de l'emplacement
            int idDepot = 1;
            int idEmplacement = 69;

            StockService service = new StockService(_webServiceUrl);

            //Récupération de l'emplacement
            Emplacement emplacement = service.GetEmplacement(idDepot, idEmplacement);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir l'emplacement par défaut d'un article standard sur un dépot
        /// </summary>
        public void GetEmplacementDefautArticleStandard_Execute_Ok()
        {
            //Définition de la référence d'article et du dépot
            string refArticle = "BRAAR10";
            int idDepot = 1;

            StockService service = new StockService(_webServiceUrl);

            //Récupération de l'emplacement par défaut de l'article sur le dépot
            Emplacement emplacement = service.GetEmplacementParDefaut(refArticle, idDepot);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir l'emplacement par défaut d'un article à gamme sur un dépot
        /// </summary>
        public void GetEmplacementDefautArticleGamme_Execute_Ok()
        {
            //Définition de la référence d'article, de ses gammes et du dépot
            string refArticle = "CHAAR/VAR";
            int idGamme1 = 6;
            int idGamme2 = 7;
            int idDepot = 1;

            StockService service = new StockService(_webServiceUrl);

            //Récupération de l'emplacement par défaut de l'article à gamme sur le dépot
            Emplacement emplacement = service.GetEmplacementParDefaut(refArticle, idDepot, idGamme1, idGamme2);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des emplacements
        /// </summary>
        public void GetEmplacementList()
        {
            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des emplacements
            List<Emplacement> emplacementList = service.GetListEmplacement();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des emplacements répondant à un critère
        /// </summary>
        public void GetEmplacementListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("IdDepot", ComparisonOperator.Equals, 1);

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des emplacements répondant au critère
            List<Emplacement> emplacementList = service.GetListEmplacement(criteria);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste triée selon une propriété des emplacements
        /// </summary>
        public void GetEmplacementListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("IdDepot", OrderType.Asc), new Order("Id", OrderType.Asc) };

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des emplacements triée
            List<Emplacement> emplacementList = service.GetListEmplacement(orders: orders);
        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de la liste des emplacements
        /// </summary>
        public void GetEmplacementListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 2;
            int itemsPerPage = 3;

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la page de la liste des emplacements
            List<Emplacement> emplacementList = service.GetListEmplacement(pageNumber: pageIndex, rowsPerPage: itemsPerPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste d'emplacements en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetEmplacementListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("IdDepot", ComparisonOperator.Equals, 1);

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("IdDepot", OrderType.Asc), new Order("Id", OrderType.Asc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 2;
            int itemsPerPage = 3;

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la page de la liste des emplacements
            List<Emplacement> emplacementList = service.GetListEmplacement(criteria, orders, pageIndex, itemsPerPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des emplacements d'un dépot
        /// </summary>
        public void GetEmplacementListByDepot()
        {
            //Définition de l'identifiant du dépot
            int idDepot = 1;

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des emplacements du dépot
            List<Emplacement> emplacementList = service.GetListEmplacementByDepot(idDepot);

        }

        #endregion

        #region LotSerie

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des lot/série
        /// </summary>
        public void GetLotSerieList()
        {
            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des lot/série
            List<LotSerie> lotSerieList = service.GetListLotSerie();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des lot/série répondant à un critère
        /// </summary>
        public void GetLotSerieListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("EstEpuise", ComparisonOperator.Equals, false);

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des lot/série répondant au critère
            List<LotSerie> lotSerieList = service.GetListLotSerie(criteria);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste triée suivant une propriété des lot/série
        /// </summary>
        public void GetLotSerieListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumLotSerie", OrderType.Desc) };

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des lot/série triée
            List<LotSerie> lotSerieList = service.GetListLotSerie(orders: orders);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de la liste des lot/série
        /// </summary>
        public void GetLotSerieListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la page de la liste des lot/série
            List<LotSerie> lotSerieList = service.GetListLotSerie(pageNumber: pageIndex, rowsPerPage: itemsPerPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une la liste des lot/série en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetLotSerieListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("EstEpuise", ComparisonOperator.Equals, false);

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumLotSerie", OrderType.Desc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la page de la liste des lot/série
            List<LotSerie> lotSerieList = service.GetListLotSerie(criteria, orders, pageIndex, itemsPerPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des lot/série d'une référence d'article
        /// </summary>
        public void GetLotSerieListByRefArticle()
        {
            //Définition de la référence d'article
            string refArticle = "LINGOR18";

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des lot/série de l'article
            List<LotSerie> lotSerieList = service.GetListLotSerieByRefArticle(refArticle);

        }

        #endregion

        #region StockDepot

        /// <summary>
        /// Méthode démontrant comment obtenir le stock de dépot d'un article
        /// </summary>
        public void GetStockDepotByRefArticleIdDepot()
        {
            //Définition de la référence d'article et du dépot
            string refArticle = "BRAAR10";
            int idDepot = 2;

            StockService service = new StockService(_webServiceUrl);

            //Récupération du stock de dépot
            StockDepot stockDepot = service.GetStockByRefArticle(refArticle, idDepot);
        }

        public void GetStockDepotByRefArticleIdDepotIdGamme1IdGamme2()
        {
            //Définition de la référence d'article, de ses gammes et du dépot
            string refArticle = "CHAAR/VAR";
            int idGamme1 = 6;
            int idGamme2 = 7;
            int idDepot = 2;

            StockService service = new StockService(_webServiceUrl);

            //Récupération du stock de dépot
            StockDepot stockDepot = service.GetStockByRefArticleGamme(refArticle, idDepot, idGamme1, idGamme2);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des stocks d'article par dépot
        /// </summary>
        public void GetStockDepotList()
        {
            StockService service = new StockService(_webServiceUrl);

            //Récupération des stocks de dépot
            List<StockDepot> stockDepotList = service.GetListStock();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des stocks d'article par dépot répondant à un critère
        /// </summary>
        public void GetStockDepotListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("QteStock", ComparisonOperator.GreaterThan, 10);

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des stocks d'article par dépot
            List<StockDepot> stockDepotList = service.GetListStock(criteria);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des stocks d'article par dépot triée selon une propriété
        /// </summary>
        public void GetStockDepotListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("QteStock", OrderType.Asc) };

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des stock d'article par dépot
            List<StockDepot> stockDepotList = service.GetListStock(orders: orders);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de la liste des stocks d'article par dépot
        /// </summary>
        public void GetStockDepotListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 5;
            int itemByPage = 6;

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la page de la liste des stocks d'article par dépot
            List<StockDepot> stockDepotList = service.GetListStock(pageNumber: pageIndex, rowsPerPage: itemByPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste des stocks d'article par dépot en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetStockDepotListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("QteStock", ComparisonOperator.GreaterThan, 10);

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("QteStock", OrderType.Asc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 5;
            int itemsPerPage = 6;


            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des stocks d'article par dépot
            List<StockDepot> stockDepotList = service.GetListStock(criteria, orders, pageIndex, itemsPerPage);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des stocks de dépot des articles à gamme
        /// </summary>
        public void GetStockDepotListGamme()
        {
            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des stocks dépot des articles à gamme
            List<StockDepot> stockDepotList = service.GetListStockGamme();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des stocks de dépot d'article à gamme répondant à un critère
        /// </summary>
        public void GeStockDepotArticleGammeListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("QteMini", ComparisonOperator.LessThan, 15);

            StockService service = new StockService(_webServiceUrl);

            //Récupération des stocks de dépot des articles à gamme répondant au critère
            List<StockDepot> stockDepotList = service.GetListStockGamme(criteria);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une liste triée selon une propriété de stock de dépot d'article à gamme
        /// </summary>
        public void GeStockDepotArticleGammeListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("QteStock", OrderType.Asc) };

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste triée des stock de dépot d'article à gamme
            List<StockDepot> stockDepotList = service.GetListStockGamme(orders: orders);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une page de la liste des stocks de dépot d'article à gamme
        /// </summary>
        public void GeStockDepotArticleGammeListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 5;
            int itemsPerPage = 4;

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la page de la liste des stock de dépot d'article à gamme
            List<StockDepot> stockDepotList = service.GetListStockGamme(rowsPerPage: itemsPerPage, pageNumber: pageIndex);

        }

        #endregion

        #region StockEmplacement

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des stocks d'emplacement d'un article standard sur un dépot
        /// </summary>
        public void GetStockEmplacementListArticleStandard()
        {
            //Définition de la référence d'article et du dépot
            string refArticle = "BRAAR10";
            int idDepot = 1;

            StockService service = new StockService(_webServiceUrl);

            //Récupération des stocks d'emplacement de l'article standard sur le dépot
            List<StockEmplacement> stockEmplacementList = service.GetListStockEmplacement(refArticle, idDepot);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des stocks d'emplacement d'article à gamme sur un dépot
        /// </summary>
        public void GetStockEmplacementListArticleGamme()
        {
            //Définition de la référence d'article, de ses gammes et du dépot
            string refArticle = "CHAAR/VAR";
            int idGamme1 = 6;
            int idGamme2 = 7;
            int idDepot = 1;

            StockService service = new StockService(_webServiceUrl);

            //Récupération de la liste des stocks d'emplacement de l'article à gamme sur le dépot
            List<StockEmplacement> stockEmplacementList = service.GetListStockEmplacement(refArticle, idDepot, idGamme1, idGamme2);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir le stock d'emplacement d'un article standard
        /// </summary>
        public void GetStockEmplacementByRefArticleStandardIdDepotIdEmplacement()
        {
            //Définition du dépot, de l'emplacement et de la référence d'article
            string refArticle = "BRAAR10";
            int idDepot = 1;
            int idEmplacement = 17;

            StockService service = new StockService(_webServiceUrl);

            //Récupération du stock d'emplacement
            StockEmplacement stockEmplacement = service.GetStockEmplacement(refArticle, idDepot, idEmplacement);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir le stock d'emplacement d'un article à gamme
        /// </summary>
        public void GetStockEmplacementByRefArticleGammeIdDepotIdEmplacementIdGamme1IdGamme2()
        {
            //Définition de la référence d'article et de ses gammes
            string refArticle = "CHAAR/VAR";
            int idGamme1 = 6;
            int idGamme2 = 7;

            //Définition du dépot et de l'emplacement
            int idDepot = 1;
            int idEmplacement = 19;

            StockService service = new StockService(_webServiceUrl);

            //Récupération du stock d'emplacement
            StockEmplacement stockEmplacement = service.GetStockEmplacement(refArticle, idDepot, idEmplacement, idGamme1, idGamme2);

        }

        #endregion

    }
}
