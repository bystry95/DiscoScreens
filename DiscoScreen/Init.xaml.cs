using System;
using System.Collections.Generic;
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
using System.Drawing;

namespace DiscoScreen
{
    /// <summary>
    /// Logika interakcji dla klasy Init.xaml
    /// </summary>
    public partial class Init : Window
    {
        public Init()
        {
           InitializeComponent();

            int NumberOfScreens = Screen.AllScreens.Length;
            Screen[] screens = Screen.AllScreens;
            if(NumberOfScreens > 1)
            {
                for(int i = 0; i < NumberOfScreens; i++)
                {
                    MainWindow mw = new MainWindow();
                    Rectangle workArea = screens[i].WorkingArea;
                    int ScreenWidth = screens[i].Bounds.Width;
                    int ScreenHeight = screens[i].Bounds.Height;
                    mw.Top = workArea.Top;
                    mw.Left = workArea.Left;
                    mw.Width = ScreenWidth;
                    mw.Height = ScreenHeight;
                    mw.Show();
                }
            }
        }
    }
}
