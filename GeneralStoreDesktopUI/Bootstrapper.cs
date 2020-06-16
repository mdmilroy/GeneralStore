using Caliburn.Micro;
using GeneralStoreDesktopUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GeneralStoreDesktopUI
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // On startup, load ShellViewModel as the base view, which will launch the View; similar to Startup-URI.
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
