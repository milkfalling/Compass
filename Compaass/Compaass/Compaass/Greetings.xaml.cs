using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Compaass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Greetings : ContentPage
    {
        public Greetings()
        {
            InitializeComponent();

            Label label = new Label();
            label.Text = "GGGGGGGGG";
            this.Content= label;
        }
    }
}