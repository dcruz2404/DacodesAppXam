using Dacodes.VenadosFC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Stadistics
{
    public static partial class Estadisticas
    {
        public static async Task<StatisticsV> Get(string authorization)
        {
            StatisticsV response = new StatisticsV();
            try
            {
                var API = GetConfig.Api();

                var request = await API.GetStadistics(authorization);

                if (request != null)
                {
                    response.result = JsonConvert.DeserializeObject<StatisticsV.Result>(request);
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
