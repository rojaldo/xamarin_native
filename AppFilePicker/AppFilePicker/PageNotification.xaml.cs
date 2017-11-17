using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFilePicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageNotification : ContentPage
    {
        public PageNotification()
        {
            InitializeComponent();
        }

        async void ShowNotification(object sender, EventArgs e)
        {
            CrossLocalNotifications.Current.Show("title", "body");
        }
    }
}