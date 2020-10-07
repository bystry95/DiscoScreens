using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DiscoScreen
{
    public partial class MainWindow : Window
    {
        private int interval;
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Tick += ChangeBackground;
            timer.Start();
        }

        private void ChangeBackground(object sender, EventArgs e)
        {
            if (MainTextBlock.Background == Brushes.Red)
            {
                MainTextBlock.Background = Brushes.Green;
            }
            else if (MainTextBlock.Background == Brushes.Green)
            {
                MainTextBlock.Background = Brushes.Blue;
            }
            else if (MainTextBlock.Background == Brushes.Blue)
            {
                MainTextBlock.Background = Brushes.Red;
            }
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            if (topmenu.Visibility == Visibility.Collapsed)
                topmenu.Visibility = Visibility.Visible;
            else
                topmenu.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool successParse = int.TryParse(intervalbox.Text, out interval);
            if (successParse)
            {
                if (interval == 0)
                    timer.Interval = TimeSpan.FromMilliseconds(50);
                else
                    timer.Interval = TimeSpan.FromMilliseconds(interval);
                timer.Start();
            }
        }
    }
}
