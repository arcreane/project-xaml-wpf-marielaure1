using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace TownCraft.Ui
{
    public partial class MenuUI : Page
    {
        public MenuUI()
        {
            InitializeComponent();
        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            Frame? menuFrame = FindParent<Frame>(this);
            if (menuFrame != null)
            {
                menuFrame.Navigate(new Uri("src/UI/CreateGameUI.xaml", UriKind.Relative));
            }
        }

        private void MenuFrame_Navigated(object sender, NavigationEventArgs e)
        {
            Button? menuBackBtnUI = FindParent<Button>(this);
            if (menuBackBtnUI != null)
            {
                menuBackBtnUI.IsEnabled = (sender as Frame)?.CanGoBack ?? false;
            }
        }

        private T? FindParent<T>(DependencyObject obj) where T : DependencyObject
        {
            DependencyObject? parent = VisualTreeHelper.GetParent(obj);
            while (parent != null && !(parent is T))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }
            return parent as T;
        }
    }
}
