using Dacodes.VenadosFC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenadosTest.Helper;
using VenadosTest.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VenadosTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayersPage : ContentPage
    {
        public PlayersPage()
        {
            InitializeComponent();
        }

        public void SetDel(PlayersV players)
        {
            foreach(var del in players.result.data.team.forwards)
            {
                var card = new CardDel(del);
                delanteros.Children.Add(card.Content);
            }

        }

        public async void SetMed(PlayersV players)
        {
            foreach (var med in players.result.data.team.centers)
            {
                var card = new CardMed(med);
                medios.Children.Add(card.Content);
            }
        }

        public async void SetDef(PlayersV players)
        {
            foreach (var def in players.result.data.team.defenses)
            {
                var card = new CardDef(def);
                medios.Children.Add(card.Content);
            }
        }

        public async void SetGoalKeeper(PlayersV players)
        {
            foreach (var keeper in players.result.data.team.goalkeepers)
            {
                var card = new CardPortero(keeper);
                medios.Children.Add(card.Content);
            }
        }

        public async void SetCouch(PlayersV players)
        {
            foreach (var coaches in players.result.data.team.coaches)
            {
                var card = new CardPlayer(coaches);
                medios.Children.Add(card.Content);
            }
        }

        private void ButtonLoad_Clicked(object sender, EventArgs e)
        {
            PlayersV players = JsonConvert.DeserializeObject<PlayersV>(Settings.Jugadores);
            SetDel(players);
            SetMed(players);
            SetDef(players);
            SetGoalKeeper(players);
            SetCouch(players);
            buttonLoad.IsVisible = false;
        }
    }
}