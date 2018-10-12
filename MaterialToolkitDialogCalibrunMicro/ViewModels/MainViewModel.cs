using Caliburn.Micro;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MaterialToolkitDialogCalibrunMicro.ViewModels
{
    public class MainViewModel : Conductor<object>
    {
        protected override void OnActivate()/* OK */
        {
            base.OnActivate();
            



        }
        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);

            


        }
        public async void NewConnection()
        {

            var result = await DialogHost.Show(
                new UserControl { DataContext = new TestDialogViewModel() }, "MainDialogHost");
           
        }
    }
}
