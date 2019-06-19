using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using MediaManager;
using MediaManager.Forms;
using System.Threading.Tasks;

namespace TestApp.ViewModel
{
    class MainWindowViewModel
    {
        public Command DomuClick { get; }
        public Command PlaylistyClick { get; }
        public Command ButtonClick { get; }
        public string SongName { get; set; }
        public string ButtonText { get; set; }
        //bool initialState = true;
        public MainPage sender;
        System.TimeSpan duration;
        public MainWindowViewModel(MainPage sender)
        {
            SongName = "Test song";
            ButtonText = ("pause.png");
            this.sender = sender;
            
            DomuClick = new Command(Domu);
            PlaylistyClick = new Command(Playlisty);
            ButtonClick = new Command(Button);
            CrossMediaManager.Current.Init();
            CrossMediaManager.Current.Play("http://tulak.host/song2.mp3");

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
            CrossMediaManager.Current.PlayPause();
            
        }
    }
}
