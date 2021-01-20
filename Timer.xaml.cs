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
using System.Windows.Threading;

namespace Timer_App
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

        private void timerFoo(object sender, EventArgs e)
        {
            DispatcherTimer disTimer = new DispatcherTimer();
            disTimer.Interval = new TimeSpan(0,0,1);
            disTimer.Tick += new EventHandler(startButton_Click);
            disTimer.Start();
            return;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timerFoo(sender, e);
            label.Content = DateTime.Now.ToString();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
