using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DiscoScreen
{
    public static class CustomMenuCommands
    {
        public static readonly RoutedUICommand HideShowMenu = new RoutedUICommand(
            "Hide/Show top menu",
            "Hide",
            typeof(CustomMenuCommands),
            new InputGestureCollection() { new KeyGesture(Key.F1) }
            );
        public static readonly RoutedUICommand CloseApp = new RoutedUICommand(
            "Exit from the app",
            "CloseApp",
            typeof(CustomMenuCommands),
            new InputGestureCollection() { new KeyGesture(Key.F2) }
            );

    }
}
