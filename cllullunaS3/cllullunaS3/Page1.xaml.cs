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
    public partial class Page1 : ContentPage
    {
        public Page1( )
        {
            InitializeComponent();
        }

        private void btnabrir_Clicked(object sender, EventArgs e)
        {
            string  dato1 =Convert.ToString( txtdato1.Text);
            double dato2 =Convert.ToDouble( txtdato2.Text);
            Navigation.PushAsync(new Page2(dato1 , dato2)); 
        }
    }
}