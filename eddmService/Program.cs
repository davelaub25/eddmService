using System.ServiceProcess;

namespace eddmService
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new eddmService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}