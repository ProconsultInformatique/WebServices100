using System.Data;
using WebServices100.Proxy;

namespace DemoWebServices100.Common
{
    public class SqlServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public SqlServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment obtenir une datatable correspondant à une requête de lecture.
        /// </summary>
        public void GetData()
        {
            //Définition de la requête de lecture
            string query =
                @"SELECT DO_DATE AS CA_DATE,SUM(DO_TotalHT) AS CA_AMOUNT 
                FROM F_DOCENTETE 
                WHERE DO_Domaine = 0 AND YEAR(DO_DATE) = 2013 
                GROUP BY DO_DATE 
                ORDER BY DO_DATE ";

            SqlService service = new SqlService(_webServiceUrl);

            //Récupération de la datatable correspondant à la requête
            DataTable table = service.GetData(query);

        }

        /// <summary>
        /// Cette méthode montre comment executer une requête sql directement sur la base.
        /// </summary>
        public void ExecuteQuery()
        {
            //Définition de la requète de mise à jour 
            //(mise à jour du code région à 'Lorraine' sur tous les tiers dont la ville est 'Metz' et dont le code région n'est pas défini).
            string query = @"UPDATE F_COMPTET 
                            SET CT_CodeRegion = 'Lorraine' 
                            WHERE CT_Ville ='Metz' AND ISNULL(CT_CodeRegion,'')=''";

            SqlService service = new SqlService(_webServiceUrl);

            //Execution de la requète
            service.ExecuteQuery(query);
        }

        #endregion
    }
}
