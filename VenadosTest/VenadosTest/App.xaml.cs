using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using VenadosTest.Helper;
using VenadosTest.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VenadosTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Task.Run(async () => { await ExecuteAPI(); }).Wait();
            MainPage = new VenadosTest.Views.VenadosMDP();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        public async Task ExecuteAPI()
        {
            await GetEstadisticas();
            await GetJuegos();
            await GetJugadores();
        }
        public async Task GetJuegos()
        {
            Services.GetConnection.Url = "https://venados.dacodes.mx";
            var juegos = await Services.Games.Juegos.Get("application/json");
            Settings.Juegos = JsonConvert.SerializeObject(juegos);
        }
        public async Task GetMarcas()
        {
            Services.GetConnection.Url = "https://venados.dacodes.mx";
            Settings.Patrocinadores = JsonConvert.SerializeObject(Services.Sponsors.Patrocinios.Get("application/json"));
        }
        public async Task GetEstadisticas()
        {
            Services.GetConnection.Url = "https://venados.dacodes.mx";
            var estadisticas = await Services.Stadistics.Estadisticas.Get("application/json");
            Settings.Estadisticas = JsonConvert.SerializeObject(estadisticas);
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
    }
}
