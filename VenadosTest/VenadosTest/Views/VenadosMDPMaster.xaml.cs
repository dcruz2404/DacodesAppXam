using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VenadosTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VenadosMDPMasterMaster : ContentPage
    {
        public ListView ListView;
        public VenadosMDPMasterMaster()
        {
            InitializeComponent();
            ListView = MenuItemsListView;
        }
    }
}