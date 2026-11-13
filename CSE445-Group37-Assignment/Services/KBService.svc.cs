using System;
using System.Collections.Generic;
using CSE445_KBUtilities;

namespace CSE445_Group37_Assignment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class KBService1 : KBService
    {
        // Work by: Katherine Baik
        // If the username and password match up with the database, returns session cookie
        // If not, returns empty string
        public bool AuthenticateUser(string username, string password)
        {
            if(username == null || password == null) return false;
            
            // encrypt the password
            string encryptedPassword = KBUtilities.EncryptString(password, secretKey);
            if (UserAccounts.ContainsKey(username) && UserAccounts[username] == encryptedPassword)
            {
                return true;
            }

            return false;
        }

        // Work by: Katherine Baik
        // If the username and password match up with the database, returns session cookie
        // If not, returns empty string
        public bool AuthenticateStaff(string username, string password)
        {
            if (username == null || password == null) return false;

            // encrypt the password
            string encryptedPassword = KBUtilities.EncryptString(password, secretKey);
            if (StaffAccounts.ContainsKey(username) && StaffAccounts[username] == encryptedPassword)
            {
                return true;
            }

            return false;
        }

        // Work by: Katherine Baik
        // Service to expose DLL functions
        public string EncryptString(string input, string key)
        {
            return KBUtilities.EncryptString(input, key);
        }

        // Work by: Katherine Baik
        // Service to expose DLL functions
        public string DecryptString(string input, string key)
        {
            return KBUtilities.DecryptString(input, key);
        }


        // Hard-coded values (needs to be removed later / moved elsewhere)
        private Dictionary<string, string> UserAccounts;
        private Dictionary<string, string> StaffAccounts;

        private const string secretKey = "YAHAHA";

        // Constructor to add user accounts
        KBService1()
        {
            UserAccounts = new Dictionary<string, string>();
            StaffAccounts = new Dictionary<string, string>();

            UserAccounts["user1"] = KBUtilities.EncryptString("password", secretKey);
            UserAccounts["user2"] = KBUtilities.EncryptString("ilikechickennuggets", secretKey);
            UserAccounts["user3"] = KBUtilities.EncryptString("abc123", secretKey);

            StaffAccounts["TA"] = KBUtilities.EncryptString("Cse445!", secretKey);
        }
    }
}
