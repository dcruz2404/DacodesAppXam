using Dacodes.VenadosFC;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenadosTest.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VenadosTest.ViewModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardDel : ContentPage
    {
        public Forward delantero { get; set; }
        public CardDel(Forward _delantero)
        {
            InitializeComponent();
            delantero = _delantero;
            jugadorImg.Source = _delantero.image;
            nombreJ.Text = _delantero.name + " " + _delantero.first_surname + " " + _delantero.second_surname;
        }

        private async void SetDelanteros(object sender, EventArgs e)
        {
            var pr = new PopupPlayers(delantero.image, nombreJ.Text, delantero.position, delantero.birthday.ToString("dd/MM/yyyy"), delantero.birth_place, delantero.weight.ToString(), delantero.height.ToString(), delantero.last_team);
            var scaleAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Center,
                PositionOut = MoveAnimationOptions.Top
            };

            pr.Animation = scaleAnimation;
            await PopupNavigation.PushAsync(pr);
        }
    }
}