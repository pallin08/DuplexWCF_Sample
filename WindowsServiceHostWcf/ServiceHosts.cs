using System.ServiceProcess;
using System.Timers;

namespace WindowsServiceHostWcf
{
    public class ServiceHosts : ServiceBase
    {
        MessageCallbackSender _messageCallbackSender = new MessageCallbackSender();
        private Timer _timer;

        public ServiceHosts()
        {
            ServiceName = "Duplex WCF Service";
            _timer = new Timer();
            _timer.Elapsed += OnTimerElapsed;
            _timer.Interval = 10000;
        }

        protected override void OnStart(string[] args)
        {
            MessageWcfServiceHost.StartWcf();
            _timer.Enabled = true;
        }

        protected override void OnStop()
        {
            MessageWcfServiceHost.StopWcf();
        }

        protected void OnTimerElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            _messageCallbackSender.Run();
            _messageCallbackSender.Dispose();
            _timer.Interval = 10000;
        }
    }
}
