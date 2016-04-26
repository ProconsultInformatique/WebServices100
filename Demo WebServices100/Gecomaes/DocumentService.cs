using System;
using System.Linq;
using WebServices100.Proxy;
using WebServices100.Model.DataContract;
using System.Collections.Generic;

namespace DemoWebServices100.Gecomaes
{
    public class DocumentServiceDemo
    {
        #region Données membre


        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public DocumentServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes Document

        /// <summary>
        /// Cette méthode montre comment obtenir un document.
        /// </summary>
        public void GetDocument()
        {
            //Définition du type de document et du numéro de document
            TypeDocument typeDoc = TypeDocument.BonDeCommandeAchat;
            string numDoc = "FBC00003";


            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération du document
            Document doc = service.GetDocument(typeDoc, numDoc);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des documents.
        /// </summary>
        public void GetDocumentList()
        {
            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste de documents
            IList<Document> documentList = service.GetList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de document répondant à un critère.
        /// </summary>
        public void GetDocumentListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Statut", ComparisonOperator.Equals, StatutDocument.Accepte);

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste de documents répondant au critère
            List<Document> documentList = service.GetList(criteria).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de document triée selon une propriété.
        /// </summary>
        public void GetDocumentListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroTiers", OrderType.Desc) };

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste de document triée
            List<Document> documentList = service.GetList(orders: orders).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une page de liste de document.
        /// </summary>
        public void GetDocumentListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la page de liste de document
            List<Document> documentList = service.GetList(pageNumber: pageIndex, rowsPerPage: itemsPerPage).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de documents en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetDocumentListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Statut", ComparisonOperator.Equals, StatutDocument.Accepte);

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroTiers", OrderType.Desc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la page de liste de document
            List<Document> documentList = service.GetList(criteria, orders, pageIndex, itemsPerPage).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des documents d'achat.
        /// </summary>
        public void GetDocumentAchatList()
        {
            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des documents d'achat
            IList<DocumentAchat> documentList = service.GetListDocumentAchat();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de documents d'achat répondant à un critère.
        /// </summary>
        public void GetDocumentAchatListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Statut", ComparisonOperator.Equals, StatutDocument.Accepte);

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des documents d'achat
            List<DocumentAchat> documentList = service.GetListDocumentAchat(criteria).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de documents d'achat trié selon une propriété.
        /// </summary>
        public void GetDocumentAchatListOrdered()
        {

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroTiers", OrderType.Desc) };

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste de document d'achat triée
            List<DocumentAchat> documentList = service.GetListDocumentAchat(orders: orders).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une page de liste de documents d'achat.
        /// </summary>
        public void GetDocumentAchatListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la page de liste de document
            List<DocumentAchat> documentList = service.GetListDocumentAchat(pageNumber: pageIndex, rowsPerPage: itemsPerPage).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de documents d'achat en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetDocumentAchatListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Statut", ComparisonOperator.Equals, StatutDocument.Accepte);

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroTiers", OrderType.Desc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la page de liste de document
            List<DocumentAchat> documentList = service.GetListDocumentAchat(criteria, orders, pageIndex, itemsPerPage).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des documents interne.
        /// </summary>
        public void GetDocumentInterneList()
        {
            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des documents interne
            IList<DocumentInterne> documentList = service.GetListDocumentInterne();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de documents interne répondant à un critère.
        /// </summary>
        public void GetDocumentInterneListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Statut", ComparisonOperator.Equals, StatutDocument.Accepte);

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des documents interne
            List<DocumentInterne> documentList = service.GetListDocumentInterne(criteria).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de documents interne trié selon une propriété.
        /// </summary>
        public void GetDocumentInterneListOrdered()
        {

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroTiers", OrderType.Desc) };

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste de document interne triée
            List<DocumentInterne> documentList = service.GetListDocumentInterne(orders: orders).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une page de liste de document interne.
        /// </summary>
        public void GetDocumentInterneListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la page de liste de document
            List<DocumentInterne> documentList = service.GetListDocumentInterne(pageNumber: pageIndex, rowsPerPage: itemsPerPage).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de documents internes en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetDocumentInterneListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Statut", ComparisonOperator.Equals, StatutDocument.Accepte);

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroTiers", OrderType.Desc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste de documents
            List<DocumentInterne> documentList = service.GetListDocumentInterne(criteria, orders, pageIndex, itemsPerPage).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des documents de stock.
        /// </summary>
        public void GetDocumentStockList()
        {
            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des documents de stock
            IList<DocumentStock> documentList = service.GetListDocumentStock();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de documents de stock répondant à un critère.
        /// </summary>
        public void GetDocumentStockListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("TypeDocument", ComparisonOperator.Equals, TypeDocument.VirementDeDepotDepotStock);

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des documents de stock
            List<DocumentStock> documentList = service.GetListDocumentStock(criteria).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de documents de stock trié selon une propriété.
        /// </summary>
        public void GetDocumentStockListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroTiers", OrderType.Desc) };

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des documents de stock
            List<DocumentStock> documentList = service.GetListDocumentStock(orders: orders).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une page de liste de document de stock.
        /// </summary>
        public void GetDocumentStockListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la page de liste des documents de stock
            List<DocumentStock> documentList = service.GetListDocumentStock(pageNumber: pageIndex, rowsPerPage: itemsPerPage).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de documents de stock en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetDocumentStockListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("TypeDocument", ComparisonOperator.Equals, TypeDocument.VirementDeDepotDepotStock);

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroTiers", OrderType.Desc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des documents de stock
            List<DocumentStock> documentList = service.GetListDocumentStock(criteria, orders, pageIndex, itemsPerPage).ToList();

        }
        /// <summary>
        /// Cette méthode montre comment obtenir la liste des documents de vente.
        /// </summary>
        public void GetDocumentVenteList()
        {
            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des documents de stock
            IList<DocumentVente> documentList = service.GetListDocumentVente();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de documents de vente répondant à un critère.
        /// </summary>
        public void GetDocumentVenteListByCriteria()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Statut", ComparisonOperator.Equals, StatutDocument.Accepte);

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des documents de vente
            List<DocumentVente> documentList = service.GetListDocumentVente(criteria).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de documents de vente trié selon une propriété.
        /// </summary>
        public void GetDocumentVenteListOrdered()
        {
            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroTiers", OrderType.Desc) };

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des documents de vente
            List<DocumentVente> documentList = service.GetListDocumentVente(orders: orders).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une page de liste de document de vente.
        /// </summary>
        public void GetDocumentVenteListPaged()
        {
            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la page de liste des documents de vente
            List<DocumentVente> documentList = service.GetListDocumentVente(pageNumber: pageIndex, rowsPerPage: itemsPerPage).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une liste de documents de vente en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetDocumentVenteListComplex()
        {
            //Définition du critère
            Criteria criteria = new CriteriaComparison("Statut", ComparisonOperator.Equals, StatutDocument.Accepte);

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("NumeroTiers", OrderType.Desc) };

            //Définition de l'index de page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 5;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des documents de vente
            List<DocumentVente> documentList = service.GetListDocumentVente(criteria, orders, pageIndex, itemsPerPage).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des documents en cours d'un domaine.
        /// </summary>
        public void GetDocumentListEnCoursByDomaine()
        {
            //Définition du domaine
            DomaineDocument domaine = DomaineDocument.Achat;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste de document en cours
            IList<Document> documentList = service.GetListDocumentEnCoursByDomaine(domaine);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste triée, selon une propriété, des documents en cours d'un domaine.
        /// </summary>
        public void GetDocumentListEnCoursByDomaineOrdered()
        {

            //Définition du domaine de document
            DomaineDocument domaine = DomaineDocument.Achat;

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("DateLivraison", OrderType.Asc) };

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste triée
            IList<Document> documentList = service.GetListDocumentEnCoursByDomaine(domaine, orders);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir une page de la liste des documents en cours.
        /// </summary>
        public void GetDocumentListEnCoursByDomainePaged()
        {
            //Défintion de l'index de la page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 4;

            //Définition du domaine de document
            DomaineDocument domaine = DomaineDocument.Achat;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la page de la liste de document en cours
            IList<Document> documentList = service.GetListDocumentEnCoursByDomaine(domaine, pageNumber: pageIndex, rowsPerPage: itemsPerPage);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des documents en cours en utilisant l'ensemble des paramètres.
        /// </summary>
        public void GetDocumentListEnCoursByDomaineComplex()
        {

            //Définition de la méthode de tri
            List<Order> orders = new List<Order>() { new Order("DateLivraison", OrderType.Asc) };

            //Défintion de l'index de la page et du nombre d'éléments par page
            int pageIndex = 3;
            int itemsPerPage = 4;

            //Définition du domaine de document
            DomaineDocument domaine = DomaineDocument.Achat;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la page de la liste de document en cours
            IList<Document> documentList = service.GetListDocumentEnCoursByDomaine(domaine, orders, pageIndex, itemsPerPage);

        }

        /// <summary>
        /// Méthode d'insertion d'un document dans la base
        /// </summary>
        public void InsertDocument()
        {

            //Définition du document à insérer
            Document doc = CreateNewDocument(TypeDocument.BonDeCommandeVente);

            DocumentService service = new DocumentService(_webServiceUrl);

            //Insertion du document dans la base            
            string numDoc = service.InsertDocument(doc);

        }

        /// <summary>
        /// Cette méthode montre comment insérer un entete de document sans créer d'instance de document.
        /// </summary>
        public void InsertEntete()
        {

            //Définition des données de l'entete
            TypeDocument typeDoc = TypeDocument.FactureVente;
            DateTime now = DateTime.Now;
            string numDocument = "FACTURE1";
            string numTiers = "CARAT";

            DocumentService service = new DocumentService(_webServiceUrl);

            //Insertion de l'entete
            numDocument = service.InsertEntete(typeDoc, now, numDocument, numTiers);

        }


        /// <summary>
        /// Méthode d'insertion d'un document et de ses lignes dans la base
        /// </summary>
        public void InsertDocumentEtLignes()
        {
            //Définition du document et de ses lignes
            Document doc = CreateNewDocument(TypeDocument.BonDeLivraisonVente);
            List<LigneDocument> ligneList = CreateNewLigneDocumentList(doc.TypeDocument);

            DocumentService service = new DocumentService(_webServiceUrl);

            //Insertion du document et de ses lignes dans la base
            service.InsertDocumentEtLignes(doc, ligneList);

        }

        #endregion

        #region Méthodes LigneDocument

        /// <summary>
        /// Cette méthode montre comment obtenir une ligne de document.
        /// </summary>
        public void GetLigneDocument()
        {
            //Définition de l'identifiant de la ligne de document
            int idLigne = 2884;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la ligne de document
            LigneDocument ligne = service.GetLigneDocument(idLigne);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des lignes de document d'un document.
        /// </summary>
        public void GetLigneDocumentListOfDocument()
        {
            //Définition du type et du numéro de document
            TypeDocument typeDoc = TypeDocument.BonAvoirVente;
            string numDocument = "BA00003";

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des lignes du document
            List<LigneDocument> ligneDocumentList = service.GetListLigneDocument(typeDoc, numDocument).ToList();

        }

        /// <summary>
        /// Cette méthode montre comment insérer une ligne de document dans la base.
        /// </summary>
        public void InsertLigneDocument()
        {
            //Définition de la ligne de document à insérer
            LigneDocument ligne = GetLigne(TypeDocument.PreparationDeCommandeAchat, "PC00002");

            DocumentService service = new DocumentService(_webServiceUrl);

            //Insertion de la ligne de document
            service.InsertLigne(ligne);

        }

        #endregion

        #region Réglement

        /// <summary>
        /// Cette méthode montre comment obtenie la liste des réglements d'un document.
        /// </summary>
        public void GetReglementListOfDocument()
        {
            //Définition du numéro et type de document
            string numDoc = "FBC00002";
            TypeDocument typeDoc = TypeDocument.BonDeCommandeAchat;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste des réglements du document
            IList<Reglement> reglementList = service.GetReglementsDocument(numDoc, typeDoc);

        }

        /// <summary>
        /// Cette méthode montre comment insérer une liste de réglement dans la base.
        /// </summary>
        public void InsertReglementList()
        {
            //Définition des données identifiant le document
            TypeDocument typeDoc = TypeDocument.FactureVente;
            string numDocument = "FA00015";

            //Définition de la liste des réglements
            List<Reglement> reglementList = GetReglementList();

            DocumentService service = new DocumentService(_webServiceUrl);

            //Insertion des réglements dans la base
            service.InsertReglements(numDocument, typeDoc, reglementList);

        }


        #endregion

        #region DocumentTypeLibelle

        /// <summary>
        /// Cette méthode montre comment obtenir la liste des libellé de type de document.
        /// </summary>
        public void GetDocumentTypeLibelleList()
        {
            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération de la liste
            IList<DocumentTypeLibelle> documentTypeLibelleList = service.GetListTypeDocumentLibelle();

        }

        /// <summary>
        /// Cette méthode montre comment obtenir un libellé de type de document interne.
        /// </summary>
        public void GetDocumentTypeLibelleInterneByLibelle()
        {
            //Définition du libelle
            string libelle = "Reversement commission";

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération du document type libelle
            DocumentTypeLibelle docTypeLibelle = service.GetTypeDocumentInterneByLibelle(libelle);

        }

        /// <summary>
        /// Cette méthode montre comment obtenir un libelle de type de document par le type de document.
        /// </summary>
        public void GetDocumentTypeLibelleByTypeDocument()
        {
            //Définition du type de document
            TypeDocument typeDoc = TypeDocument.FactureAchat;

            DocumentService service = new DocumentService(_webServiceUrl);

            //Récupération du libellé de type de document
            DocumentTypeLibelle docTypeLibelle = service.GetTypeDocumentLibelle(typeDoc);

        }

        #endregion

        #region Méthodes privées

        /// <summary>
        /// Méthode de contruction d'un nouveau document
        /// </summary>
        /// <param name="typeDoc">Type du nouveau document</param>
        /// <returns></returns>
        private Document CreateNewDocument(TypeDocument typeDoc)
        {

            DocumentVente doc = new DocumentVente(typeDoc);
            doc.Date = DateTime.Now;
            doc.Contact = "Contact toto";
            doc.Statut = StatutDocument.Saisie;
            doc.SectionAnalytique = "953WEB";
            doc.IdCategorieComptable = 2;
            doc.IdCategorieTarifaire = 2;
            doc.NumeroTiers = "CISEL";
            doc.NumeroTiersPayeur = "CISEL";
            doc.IdDepot = 2;
            doc.IdModeExpedition = 2;
            doc.IdConditionLivraison = 2;
            doc.IdCollaborateur = 0;
            doc.IdSouche = 2;
            doc.IdDevise = 2;
            doc.CoursDevise = 1.57m;

            return doc;
        }

        /// <summary>
        /// Méthode de construction d'une liste de lignes de document
        /// </summary>
        /// <param name="typeDoc">Type de document des lignes</param>
        /// <returns></returns>
        private List<LigneDocument> CreateNewLigneDocumentList(TypeDocument typeDoc)
        {
            List<LigneDocument> docLignes = new List<LigneDocument>();
            LigneArticle ligneArticle = new LigneArticle(typeDoc);
            ligneArticle.RefArticle = "BRAAR10";
            ligneArticle.Quantite = 4;
            ligneArticle.PrixUnitaire = 300M;
            docLignes.Add(ligneArticle);


            ligneArticle = new LigneArticle(typeDoc);
            ligneArticle.RefArticle = "CHAOR42";
            ligneArticle.Designation = "chaine maille super super fine (designation provenant du framework)";
            ligneArticle.Quantite = 7;
            ligneArticle.PrixUnitaire = 666.66M;
            docLignes.Add(ligneArticle);

            ligneArticle = new LigneArticle(typeDoc);
            ligneArticle.RefArticle = "GRAVURE";
            ligneArticle.Designation = "Gravure designation fixé à l'insertion du framework";
            ligneArticle.Quantite = 3;
            ligneArticle.PrixUnitaire = 255.75M;
            docLignes.Add(ligneArticle);

            LigneTexte ligneText = new LigneTexte(typeDoc);
            ligneText.Designation = "Blablabla";
            docLignes.Add(ligneText);

            ligneArticle = new LigneArticle(typeDoc);
            ligneArticle.RefArticle = "GRAVURE";
            ligneArticle.Designation = "Gravure designation avec remise";
            ligneArticle.Quantite = 2;
            ligneArticle.PrixUnitaire = 200M;
            ligneArticle.RemiseType1 = RemiseTypeLigne.Pourcentage;
            ligneArticle.RemiseValeur1 = 2;
            docLignes.Add(ligneArticle);

            return docLignes;
        }

        /// <summary>
        /// Méthode de construction d'une ligne de document
        /// </summary>
        /// <param name="typeDoc">Type de document de la ligne</param>
        /// <param name="numDoc">Numéro du document de la ligne</param>
        /// <returns></returns>
        private LigneDocument GetLigne(TypeDocument typeDoc, string numDoc)
        {
            LigneArticle ligneArticle = new LigneArticle(typeDoc);
            ligneArticle.NumeroDocument = numDoc;
            ligneArticle.RefArticle = "BRAAR10";
            ligneArticle.Quantite = 1;
            ligneArticle.PrixUnitaire = 496.8M;
            ligneArticle.RemiseType1 = RemiseTypeLigne.Pourcentage;
            ligneArticle.RemiseValeur1 = 5;
            return ligneArticle;
        }

        /// <summary>
        /// Méthode de construction d'une liste de réglements
        /// </summary>
        /// <returns></returns>
        private List<Reglement> GetReglementList()
        {
            List<Reglement> reglementList = new List<Reglement>();
            Reglement reglement = new Reglement()
            {
                Date = new DateTime(2012, 12, 6),
                IdModeReglement = 1,
                Libelle = "Reglement 1",
                TypeValeur = TypeRepartitionReglement.Montant,
                Valeur = 10
            };
            reglementList.Add(reglement);

            reglement = new Reglement()
            {
                Date = new DateTime(2013, 1, 6),
                IdModeReglement = 1,
                Libelle = "Reglement 2",
                TypeValeur = TypeRepartitionReglement.Montant,
                Valeur = 20
            };
            reglementList.Add(reglement);

            reglement = new Reglement()
            {
                Date = new DateTime(2013, 2, 6),
                IdModeReglement = 1,
                Libelle = "Reglement 3",
                TypeValeur = TypeRepartitionReglement.Pourcentage,
                Valeur = 20
            };
            reglementList.Add(reglement);

            //Réglement d'équilibre
            reglement = new Reglement()
            {
                Date = new DateTime(2013, 3, 6),
                IdModeReglement = 1,
                Libelle = "Reglement 4",
                TypeValeur = TypeRepartitionReglement.Equilibre
            };
            reglementList.Add(reglement);


            return reglementList;
        }
        #endregion

    }
}
