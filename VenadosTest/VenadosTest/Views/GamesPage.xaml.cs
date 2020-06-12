using Dacodes.VenadosFC;
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
    public partial class GamesPage : ContentPage
    {
        public GamesV juegos = new GamesV();
        public static string DAY_FORMAT = "{0:dddd}";
        public static string DAYNAME_FORMAT = "{0:MMMM}";
        public GamesPage()
        {
            InitializeComponent();
            GamesV juegos = JsonConvert.DeserializeObject<GamesV>(Settings.Juegos);
            GamesListView.ItemsSource = juegos.result.data.games.Where(x => x.league == "Copa MX");
        }

        public async Task GetJuegos()
        {
            Services.GetConnection.Url = "https://venados.dacodes.mx";
            juegos = await Services.Games.Juegos.Get("application/json");
            GamesListView.ItemsSource = juegos.result.data.games;
        }

        private void ButtonCopa_Clicked(object sender, EventArgs e)
        {
            GamesV juegos = JsonConvert.DeserializeObject<GamesV>(Settings.Juegos);
            GamesListView.ItemsSource = juegos.result.data.games.Where(x => x.league == "Copa MX");
        }

        private void LigaCopa_Clicked(object sender, EventArgs e)
        {
            GamesV juegos = JsonConvert.DeserializeObject<GamesV>(Settings.Juegos);
            GamesListView.ItemsSource = juegos.result.data.games.Where(x => x.league == "Ascenso MX");
        }
    }
}