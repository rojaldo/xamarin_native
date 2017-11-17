using Plugin.Toasts;
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
    public partial class PageToast : ContentPage
    {
        public PageToast()
        {
            InitializeComponent();
        }

        async void ShowToast(object sender, EventArgs e)
        {
            var notificator = DependencyService.Get<IToastNotificator>();

            var options = new NotificationOptions()
            {
                Title = "Title",
                Description = "Description"
            };

            var result = await notificator.Notify(options);
        }
    }
}