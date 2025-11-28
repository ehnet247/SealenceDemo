using CommunityToolkit.Mvvm.ComponentModel;
using SealenceDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SealenceDemo.ViewModels
{
    public partial class WinchViewModel : ObservableRecipient, IWinchViewModel
    {
        [ObservableProperty]
        private string title = "Winch ?";
        [ObservableProperty]
        private float payedOut = 0;
        partial void OnPayedOutChanged(float value)
        {
            PayedOutText = value.ToString() + "m";
        }
        [ObservableProperty]
        private string payedOutText = "0m";
        [ObservableProperty]
        private float load = 0;
        partial void OnLoadChanged(float value)
        {
            LoadText = value.ToString() + "T";
        }
        [ObservableProperty]
        private string loadText = "0T";
        [ObservableProperty]
        private float speed = 0;
        partial void OnSpeedChanged(float value)
        {
            SpeedText = value.ToString() + "m/min";
        }
        [ObservableProperty]
        private string speedText = "0m/min";

        public WinchViewModel()
        {
        }
    }
}
