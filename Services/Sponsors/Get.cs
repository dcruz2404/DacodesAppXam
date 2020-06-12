using Dacodes.VenadosFC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Sponsors
{
    public static partial class Patrocinios
    {
        public static async Task<SponsorsV> Get(string authorization)
        {
            SponsorsV response = new SponsorsV();
            try
            {
                var API = GetConfig.Api();

                var request = await API.GetSponsors();

                if (request != null)
                {
                    response = JsonConvert.DeserializeObject<SponsorsV>(request);
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
