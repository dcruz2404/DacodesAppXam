using Dacodes.VenadosFC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Players
{
    public static partial class Jugadores
    {
        public static async Task<PlayersV> Get(string authorization)
        {
            PlayersV response = new PlayersV();
            try
            {
                var API = GetConfig.Api();

                var request = await API.GetPlayers();

                if (request != null)
                {
                    response = JsonConvert.DeserializeObject<PlayersV>(request);
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
