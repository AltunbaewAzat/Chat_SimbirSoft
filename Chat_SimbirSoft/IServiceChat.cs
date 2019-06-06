using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Chat_SimbirSoft
{   
    [ServiceContract]
    public interface IServiceChat
    {
        [OperationContract]
        int  ConnectServer();

        [OperationContract]
        void DisconnectServer(int id);

        [OperationContract(IsOneWay = true)]
        void Message(string message);
    }
}
