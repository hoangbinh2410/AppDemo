using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class User : TabbedPage
    {
        public User()
        {
            InitializeComponent();
        }
        private async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            int tapCount = 0;
            var imageSender = (Image)sender;
            // watch the monkey go from color to black&white!
            if (tapCount % 1 == 0)
            {
                await Navigation.PushModalAsync(new Login(), false);
            }

        }
    }
}