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
    public partial class PopupPlayers
    {
        public PopupPlayers(string sfoto, string snombre, 
            string sposicion, string sfechanac, 
            string slugarnac, string speso, 
            string saltura, string sequipopasado)
        {
            InitializeComponent();
            foto.Source = sfoto;
            nombre.Text = snombre;
            posicion.Text = sposicion;
            fechanac.Text = sfechanac;
            lugarnac.Text = slugarnac;
            peso.Text = speso;
            altura.Text = saltura;
            equipopasado.Text = sequipopasado;
        }
    }
}