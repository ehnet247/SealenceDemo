using SealenceDemo.Interfaces;
using SealenceDemo.ViewModels;
using System.Diagnostics;
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

namespace SealenceDemo.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var vmWinch1 = winch1.DataContext as IWinchViewModel;
            //if (vmWinch1 != null)
            //{
            //    vmWinch1.Title = "Winch 1";
            //}

            //var vmWinch2 = winch2.DataContext as IWinchViewModel;
            //if (vmWinch2 != null)
            //{
            //    vmWinch2.Title = "Winch 2";
            //}

            //var vmWinch3 = winch3.DataContext as IWinchViewModel;
            //if (vmWinch3 != null)
            //{
            //    vmWinch3.Title = "Winch 3";
            //}

            //var vmWinch4 = winch4.DataContext as IWinchViewModel;
            //if (vmWinch4 != null)
            //{
            //    vmWinch4.Title = "Winch 4";
            //}
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Main window loaded");
        }
    }
}