using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public static class GetConnection
    {
        public static string Url { get; set; }
        public static string EndPoint()
        {
            return Url;
        }
    }
}
