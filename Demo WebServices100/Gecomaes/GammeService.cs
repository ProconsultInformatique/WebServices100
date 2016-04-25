using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Gecomaes
{
    public class GammeServiceDemo
    {
        #region Données membres

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public GammeServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des gammes
        /// </summary>
        public void GetGammeList()
        {
            GammeService service = new GammeService(_webServiceUrl);

            //Récupération de la liste des gammes
            List<Gamme> gammeList = service.GetList();
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des gammes d'article (gamme 1) d'un article
        /// </summary>
        public void GetGammeList1ByRefArticle()
        {
            //Définition de la référence d'aricle
            string refArticleGamme = "CHAAR/VAR";

            GammeService service = new GammeService(_webServiceUrl);

            //Récupération de la liste des gammes d'article (gamme 1)
            List<GammeArticle> gamme1List = service.GetListGamme1ByRefArticle(refArticleGamme);
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des gammes d'article (gamme 2) d'un article
        /// </summary>
        public void GetGammeList2ByRefArticle()
        {
            //Définition de la référence d'aricle
            string refArticleGamme = "CHAAR/VAR";

            GammeService service = new GammeService(_webServiceUrl);

            //Récupération de la liste des gammes d'article (gamme 2)
            List<GammeArticle> gamme2List = service.GetListGamme2ByRefArticle(refArticleGamme);

        }

        #endregion
    }
}
