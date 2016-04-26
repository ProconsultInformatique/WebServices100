using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Maestria
{
    public class TaxeServiceDemo
    {

        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public TaxeServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des taxes.
        /// </summary>
        public void GetTaxeList()
        {
            TaxeService service = new TaxeService(_webServiceUrl);

            //Récupération de la liste des taxes
            List<Taxe> taxeList = service.GetList();
            
        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des taxes répondants à un critère.
        /// </summary>
        public void GetTaxeListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Taux", ComparisonOperator.GreaterThan, 10);

            TaxeService service = new TaxeService(_webServiceUrl);
            
            //Récupération de la liste des taxes
            List<Taxe> taxeList = service.GetList(criteria);
            
        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste triée de taxe selon une propriété.
        /// </summary>
        public void GetTaxeListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("Taux", OrderType.Desc) };

            TaxeService service = new TaxeService(_webServiceUrl);
            
            //Récupération de la liste des taxes
            List<Taxe> taxeList = service.GetList(orders: orders);
            
        }

        /// <summary>
        /// Cette méthode montre comment obtenir une page de liste de taxe.
        /// </summary>
        public void GetTaxeListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 4;
            int itemsPerPage = 10;
            
            TaxeService service = new TaxeService(_webServiceUrl);

            //Récupération de la page de taxe
            List<Taxe> taxeList = service.GetList(rowsPerPage:itemsPerPage,pageNumber:pageIndex);
            
        }

        #endregion
    }
}
