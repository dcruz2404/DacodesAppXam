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
    public partial class LoadPage : ContentPage
    {
        public LoadPage()
        {
            InitializeComponent();
            PlayersV players = JsonConvert.DeserializeObject<PlayersV>(Settings.Jugadores);
            ListViewFordward.ItemsSource = players.result.data.team.forwards;
        }

        private async void ButtonScan_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MasterDetailPage()
            {
                Master = new VenadosMDPMasterMaster() { Title = "Venados F.C." },
                Detail = new NavigationPage(new StadisticsPage())
            });
        }
    }
}