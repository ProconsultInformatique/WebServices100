using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Maestria
{
    public class DeviseServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public DeviseServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des devises.
        /// </summary>
        public void GetDeviseList()
        {
            DeviseService service = new DeviseService(_webServiceUrl);

            //Récupération de la liste des devises
            List<Devise> deviseList = service.GetList();
            
        }

        /// <summary>
        /// Cette méthode montre comment obtenir une devise par son indice.
        /// </summary>
        public void GetDeviseByIndice()
        {
            //Définition de l'indice de devise
            short indice = 4;

            DeviseService service = new DeviseService(_webServiceUrl);

            //Récupération de la devise
            Devise devise = service.GetByIndice(indice);

        }

        #endregion
    }
}
