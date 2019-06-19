using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TestApp.ViewModel
{
    class PlaylistyViewModel
    {
        public Command DomuClick { get; }
        public Command PlaylistyClick { get; }
        public Command ButtonClick { get; }
        public string ButtonText { get; }
        public string[] playlist { get; }
        public MainPage sender;

        public PlaylistyViewModel(MainPage sender)
        {
            this.sender = sender;
            DomuClick = new Command(Domu);
            PlaylistyClick = new Command(Playlisty);
            ButtonClick = new Command(Play);
            ButtonText = "Playlist1";
            playlist = new string[2];
            playlist[0] = "http://tulak.host/song2.mp3";
            playlist[1] = "http://tulak.host/songVladko.mp3";
        }
        public void Play()
        {
            //MediaManager.CrossMediaManager.Current.Play(playlist);
            sender.ChangeView(new View.Playlist(sender));
        }
        public void Domu()
        {
            sender.RemoveView();
        }
        public void Playlisty()
        {
            
        }
    }
}
