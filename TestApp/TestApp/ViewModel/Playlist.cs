using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TestApp.ViewModel
{
	public class Playlist 
	{
        public Command DomuClick { get; }
        public Command PlaylistyClick { get; }
        public Command ButtonClick { get; }
        public ICommand PlayClick { get; } //Command akceptující parametr
        public string SongName { get; set; }
        public string PlaylistName { get; set; }
        public string ButtonText { get; set; }
        //bool initialState = true;
        public MainPage sender;
        string[] playlist;
        public Playlist(MainPage sender, string[] playlist, Xamarin.Forms.StackLayout parent)
        {
            PlaylistName = "Eminem&Vladko";
            ButtonText = ("Play/Pause");
            this.sender = sender;
            this.playlist = playlist;

            DomuClick = new Command(Domu);
            PlaylistyClick = new Command(Playlisty);
            ButtonClick = new Command(Button);
            PlayClick = new Command<string>(Play);

            foreach(string s in playlist)
            {
                var song = new Button()
                {
                    Text = s,
                    Command = PlayClick,
                    CommandParameter = s
                };
                parent.Children.Add(song);
            }

        //    CrossMediaManager.Current.Init();
        //    CrossMediaManager.Current.Play("http://tulak.host/song2.mp3");

        }

        public void Domu()
        {
            //
        }
        public void Playlisty()
        {
            sender.ChangeView(new View.Playlisty(sender));
        }
        public void Button()
        {
            //CrossMediaManager.Current.PlayPause();

        }
        public void Play(string song)
        {
            MediaManager.CrossMediaManager.Current.Play(playlist);
            for(int i = 0; i < Array.IndexOf(playlist, song); i++)
            {
                MediaManager.CrossMediaManager.Current.PlayNext();
            }
            
        }
    }
}