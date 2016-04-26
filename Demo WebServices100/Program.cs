using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WebServices100
{
    class Program
    {
        /// <summary>
        /// Afin de tester les WebServices100, veuillez copier les bouts de codes des exemples fournis dans les classes de démontration
        /// définies dans ce projet, en adaptant les références, intitulé, identifiant, etc à vos propres données.
        /// </summary>
        /// <param name="args"></param>
        /// <!--adresse par défaut du WebServices100 = "http://localhost:12345/Webservices100/[NOM_DE_L'ENVIRONNEMENT]/";-->
        static void Main(string[] args)
        {

            string defaultWebServiceUrl = "http://localhost:12345/Webservices100/BIJOU/";
            DemonstrationTools(defaultWebServiceUrl);
         
        }

        /// <summary>
        /// Démonstration sur la façon de créer les paramètres de tri et de critère.
        /// Il est nécessaire de comprendre comment fonctionnent ces 2 concepts 
        /// puisqu'ils sont utilisés dans une grande partie de WebServices100.
        /// </summary>
        /// <param name="webServiceUrl"></param>
        static void DemonstrationTools(string webServiceUrl)
        {

            DemoWebServices100.Tool.CriteriaDemo critDemo = new DemoWebServices100.Tool.CriteriaDemo(webServiceUrl);
            critDemo.CreateCriteriaComparison();

            DemoWebServices100.Tool.OrderDemo orderDemo = new DemoWebServices100.Tool.OrderDemo(webServiceUrl);
            orderDemo.CreateOrderList();

        }
    }
}
