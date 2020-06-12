using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VenadosTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VenadosMDP : MasterDetailPage
    {
        public List<VenadosMDPMenuItem> MenuItems { get; set; }

        public VenadosMDP()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            MenuItems = new List<VenadosMDPMenuItem>(new[]
            {
                new VenadosMDPMenuItem { Id = 0, Title = "Estadisticas", IconSource = "stadium.png", TargetType = typeof(StadisticsPage) },
                new VenadosMDPMenuItem { Id = 1, Title = "Juegos", IconSource = "soccerball.png", TargetType = typeof(GamesPage)},
                new VenadosMDPMenuItem { Id = 2, Title = "Jugadores", IconSource = "soccer.png", TargetType = typeof(PlayersPage)}
            });
            MasterPage.ListView.ItemsSource = MenuItems;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(StadisticsPage)));
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as VenadosMDPMenuItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                MasterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
            IsPresented = false;
        }
    }
}