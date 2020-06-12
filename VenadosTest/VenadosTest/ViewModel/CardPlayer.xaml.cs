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
    public partial class CardPlayer : ContentPage
    {
        public Coach dirtecnico { get; set; }
        public CardPlayer(Coach _dirtecnico)
        {
            InitializeComponent();
            dirtecnico = _dirtecnico;
            jugadorImg.Source = dirtecnico.image;
            nombreJ.Text = dirtecnico.name + " " + dirtecnico.first_surname + " " + dirtecnico.second_surname;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var pr = new PopupPlayers(dirtecnico.image, nombreJ.Text, dirtecnico.role, dirtecnico.birthday.ToString("dd/MM/yyyy"), dirtecnico.birth_place, dirtecnico.weight.ToString(), dirtecnico.height.ToString(), "");
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