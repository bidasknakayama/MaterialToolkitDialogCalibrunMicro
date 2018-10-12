using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialToolkitDialogCalibrunMicro.ViewModels
{
    public class TestDialogViewModel : Conductor<object>
    {
    

        private String _ipAddress;
        public String IpAddress
        {
            get { return _ipAddress; }
            set
            {
                this.Set(ref _ipAddress, value);
            }
        }

        public TestDialogViewModel()
        {
        }
        




    }
}
