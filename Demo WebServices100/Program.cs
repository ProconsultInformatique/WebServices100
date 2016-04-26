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
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            string defaultWebServiceUrl = "http://localhost:12345/Webservices100/SAGE_FRAMEWORK/";

            DemoWebServices100.Maestria.EcritureServiceDemo service = new DemoWebServices100.Maestria.EcritureServiceDemo(defaultWebServiceUrl);
            service.DemontrationInsertionPiececomptableAvecEcritureAnalytique();

            DemoWebServices100.Tool.OrderDemo critDemo = new DemoWebServices100.Tool.OrderDemo(defaultWebServiceUrl);
            critDemo.CreateOrderList();
        }
    }
}
