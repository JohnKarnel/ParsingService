using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace WinParsingService
{
    [RunInstaller(true)]
    public partial class ParsingServiceInstaller : System.Configuration.Install.Installer
    {
        public ParsingServiceInstaller()
        {
            //InitializeComponent();
            serviceProcessInstaller1 = new ServiceProcessInstaller();
            serviceProcessInstaller1.Account = ServiceAccount.LocalSystem;
            serviceInstaller1 = new ServiceInstaller();
            serviceInstaller1.ServiceName = "WinParsingService";
            serviceInstaller1.DisplayName = "WinParsingService";
            serviceInstaller1.Description = "WCF Service Hosted by Windows NT Service";
            serviceInstaller1.StartType = ServiceStartMode.Manual;
            Installers.Add(serviceProcessInstaller1);
            Installers.Add(serviceInstaller1);
        }
    }
}
