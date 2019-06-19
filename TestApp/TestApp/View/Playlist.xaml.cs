using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Playlist : ContentPage
	{
        public TestApp.MainPage sender;
        public Playlist(TestApp.MainPage sender)
        {
            InitializeComponent();
            this.sender = sender;
            string[] playlist = new string[2];
            playlist[0] = "http://tulak.host/songEminem.mp3";
            playlist[1] = "http://tulak.host/songVladko.mp3";
            BindingContext = new ViewModel.Playlist(sender, playlist, Playlists);
        }
    }
}