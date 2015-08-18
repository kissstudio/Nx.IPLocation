using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunshine.IPLocation
{
    public class QQWry
    {
        private static IPScanner scanner = new IPScanner();
        public static IpLocation Query(string ipAddress)
        {
            return scanner.Query(ipAddress);
        }
    }
}
