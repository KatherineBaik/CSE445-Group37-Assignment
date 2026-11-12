using System;
using System.ServiceModel;

namespace CSE445_Group37_Assignment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface KBService
    {
        // Work by: Katherine Baik
        [OperationContract]
        bool AuthenticateUser(string username, string password);

        // Work by: Katherine Baik
        [OperationContract]
        bool AuthenticateStaff(string username, string password);

    }
}
