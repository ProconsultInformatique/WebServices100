using System;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Maestria
{
    public class PlanAnalytiqueServiceDemo
    {

        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public PlanAnalytiqueServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment obtenir un plan analytique par son indice.
        /// </summary>
        public void GetPlanAnalytiqueByIndice()
        {
            //Définition de l'indice de plan analytique
            short indice = 2;

            PlanAnalytiqueService service = new PlanAnalytiqueService(_webServiceUrl);

            //Récupération du plan analytique
            PlanAnalytique plan = service.GetByIndice(indice);
            
        }

        /// <summary>
        /// Cette méthode montre comment obtenir un plan analytique par son nom.
        /// </summary>
        public void GetPlanAnalytiqueByName()
        {
            //Définition du nom du plan
            string nomPlan = "Affaires";

            PlanAnalytiqueService service = new PlanAnalytiqueService(_webServiceUrl);

            //Récupération du plan analytique
            PlanAnalytique plan = service.GetByName(nomPlan);
            
        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des plans analytiques.
        /// </summary>
        public void GetPlanAnalytiqueList()
        {

            PlanAnalytiqueService service = new PlanAnalytiqueService(_webServiceUrl);

            //Récupération de la liste des plans analytiques
            List<PlanAnalytique> planList = service.GetList();
            
        }

        #endregion
    }
}
