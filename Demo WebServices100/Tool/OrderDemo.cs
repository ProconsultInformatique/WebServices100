using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServices100.Model.DataContract;

namespace DemoWebServices100.Tool
{
    /// <summary>
    /// Cette classe montre comment créer des instances de la classe Order afin d'appliquer des tris lors des recherches.
    /// </summary>
    public class OrderDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public OrderDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment créer une liste de Order
        /// </summary>
        public void CreateOrderList()
        {
            /*
            Le constructeur de la classe Order est le suivant Order(string fieldName, OrderType orderType)
            Le champ fieldName doit être le nom d'une propriété de la classe d'objet obtenu par l'utilisation de GetList
            */

            //Exemple de tri sur les tiers par ordre croissant de pays et décroissant par numéro de tiers.
            List<Order> orders = new List<Order>();
            Order orderPaysAsc = new Order("Pays", OrderType.Asc);
            Order orderNumTiersDesc = new Order("NumeroTiers",OrderType.Desc);
            orders.Add(orderPaysAsc);
            orders.Add( orderNumTiersDesc);

            WebServices100.Proxy.TiersService service = new WebServices100.Proxy.TiersService(_webServiceUrl);
            List<Tiers> tiersList = service.GetList(orders: orders);
            foreach (Tiers tiers in tiersList)
                Console.WriteLine("Pays: '{0}'\tNumTiers: '{1}'", tiers.Pays, tiers.NumeroTiers);
        }

        #endregion
    }
}
