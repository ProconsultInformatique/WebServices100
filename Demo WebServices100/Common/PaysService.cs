using System;
using System.Collections.Generic;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;

namespace DemoWebServices100.Common
{
    public class PaysServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public PaysServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthode

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des pays.
        /// </summary>
        public void GetPaysList()
        {
            PaysService service = new PaysService(_webServiceUrl);

            //Récupération des pays
            IList<Pays> data = service.GetList();
        }

        #endregion

    }
}
