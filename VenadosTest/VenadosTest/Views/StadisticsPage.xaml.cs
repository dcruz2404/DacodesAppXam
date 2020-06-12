using Dacodes.VenadosFC;
using Interface.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenadosTest.Helper;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VenadosTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StadisticsPage : ContentPage
    {
        public StatisticsV estadisticas = new StatisticsV();
        public StadisticsPage()
        {
            InitializeComponent();

            StatisticsV estadisticas = JsonConvert.DeserializeObject<StatisticsV>(Settings.Estadisticas);
            StadisticsListView.ItemsSource = estadisticas.result.data.statistics;
        }

        protected void ListItems_Refreshing(object sender, EventArgs e)
        {
            StadisticsListView.IsRefreshing = true;
            Task.Run(async () =>
            {
                await GetEstadisticas();
            });
            StadisticsListView.IsRefreshing = false;
        }
        public async Task GetMarcas()
        {
            Services.GetConnection.Url = "https://venados.dacodes.mx";
            Settings.Patrocinadores = JsonConvert.SerializeObject(Services.Sponsors.Patrocinios.Get("application/json"));
        }
        public async Task GetEstadisticas()
        {
            Services.GetConnection.Url = "https://venados.dacodes.mx";
            estadisticas = await Services.Stadistics.Estadisticas.Get("application/json");
            StadisticsListView.ItemsSource = estadisticas.result.data.statistics;
        }
        public async Task GetJugadores()
        {
            Services.GetConnection.Url = "https://venados.dacodes.mx";
            Settings.Jugadores = JsonConvert.SerializeObject(Services.Players.Jugadores.Get("application/json"));
        }
        public async Task GetNotificaciones()
        {
            Services.GetConnection.Url = "https://venados.dacodes.mx";
            Settings.Notificaciones = JsonConvert.SerializeObject(Services.Notifications.Services.Games.Notificaciones.Get("application/json"));
        }

        public static string GetToken(string concatString)
        {
            return string.Format("Basic {0}", Convert.ToBase64String(Encoding.UTF8.GetBytes(concatString)));
        }
    }
}