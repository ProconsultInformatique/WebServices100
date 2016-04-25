using System;
using System.Collections.Generic;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;

namespace DemoWebServices100.Common
{
    public class TypeContactServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public TypeContactServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode démontrant comment obtenir la liste des types de contact.
        /// </summary>
        public void GetTypeContactList()
        {
            TypeContactService service = new TypeContactService(_webServiceUrl);

            //Récupération de la liste des types de contact
            IList<TypeContact> types = service.GetList();
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir un type de contact par son indice.
        /// </summary>
        public void GetTypeContactByIndice()
        {
            //Définition de l'indice de type de contact
            short idTypeContact = 1;

            TypeContactService service = new TypeContactService(_webServiceUrl);

            //Récupération du type de contact
            TypeContact type = service.GetByIndice(idTypeContact);
            
        }

        /// <summary>
        /// Méthode démontrant comment obtenir un type de contact par son nom.
        /// </summary>
        public void GetTypeContactByName()
        {
            //Définition du nom du type de contact
            string nomTypeContact = "Huissier";

            TypeContactService service = new TypeContactService(_webServiceUrl);

            //Récupération du type de contact
            TypeContact type = service.GetByName(nomTypeContact);
            
        }

        #endregion
    }
}
