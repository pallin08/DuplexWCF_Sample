using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace WcfService
{

    public class Message : IMessage
    {
        private static readonly List<IMessageCallback> subscribers = new List<IMessageCallback>();

        public void SendMessage(string message)
        {
            subscribers.ForEach(delegate(IMessageCallback callback)
            {
                if (((ICommunicationObject)callback).State == CommunicationState.Opened)
                {
                    callback.OnMessageSended(message, DateTime.Now);
                }
                else
                {
                    subscribers.Remove(callback);
                }
            });
        }

        public bool Subscribe()
        {
            try
            {
                IMessageCallback callback = OperationContext.Current.GetCallbackChannel<IMessageCallback>();
                if (!subscribers.Contains(callback))
                    subscribers.Add(callback);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Unsubscribe()
        {
            try
            {
                IMessageCallback callback = OperationContext.Current.GetCallbackChannel<IMessageCallback>();
                if (!subscribers.Contains(callback))
                    subscribers.Remove(callback);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
