using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio12.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaksView : ContentPage
    {
        public TaksView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.TaskViewModel();
        }
    }
}