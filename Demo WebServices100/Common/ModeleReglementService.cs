using System.Collections.Generic;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;

namespace DemoWebServices100.Common
{

    public class ModeleReglementServiceDemo
    {

        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public ModeleReglementServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des modes de réglement.
        /// </summary>
        public void GetModeReglementList()
        {
            ModeleReglementService service = new ModeleReglementService(_webServiceUrl);

            //Récupération de la liste des modes de réglement
            IList<ModeleReglement> data = service.GetList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir un mode de réglement par son indice.
        /// </summary>
        public void GetModeReglementByIndice()
        {
            //Définition de l'indice
            int idModeReglement = 1;

            ModeleReglementService service = new ModeleReglementService(_webServiceUrl);

            //Récupération du mode de réglement
            ModeleReglement data = service.GetByIndice(idModeReglement);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir un mode de réglement par son nom.
        /// </summary>
        public void GetModeReglementByName()
        {
            //Définition du nom
            string nomMode = "Paiement en 3 fois";

            ModeleReglementService service = new ModeleReglementService(_webServiceUrl);

            //Récupération du mode de réglement
            ModeleReglement data = service.GetByName(nomMode);

        }

        #endregion
    }
}
