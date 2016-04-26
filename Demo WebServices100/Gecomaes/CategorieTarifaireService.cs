using System;
using System.Collections.Generic;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;

namespace DemoWebServices100.Gecomaes
{
    public class CategorieTarifaireServiceDemo
    {
        #region Données membres

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public CategorieTarifaireServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des catégories tarifaires.
        /// </summary>
        public void GetCategorieTarifaireList()
        {

            CategorieTarifaireService service = new CategorieTarifaireService(_webServiceUrl);

            //Récupération de la liste des catégories tarifaires
            IList<CategorieTarifaire> catTarif = service.GetList();
            
        }

        /// <summary>
        /// Cette méthode montre comment obtenir une catégorie tarifaire par son identifiant.
        /// </summary>
        public void GetCategorieTarifaireByIndice()
        {
            //Définition de l'identifiant de la catégorie tarifaire
            short idCatTarifaire = 1;

            CategorieTarifaireService service = new CategorieTarifaireService(_webServiceUrl);

            //Récupération de la catégorie tarifaire
            CategorieTarifaire catTarif = service.GetByIndice(idCatTarifaire);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une catégorie tarifaire par son nom.
        /// </summary>
        public void GetCategorieTarifaireByName()
        {
            //Définition du nom de la catégorie tarifaire
            string nomCatTarifaire = "Clients comptoir";

            CategorieTarifaireService service = new CategorieTarifaireService(_webServiceUrl);
            
            //Récupération de la catégorie tarifaire
            CategorieTarifaire catTarif = service.GetByName(nomCatTarifaire);
            
        }

        #endregion
    }
}
