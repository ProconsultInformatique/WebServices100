using System;
using System.Collections.Generic;
using WebServices100.Model.DataContract;
using WebServices100.Proxy;

namespace DemoWebServices100.Tool
{

    /// <summary>
    /// Cette classe contient les exemples de création d'instance de la classe Criteria.
    /// Une instance de la classe criteria est:
    /// - soit une instance de CriteriaComparison
    /// - soit une instance de CriteriaLogical
    /// </summary>
    public class CriteriaDemo
    {
        #region Données membre

        private readonly string _webServiceUrl ;

        #endregion

        #region Constructeur

        public CriteriaDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment créer une instance de CriteriaComparison.
        /// </summary>
        public void CreateCriteriaComparison()
        {
            /*
            Le constructeur de CriteriaComparison est le suivant: CriteriaComparison(string fieldName, ComparisonOperator compOperator, object value)
            Le champ fieldName doit être le nom d'une propriété de la classe d'objet qui sera renvoyé par la méthode GetList qui sera utilisée.
            */
            //Par exemple: pour obtenir tous les tiers dont l'email est en '.lu' le criteria qu'il faudra créer sera:
            Criteria criteriaEmailLu = new CriteriaComparison("Email", ComparisonOperator.Like, "%.lu");

            TiersService service = new TiersService(_webServiceUrl);

            List<Tiers> tiersList = service.GetList(criteriaEmailLu);

            foreach (Tiers tiers in tiersList)
                Console.WriteLine("IdTiers: '{0}'\tEmail:'{1}'", tiers.NumeroTiers, tiers.Email);

            Console.ReadLine();

        }

        /// <summary>
        /// Cette méthode montre comment créer une instance de CriteriaLogical.
        /// </summary>
        public void CreateCriteriaLogical()
        {
            /*
            Le constructeur de CriteriaLogical est le suivant: CriteriaLogical(Criteria criteria1, LogicalOperator logOperator, Criteria criteria2)
            Donc une instance de CriteriaLogical sert à combiner des instances de Criteria entre elles.
            */
            
            //Par exemple: pour récupérer les tarifs d'article de la catégorie tarifaire 2 dont le prix de vente est supérieur à 23
            //le criteria qu'il faudra créer sera:
            Criteria criteriaCatTarif = new CriteriaComparison("IdCategorieTarifaire", ComparisonOperator.Equals,2);
            Criteria criteriaPrixVente = new CriteriaComparison("PrixVente", ComparisonOperator.GreaterThan, 23M);
            Criteria criteria = new CriteriaLogical(criteriaCatTarif, LogicalOperator.And, criteriaPrixVente);

            TarifService service = new TarifService(_webServiceUrl);

            List<TarifArticle> tarifArticleList = service.GetListTarifArticles(criteria);

            foreach (TarifArticle tarifArticle in tarifArticleList)
                Console.WriteLine("RefArticle: '{0}'\tIdCatTarifaire: {1}\tIntituleCatTarif: '{2}'\tPrix: {3}", tarifArticle.RefArticle, tarifArticle.IdCategorieTarifaire, tarifArticle.IntituleCategorieTarifaire, tarifArticle.PrixVente);

            Console.ReadLine();
        }

        #endregion
    }
}
