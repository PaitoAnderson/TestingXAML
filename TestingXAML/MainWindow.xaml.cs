using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestingXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region WindowControls
        protected override void OnStateChanged(EventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Maximized)
            {
                MaximizeButton.Visibility = Visibility.Collapsed;
                ChangeViewButton.Visibility = Visibility.Visible;

                // Adjust Window Margin when Maximixed
                WindowMargin.Margin = new Thickness(7);
            }

            if (this.WindowState == System.Windows.WindowState.Normal)
            {
                ChangeViewButton.Visibility = Visibility.Collapsed;
                MaximizeButton.Visibility = Visibility.Visible;

                // Adjust Window Margin when in Normal Mode
                WindowMargin.Margin = new Thickness(15);
            }
        }

        private void CloseButtonMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void MaximizeButtonMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }

        private void ChangeViewButtonMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Normal;
        }

        private void MinimizeButtonMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void DragableGridMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        #endregion
    }
}
