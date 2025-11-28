using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SealenceDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.Text;

namespace SealenceDemo.ViewModels
{
    partial class MainViewModel : ObservableRecipient
    {
        public IWinchViewModel? Winch1ViewModel { get; set; }
        public IWinchViewModel? Winch2ViewModel { get; set; }
        public IWinchViewModel? Winch3ViewModel { get; set; }
        public IWinchViewModel? Winch4ViewModel { get; set; }

        private bool _simulateGrowth = true;
        private int _growthCounter = 10;
        private readonly Timer? _dataSimulationTimer;
        [ObservableProperty]
        private bool enableSimulation = false;
        partial void OnEnableSimulationChanged(bool value)
        {
            if (EnableSimulation)
                SimulateButtonText = "Stop simulation";
            else
                SimulateButtonText = "Start simulation";
        }
        [ObservableProperty]
        private string simulateButtonText = "Start simulation";

        public MainViewModel()
        {
            _dataSimulationTimer = new Timer(OnTimerElapsed);
            _dataSimulationTimer.Change(1000, 1000);
            if (Winch1ViewModel == null)
            {
                Winch1ViewModel = new WinchViewModel();
                Winch1ViewModel.Title = "Winch 1";
            }
            if (Winch2ViewModel == null)
            {
                Winch2ViewModel = new WinchViewModel();
                Winch2ViewModel.Title = "Winch 2";
            }
            if (Winch3ViewModel == null)
            {
                Winch3ViewModel = new WinchViewModel();
                Winch3ViewModel.Title = "Winch 3";
            }
            if (Winch4ViewModel == null)
            {
                Winch4ViewModel = new WinchViewModel();
                Winch4ViewModel.Title = "Winch 4";
            }
        }

        private void OnTimerElapsed(object o)
        {
            if (EnableSimulation)
            {
                _growthCounter--;
                if (_growthCounter == 0)
                {
                    _simulateGrowth = !_simulateGrowth;
                    _growthCounter = 10;
                }

                if (_simulateGrowth)
                {
                    Winch1ViewModel!.PayedOut += 0.1f;
                    Winch1ViewModel!.Load += 0.5f;
                    Winch1ViewModel!.Speed += 0.3f;
                    Winch2ViewModel!.PayedOut += 0.1f;
                    Winch2ViewModel!.Load += 0.5f;
                    Winch2ViewModel!.Speed += 0.3f;
                    Winch3ViewModel!.PayedOut += 0.1f;
                    Winch3ViewModel!.Load += 0.5f;
                    Winch3ViewModel!.Speed += 0.3f;
                    Winch4ViewModel!.PayedOut += 0.1f;
                    Winch4ViewModel!.Load += 0.5f;
                    Winch4ViewModel!.Speed += 0.3f;
                }
                else
                {
                    Winch1ViewModel!.PayedOut -= 0.1f;
                    Winch1ViewModel!.Load -= 0.5f;
                    Winch1ViewModel!.Speed -= 0.3f;
                    Winch2ViewModel!.PayedOut -= 0.1f;
                    Winch2ViewModel!.Load -= 0.5f;
                    Winch2ViewModel!.Speed -= 0.3f;
                    Winch3ViewModel!.PayedOut -= 0.1f;
                    Winch3ViewModel!.Load -= 0.5f;
                    Winch3ViewModel!.Speed -= 0.3f;
                    Winch4ViewModel!.PayedOut -= 0.1f;
                    Winch4ViewModel!.Load -= 0.5f;
                    Winch4ViewModel!.Speed -= 0.3f;
                }
            }
        }
    }
}
