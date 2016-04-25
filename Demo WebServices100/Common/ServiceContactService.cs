using System;
using System.Collections.Generic;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;

namespace DemoWebServices100.Common
{
    public class ServiceContactServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur
        public ServiceContactServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des services.
        /// </summary>
        public void GetServiceContactList()
        {
            ServiceContactService service = new ServiceContactService(_webServiceUrl);

            //Récupération de la liste des services
            IList<ServiceContact> services = service.GetList();
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir un service par son identifiant.
        /// </summary>
        public void GetServiceContactByIndice()
        {
            //Définition de l'identifiant du service
            short idService = 1;

            ServiceContactService service = new ServiceContactService(_webServiceUrl);

            //Récupération du service
            ServiceContact serviceContact = service.GetByIndice(idService);
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir un service par son nom.
        /// </summary>
        public void GetServiceContactByName()
        {
            //Définition du nom du service
            string nomService = "Commerciale";

            ServiceContactService service = new ServiceContactService(_webServiceUrl);

            //Récupération du service
            ServiceContact serviceContact = service.GetByName(nomService);
            
        }

        #endregion
    }
}
