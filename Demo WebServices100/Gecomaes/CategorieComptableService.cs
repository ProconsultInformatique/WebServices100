using System;
using System.Collections.Generic;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;

namespace DemoWebServices100.Gecomaes
{
    public class CategorieComptableServiceDemo
    {

        #region Données membres

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public CategorieComptableServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Achat

        /// <summary>
        /// Méthode démontrant comment obtenir la liste catégorie comptable d'achat
        /// </summary>
        public void GetCategorieComptableAchatList()
        {
            CategorieComptableService service = new CategorieComptableService(_webServiceUrl);

            //Récupération de la liste des catégories comptable
            IList<CategorieComptable> catCompta = service.GetListAchat();
        }

        /// <summary>
        /// Méthode démontrant comment obtenir une catégorie comptable d'achat par son identifiant
        /// </summary>
        public void GetCategorieComptableAchatByIndice()
        {
            //Définition de l'identifiant de la catégorie comptable
            short idCatCompta = 1;

            CategorieComptableService service = new CategorieComptableService(_webServiceUrl);

            //Récupération de la catégorie comptable
            CategorieComptable catCompta = service.GetByIndiceAchat(idCatCompta);
        }

        /// <summary>
        /// Méthode démontrant comment obtenir une catégorie comptable d'achat par son nom
        /// </summary>
        public void GetCategorieComptableAchatByName()
        {
            //Définition du nom de la catégorie comptable d'achat
            string nomCatCompta = "Achats import";

            CategorieComptableService service = new CategorieComptableService(_webServiceUrl);

            //Récupération de la catégorie comptable d'achat
            CategorieComptable catCompta = service.GetByNameAchat(nomCatCompta);

        }

        #endregion

        #region Vente

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des catégories comptable de vente
        /// </summary>
        public void GetCategorieComptableVenteList()
        {
            CategorieComptableService service = new CategorieComptableService(_webServiceUrl);

            //Récupération de la liste des catégories comptable de vente
            IList<CategorieComptable> catCompta = service.GetListVente();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une catégorie comptable de vente par son identifiant
        /// </summary>
        public void GetCategorieComptableVenteByIndice()
        {
            //Définition de l'identifiant de la catégorie comptable de vente
            short idCatCompta = 1;

            CategorieComptableService service = new CategorieComptableService(_webServiceUrl);

            //Récupération de la catégorie comptable de vente
            CategorieComptable catCompta = service.GetByIndiceVente(idCatCompta);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une catégorie comptable de vente par son nom
        /// </summary>
        public void GetCategorieComptableVenteByName()
        {
            //Définition du nom de la catégorie comptable de vente
            string nomCatCompta = "Ventes export";

            CategorieComptableService service = new CategorieComptableService(_webServiceUrl);

            //Récupération de la catégorie comptable de vente
            CategorieComptable catCompta = service.GetByNameVente(nomCatCompta);

        }

        #endregion

        #region Stock

        /// <summary>
        /// Méthode démontrant comment récupérer la liste des catégories comptable de stock
        /// </summary>
        public void GetCategorieComptableStockList()
        {
            CategorieComptableService service = new CategorieComptableService(_webServiceUrl);

            //Récupération de la liste des catégories comptable de stock
            IList<CategorieComptable> catCompta = service.GetListStock();

        }

        /// <summary>
        /// Méthode démontrant comment récupérer une catégorie comptable de stock par son identifiant
        /// </summary>
        public void GetCategorieComptableStockByIndice()
        {
            //Définition de l'identifiant de la catégorie comptable de stock
            short idCatCompta = 1;

            CategorieComptableService service = new CategorieComptableService(_webServiceUrl);

            //Récupération de la catégorie comptable de stock
            CategorieComptable catCompta = service.GetByIndiceStock(idCatCompta);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une catégorie de stock par son nom
        /// </summary>
        public void GetCategorieComptableStockByName()
        {
            //Définition du nom de la catégorie comptable de stock
            string nomCatCompta = "Stock France";

            CategorieComptableService service = new CategorieComptableService(_webServiceUrl);

            //Récupération de la catégorie comptable de stock
            CategorieComptable catCompta = service.GetByNameStock(nomCatCompta);

        }

        #endregion
    }
}
