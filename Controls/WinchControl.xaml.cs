using SealenceDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SealenceDemo.Controls
{
    /// <summary>
    /// Interaction logic for WinchControl.xaml
    /// </summary>
    public partial class WinchControl : UserControl
    {
        public WinchControl(IWinchViewModel winchViewModel)
        {
            InitializeComponent();
            if (winchViewModel != null)
                this.DataContext = winchViewModel;
        }
        public WinchControl()
        {
            InitializeComponent();
        }
    }
}
