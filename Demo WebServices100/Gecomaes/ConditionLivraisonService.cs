using System;
using System.Collections.Generic;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;

namespace DemoWebServices100.Gecomaes
{
    public class ConditionLivraisonServiceDemo
    {

        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public ConditionLivraisonServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des conditions de livraison
        /// </summary>
        public void GetConditionLivraisonList()
        {
            ConditionLivraisonService service = new ConditionLivraisonService(_webServiceUrl);

            //Récupération de la liste des conditions de livraison
            IList<ConditionLivraison> cond = service.GetList();
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir une condition de livraison par son identifiant
        /// </summary>
        public void GetConditionLivraisonByIndice()
        {
            //Définition de l'identifiant de la condition de livraison
            short idConditionLivraison = 1;

            ConditionLivraisonService service = new ConditionLivraisonService(_webServiceUrl);

            //Récupération de la condition de livraison
            ConditionLivraison cond = service.GetByIndice(idConditionLivraison);
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir une condition de livraison par son nom
        /// </summary>
        public void GetConditionLivraisonByName()
        {
            //Définition du nom de la condition de livraison
            string nomCondLivraison = "Exp. Franco transporteur";

            ConditionLivraisonService service = new ConditionLivraisonService(_webServiceUrl);

            //Récupération de la condition de livraison
            ConditionLivraison cond = service.GetByName(nomCondLivraison);
            
        }

        #endregion
    }
}
