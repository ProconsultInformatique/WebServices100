using System.Collections.Generic;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;

namespace DemoWebServices100.Common
{

    public class InfoLibreServiceDemo
    {

        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public InfoLibreServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode démontrant comment obtenir les colonnes d'infos libres de tiers.
        /// </summary>
        public void GetInfosLibresTiers()
        {

            InfoLibreService service = new InfoLibreService(_webServiceUrl);

            //Récupération des colonnes d'information libre
            IList<InfoLibre> list = service.GetInfosLibresTiers();

        }

        /// <summary>
        /// Méthode démontrant comment obtenir les colonnes d'information libre d'article.
        /// </summary>
        public void GetInfosLibresArticle()
        {
            InfoLibreService service = new InfoLibreService(_webServiceUrl);

            //Récupération des colonnes d'information libre
            IList<InfoLibre> list = service.GetInfosLibresArticle();
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir les colonnes d'informations libre de document.
        /// </summary>
        public void GetInfosLibresDocument()
        {
            InfoLibreService service = new InfoLibreService(_webServiceUrl);

            //Récupération des colonnes d'information libre
            IList<InfoLibre> list = service.GetInfosLibresDocument();
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir les colonnes d'informations libre de ligne de document.
        /// </summary>
        public void GetInfosLibresLigneDocument()
        {
            InfoLibreService service = new InfoLibreService(_webServiceUrl);

            //Récupération des colonnes d'information libre
            IList<InfoLibre> list = service.GetInfosLibresLigneDocument();
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir les colonnes d'informations libre de compte général.
        /// </summary>
        public void GetInfosLibresCompteGeneral()
        {
            InfoLibreService service = new InfoLibreService(_webServiceUrl);

            //Récupération des colonnes d'information libre
            IList<InfoLibre> list = service.GetInfosLibresCompteGeneral();
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir les colonnes d'informations libre d'écriture.
        /// </summary>
        public void GetInfosLibresEcriture()
        {
            InfoLibreService service = new InfoLibreService(_webServiceUrl);

            //Récupération des colonnes d'information libre
            IList<InfoLibre> list = service.GetInfosLibresEcriture();
            
        }

        #endregion
    }
}
