using Avaya.ClientServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreezeClientSDK
{
    class UserNamePasswordCredentialProvider : ICredentialProvider
    {
        public UserNamePasswordCredentialProvider(String username, String password, String domain = "")
        {
            Username = username;
            Password = password;
            Domain = domain;

        }
        public void OnAuthenticationChallenge(Challenge challenge, CredentialCallback credentialCallback)
        {
            Console.WriteLine("Challenge SIP");
            if (challenge.FailureCount > 0)
            {
                Console.WriteLine("Credenciales Rechazadas");
                // This is credential request after login failure.
                return;
            }

            //Create the credential based on Username and Password
            UserCredential credential = new UserCredential(Username, Password, Domain, "");
            credentialCallback(credential);

        }
        public void OnCredentialAccepted(Challenge challenge)
        {
            Console.WriteLine("Credenciales Aceptadas");
        }
        public void OnAuthenticationChallengeCancelled(Challenge challenge)
        {
        }

        /// <summary>
        /// The username for the credential.
        /// </summary>
        public String Username;

        /// <summary>
        /// The password for the credential.
        /// </summary>
        public String Password;

        /// <summary>
        /// The domain for the credential.
        /// </summary>
        public String Domain;
    }
}
