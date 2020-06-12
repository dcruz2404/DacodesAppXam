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
    public partial class CardMed : ContentPage
    {
        public Center medios { get; set; }
        public CardMed(Center _medios)
        {
            InitializeComponent();
            medios = _medios;
            jugadorImg.Source = _medios.image;
            nombreJ.Text = _medios.name + " " + _medios.first_surname + " " + _medios.second_surname;
        }

        private async void SetDelanteros(object sender, EventArgs e)
        {
            var pr = new PopupPlayers(medios.image, nombreJ.Text, medios.position, medios.birthday.ToString("dd/MM/yyyy"), medios.birth_place, medios.weight.ToString(), medios.height.ToString(), medios.last_team);
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