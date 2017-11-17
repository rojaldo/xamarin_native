using Plugin.FilePicker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppFilePicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        async void GoToFilePicker(object sender, EventArgs e) {
            await Navigation.PushAsync(new PageFilePicker());
        }

        async void GoToToast(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageToast());
        }

        async void GoToNotification(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageNotification());
        }

        async void GoToTTS(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageTTS());
        }
        async void GoToPlayer(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagePlayer());
        }
        async void GoToDeviceMotion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageDeviceMotion());
        }

        

    }
}
