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
        public MainPage sender;

        public PlaylistyViewModel(MainPage sender)
        {
            this.sender = sender;
            DomuClick = new Command(Domu);
            PlaylistyClick = new Command(Playlisty);

        }

        public void Domu()
        {
            sender.RemoveView();
        }
        public void Playlisty()
        {
            //
        }
    }
}
