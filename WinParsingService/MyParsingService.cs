using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinParsingService
{
    public partial class MyParsingService : ServiceBase
    {
        private ServiceHost _host = null; 
        public MyParsingService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (_host != null) 
                _host.Close();
            _host = new ServiceHost(typeof(ParsingService.ParsingService));
            _host.Open();
        }

        protected override void OnStop()
        {
            if (_host != null)
            {
                _host.Close();
                _host = null;
            }
        }
    }
}
