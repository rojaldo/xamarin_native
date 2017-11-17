using Plugin.FilePicker;
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
    public partial class PageFilePicker : ContentPage
    {
        public PageFilePicker()
        {
            InitializeComponent();
            
        }

        void OpenFP(object sender, EventArgs e)
        {
            CrossFilePicker.Current.PickFile();
        }
    }
}