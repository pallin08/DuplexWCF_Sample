using System;
using System.ServiceModel;
using MessageListener.ServiceReference1;

namespace MessageListener
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    class Listener : IMessageCallback, IDisposable
    {
        private MessageClient _messageClient;

        public void Open()
        {
            try
            {
                InstanceContext context = new InstanceContext(this);
                _messageClient = new MessageClient(context, "WSDualHttpBinding_IMessage");
                _messageClient.Subscribe();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void OnMessageSended(string message, DateTime timestamp)
        {
            Console.WriteLine("<<< Recieved {0} with a timestamp of {1}", message, timestamp);
        }

        public void Dispose()
        {
            _messageClient.Unsubscribe();
            _messageClient.Close();
        }

    }
}
