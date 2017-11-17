using Plugin.TextToSpeech;
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
    public partial class PageTTS : ContentPage
    {
        public PageTTS()
        {
            InitializeComponent();
        }

        async void Speach(object sender, EventArgs e)
        {
           
            await CrossTextToSpeech.Current.Speak(entry_text.Text);
        }
    }
}