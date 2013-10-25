using System.ServiceModel;

namespace WcfService
{

    [ServiceContract(CallbackContract = typeof(IMessageCallback))]
    public interface IMessage
    {
        [OperationContract]
        void SendMessage(string message);

        [OperationContract]
        bool Subscribe();

        [OperationContract]
        bool Unsubscribe();
    }

}
