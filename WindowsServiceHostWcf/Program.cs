using System.ServiceProcess;

namespace WindowsServiceHostWcf
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
			{ 
				new ServiceHosts() 
			};
            ServiceBase.Run(ServicesToRun);
        }
    }
}
