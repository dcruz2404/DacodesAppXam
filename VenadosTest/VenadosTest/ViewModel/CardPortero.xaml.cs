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
    public partial class CardPortero : ContentPage
    {
        public CardPortero()
        {
            InitializeComponent();
        }
        public Goalkeeper portero { get; set; }
        public CardPortero(Goalkeeper _portero) { 
            InitializeComponent();
            portero = _portero;
            jugadorImg.Source = portero.image;
            nombreJ.Text = portero.name + " " + portero.first_surname + " " + portero.second_surname;
        }

        private async void SetPortero(object sender, EventArgs e)
        {
            var pr = new PopupPlayers(portero.image, nombreJ.Text, portero.position, portero.birthday.ToString("dd/MM/yyyy"), portero.birth_place, portero.weight.ToString(), portero.height.ToString(), portero.last_team);
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