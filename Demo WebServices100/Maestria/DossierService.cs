using System;

using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Maestria
{

    public class DossierServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public DossierServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment obtenir la devise du dossier.
        /// </summary>
        public void GetDeviseDossier()
        {

            DossierService service = new DossierService(_webServiceUrl);

            //Récupération de la devise du dossier
            Devise devise = service.GetDeviseDossier();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la période d'un exercice englobant une date.
        /// </summary>
        public void GetPeriodeExerciceByDate()
        {
            //Définition de la date d'exercice
            DateTime dateExo = new DateTime(2015, 3, 1);

            DossierService service = new DossierService(_webServiceUrl);

            //Récupération de la période d'exercice englobant la date d'exercice
            Periode periode = service.GetExerciceByDate(dateExo);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des périodes d'exercice.
        /// </summary>
        public void GetPeriodeExerciceList()
        {
            DossierService service = new DossierService(_webServiceUrl);

            //Récupération de la liste des périodes d'exercice
            List<Periode> periodeList = service.GetExercices();
            
        }

        #endregion
    }
}
