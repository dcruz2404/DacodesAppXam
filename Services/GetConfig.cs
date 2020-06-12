using Interface.Interfaces;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Services
{
    public static class GetConfig
    {
        public static IService Api(int seconds = 0)
        {
            if (seconds > 0)
            {
                return RestService.For<IService>(new HttpClient
                {
                    BaseAddress = new Uri(GetConnection.EndPoint()),
                    Timeout = TimeSpan.FromSeconds(seconds),
                    MaxResponseContentBufferSize = long.MaxValue
                });
            }
            else
            {
                return RestService.For<IService>(GetConnection.EndPoint());
            }
        }
    }
}
