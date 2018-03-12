using Plugin.MediaManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JCMuzic
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		}

        private async void PlayPauseClicked(object sender, EventArgs e)
        {

            //await CrossMediaManager.Current.Play("https://raw.githubusercontent.com/martijn00/XamarinMediaManager/develop/Samples/Simple/MediaSample.Core/Media/local-sample.mp3");

            await CrossMediaManager.Current.Play("/sdcard/11.mp3");
        }

        private async void StopButton_OnClicked(object sender, EventArgs e)
        {
            await CrossMediaManager.Current.Stop();
        }
    }
}
