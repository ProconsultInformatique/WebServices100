
using WebServices100.Proxy;

namespace DemoWebServices100.Common
{
    public class UserServiceDemo
    {
        #region Données membre

        private readonly string _webServiceUrl;

        #endregion

        #region Constructeur

        public UserServiceDemo(string webServiceUrl)
        {
            _webServiceUrl = webServiceUrl;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Cette méthode montre comment contrôler que la paire {nom d'utilisateur, mot de passe} soit valide.
        /// </summary>
        public void CheckLoginPassword()
        {
            //Définition des login et mot de passe
            string login = "<Administrateur>";
            string pwd = "";

            UserService service = new UserService(_webServiceUrl);

            //Récupération de la validité de la paire
            bool result = service.CheckUserPassword(login, pwd);

        }

        #endregion
    }
}
