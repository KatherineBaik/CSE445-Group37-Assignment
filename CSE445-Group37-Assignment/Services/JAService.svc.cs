using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CSE445_Group37_Assignment.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class JAService : IJAService
    {
        // Work by: Josh Azura
        private static readonly Dictionary<string, string> Users = new Dictionary<string, string>();
        public bool RegisterUser(string username, string encryptedPassword)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(encryptedPassword))
            {
                return false;
            }
            if (Users.ContainsKey(username))
            {
                return false;
            }
            // It hands the job to the service and acts on the answer.
            Users[username] = encryptedPassword;
            return true;
        }
    }
}
