using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cllullunaS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2(string dato1 , double dato2)
        {
            InitializeComponent();
            lbldato1.Text = "dato uno " +dato1;
            lbldato2.Text = "dato dos " + dato2.ToString();
        }

        private void btnAbriV3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}