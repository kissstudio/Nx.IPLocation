using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Sunshine.Internal
{
    public static class StreamExtensions
    {
        public static MemoryStream ToMemorySteam(this Stream stream)
        {
            var ms = new MemoryStream();
            var sr = new StreamReader(stream);
            var buffer = new byte[1024];
            var len = 0;
            while ((len = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                ms.Write(buffer, 0, len);
            }
            sr = null;
            return ms;
        }
    }
}
