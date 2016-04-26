using System;
using System.Collections.Generic;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;

namespace DemoWebServices100.Gecomaes
{
    public class ModeExpeditionServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public ModeExpeditionServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des modes d'expédition.
        /// </summary>
        public void GetModeExpeditionList()
        {
            ModeExpeditionService service = new ModeExpeditionService(_webServiceUrl);

            //Récupération de la liste des modes d'expédition
            IList<ModeExpedition> expeditions = service.GetList();
            
        }

        /// <summary>
        /// Cette méthode montre comment obtenir un mode d'expédition par son indice.
        /// </summary>
        public void GetModeExpeditionByIndice()
        {
            //Définition de l'indice du mode d'expédition
            short idModeExpedition = 1;

            ModeExpeditionService service = new ModeExpeditionService(_webServiceUrl);

            //Récupération du mode d'expédition
            ModeExpedition expedition = service.GetByIndice(idModeExpedition);
            
        }

        /// <summary>
        /// Cette méthode montre comment obtenir un mode d'expédition par son nom.
        /// </summary>
        public void GetModeExpeditionByName()
        {
            //Définition du nom du mode d'expédition
            string nomModeExpedition = "Chronoposte";

            ModeExpeditionService service = new ModeExpeditionService(_webServiceUrl);

            //Récupération du mode d'expédition
            ModeExpedition expedition = service.GetByName(nomModeExpedition);
            
        }

        #endregion
    }
}
