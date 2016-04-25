using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Maestria
{
    public class ModeReglementServiceDemo
    {

        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public ModeReglementServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode démontrant comment obtenir un mode de réglement par son indice.
        /// </summary>
        public void GetModeReglementByIndice()
        {
            //Définition de l'indice du mode de réglement
            short indiceModeReglement = 2;

            ModeReglementService service = new ModeReglementService(_webServiceUrl);

            //Récupération du mode de réglement
            ModeReglement modeReglement = service.GetByIndice(indiceModeReglement);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir une mode de réglement par son nom.
        /// </summary>
        public void GetModeReglementByName()
        {
            //Définition du nom du mode de réglement
            string nomModeReglement = "Virement";

            ModeReglementService service = new ModeReglementService(_webServiceUrl);

            //Récupération du mode de réglement
            ModeReglement modeReglement = service.GetByName(nomModeReglement);

        }

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des modes de réglement.
        /// </summary>
        public void GetModeReglementList()
        {
            ModeReglementService service = new ModeReglementService(_webServiceUrl);

            //Récupération de la liste des modes de réglement
            List<ModeReglement> modeReglementList = service.GetList();

        }

        #endregion
    }
}
