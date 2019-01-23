using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppContext.TryGetSwitch("Switch.System.ServiceModel.DisableCngCertificates", out bool isEnabled);
        }
    }
}
