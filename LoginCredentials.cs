using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCookingApp
{
    public class LoginCredentials
    {
        private Dictionary<string, string> credentials;

        public LoginCredentials()
        {
            credentials = new Dictionary<string, string>();
            // Default credentials
            credentials["admin"] = "admin";
            credentials["deepa"] = "student";
        }

        public bool ValidateCredentials(string userName, string password)
        {
            return credentials.ContainsKey(userName) && credentials[userName] == password;
        }

        public Dictionary<string, string> GetCredentials()
        {
            return new Dictionary<string, string>(credentials);
        }

        public void SetCredentials(string userName, string password)
        {
            credentials[userName] = password;
        }
    }
}
