using Dacodes.VenadosFC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Games
{
    public static partial class Juegos
    {
        public static async Task<GamesV> Get(string authorization)
        {
            GamesV response = new GamesV();
            try
            {
                var API = GetConfig.Api();

                var request = await API.GetGames(authorization);

                if (request != null)
                {
                    response.result = JsonConvert.DeserializeObject<GamesV.Result>(request);
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
