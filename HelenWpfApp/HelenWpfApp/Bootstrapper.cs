using HelenWpfApp.ViewModels;
using System.Windows;
using Caliburn.Micro;

namespace HelenWpfApp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();

        }

        //Start app from here, override bootstrapperbase method and run our code 
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
