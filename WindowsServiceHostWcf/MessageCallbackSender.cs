using System;
using System.ServiceModel;
using WindowsServiceHostWcf.ServiceReference1;

namespace WindowsServiceHostWcf
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    class MessageCallbackSender : IMessageCallback, IDisposable
    {
        private MessageClient _messageClient;

        public void Run()
        {
            InstanceContext context = new InstanceContext(this);
            _messageClient = new MessageClient(context, "WSDualHttpBinding_IMessage");

            for (int i = 0; i < 5; i++)
            {
                string message = string.Format("message #{0}", i);
                _messageClient.SendMessage(message);
            }
        }

        public void OnMessageSended(string message, DateTime timestamp)
        {
            
        }

        public void Dispose()
        {
            _messageClient.Unsubscribe();
            _messageClient.Close();
        }
    }
}
