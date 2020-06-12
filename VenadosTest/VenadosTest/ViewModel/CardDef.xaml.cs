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
    public partial class CardDef : ContentPage
    {
        public Defens defens { get; set; }
        public CardDef(Defens _defens)
        {
            InitializeComponent();
            defens = _defens;
            jugadorImg.Source = _defens.image;
            nombreJ.Text = _defens.name + " " + _defens.first_surname + " " + _defens.second_surname;
        }

        private async void SetDefensas(object sender, EventArgs e)
        {
            var pr = new PopupPlayers(defens.image, nombreJ.Text, defens.position, defens.birthday.ToString("dd/MM/yyyy"), defens.birth_place, defens.weight.ToString(), defens.height.ToString(), defens.last_team);
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