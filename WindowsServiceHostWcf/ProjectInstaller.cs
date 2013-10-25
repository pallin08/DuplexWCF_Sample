using System.ComponentModel;
using System.ServiceProcess;

namespace WindowsServiceHostWcf
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        private ServiceProcessInstaller process;
        private ServiceInstaller service;

        public ProjectInstaller()
        {
            InitializeComponent();
            process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.LocalSystem;
            service = new ServiceInstaller();
            service.StartType = ServiceStartMode.Automatic;
            service.ServiceName = "Duplex WCF Service";
            service.Description = "Duplex WCF Service";
            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
