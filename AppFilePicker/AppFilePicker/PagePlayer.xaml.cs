using Plugin.FilePicker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.FilePicker.Abstractions;
using Plugin.SimpleAudioPlayer.Abstractions;
using Xamarin.Forms.Internals;
using System.IO;

namespace AppFilePicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePlayer : ContentPage
    {
        private FileData fileData;
        private ISimpleAudioPlayer player;
        private bool playing;

        public PagePlayer()
        {
            InitializeComponent();
        }
        async void PickFile(object sender, EventArgs e)
        {

            fileData = await CrossFilePicker.Current.PickFile();
            byte[] aux = fileData.DataArray;
            player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load(new MemoryStream(aux));
        }
        void PlayPause(object sender, EventArgs e)
        {
            if (playing == false)
            {
                player.Play();
                playing = true;
            }
            else
            {
                player.Pause();
                playing = false;
            }
            
        }
    }
}