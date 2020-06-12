using Dacodes.VenadosFC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Notifications
{
    namespace Services.Games
    {
        public static partial class Notificaciones
        {
            public static async Task<NotificationsV> Get(string authorization)
            {
                NotificationsV response = new NotificationsV();
                try
                {
                    var API = GetConfig.Api();

                    var request = await API.GetNotifications();

                    if (request != null)
                    {
                        response = JsonConvert.DeserializeObject<NotificationsV>(request); ;
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }

                return response;
            }
        }
    }
}
