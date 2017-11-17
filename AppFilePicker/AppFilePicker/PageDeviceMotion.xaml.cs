using DeviceMotion.Plugin;
using DeviceMotion.Plugin.Abstractions;
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
	public partial class PageDeviceMotion : ContentPage
	{
        private bool registering;

        public PageDeviceMotion ()
		{
			InitializeComponent ();
            
        }

        void OnRegister(object sender, EventArgs e)
        {
            if (!registering)
            {
                CrossDeviceMotion.Current.Start(MotionSensorType.Accelerometer, MotionSensorDelay.Default);
                registering = true;
                CrossDeviceMotion.Current.SensorValueChanged += (s, a) =>
                {

                    switch (a.SensorType)
                    {
                        case MotionSensorType.Accelerometer:
                            label_x.Text = ((MotionVector)a.Value).X.ToString();
                            label_y.Text = ((MotionVector)a.Value).Y.ToString();
                            label_z.Text = ((MotionVector)a.Value).Z.ToString();
                            break;
                    }
                };
            }
            else
            {
                CrossDeviceMotion.Current.Stop(MotionSensorType.Accelerometer);
                registering = false;
            }
            //await CrossTextToSpeech.Current.Speak(entry_text.Text);

        }
    }

}