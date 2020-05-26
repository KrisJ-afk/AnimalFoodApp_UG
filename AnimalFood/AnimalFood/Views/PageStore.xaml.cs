using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimalFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageStore : ContentPage
    {
        public PageStore()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
    }
}