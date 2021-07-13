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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace fuçando
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    
    public partial class MainWindow : Window
    {

        Core.colors cor = new Core.colors();

        Page pag = new Page();

        public MainWindow()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            bt1.Foreground = cor.getcorlb();
            bt1.Background = cor.getcoron();
            bt2.Background = cor.getcoroff();
            bt3.Background = cor.getcoroff();

            bt1.Padding = new Thickness(40, 0, 0, 0);
            bt2.Padding = new Thickness(20, 0, 0, 0);
            bt3.Padding = new Thickness(20, 0, 0, 0);


            pnprinc.Content = new automa();

        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            bt1.Foreground = cor.getcorlb();
            bt2.Foreground = Brushes.Black;
            bt3.Foreground = Brushes.Black;

            bt1.Background = cor.getcoron();
            bt2.Background = cor.getcoroff();
            bt3.Background = cor.getcoroff();

            bt1.Padding = new Thickness(40, 0, 0, 0);
            bt2.Padding = new Thickness(20, 0, 0, 0);
            bt3.Padding = new Thickness(20, 0, 0, 0);

            pnprinc.Content = new automa();

        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            bt1.Foreground = Brushes.Black;
            bt3.Foreground = Brushes.Black;
            bt2.Foreground = cor.getcorlb();

            bt1.Background = cor.getcoroff();
            bt2.Background = cor.getcoron();
            bt3.Background = cor.getcoroff();

            bt1.Padding = new Thickness(20, 0, 0, 0);
            bt2.Padding = new Thickness(40, 0, 0, 0);
            bt3.Padding = new Thickness(20, 0, 0, 0);

            pnprinc.Content = new sup();

        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            bt1.Foreground = Brushes.Black;
            bt2.Foreground = Brushes.Black;
            bt3.Foreground = cor.getcorlb();

            bt1.Background = cor.getcoroff();
            bt2.Background = cor.getcoroff();
            bt3.Background = cor.getcoron();

            bt1.Padding = new Thickness(20, 0, 0, 0);
            bt2.Padding = new Thickness(20, 0, 0, 0);
            bt3.Padding = new Thickness(40, 0, 0, 0);

            pnprinc.Content = new relat();
        }

    }
}
