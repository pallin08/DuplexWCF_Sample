using System;
using System.ServiceModel;

namespace WcfService
{
    interface IMessageCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnMessageSended(string message, DateTime timestamp);
    }
}
