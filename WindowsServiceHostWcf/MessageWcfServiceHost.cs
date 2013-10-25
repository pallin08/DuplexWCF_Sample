using System.ServiceModel;
using WcfService;

namespace WindowsServiceHostWcf
{
    internal class MessageWcfServiceHost
    {
         static ServiceHost _serviceHost;

         internal static void StartWcf()
         {
             if (_serviceHost != null)
             {
                 _serviceHost.Close();
             }

             _serviceHost = new ServiceHost(typeof(Message));

             _serviceHost.Open();
         }


         internal static void StopWcf()
         {
             if (_serviceHost != null)
             {
                 _serviceHost.Close();
                 _serviceHost = null;
             }
         }

    }
}
