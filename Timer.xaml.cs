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
        DispatcherTimer disTimer = new DispatcherTimer();       //datum und Uhrzeit
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private bool timerStarted = false;                      //bool für start-stopp bedingung festzulegen

        private void timerStart(object sender, EventArgs e)     //eventmethode? start
        {

            disTimer.Interval = new TimeSpan(0,0,1);            //definiere angezeigtes zeitintervall
            disTimer.Tick += new EventHandler(startButton_Click); //subscribe .tick an event handler
            disTimer.Start();                                       //starte timer
                
            timerStarted = true;                                //setze bool auf true für stopp-bed

            return;
        }

        private void timerStop(object sender, EventArgs e)
        {
            disTimer.Interval = new TimeSpan(0, 0, 1);
            disTimer.Tick += new EventHandler(stopButton_Click);
            disTimer.Stop();

            timerStarted = false;

            return;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timerStart(sender, e);
            label.Content = DateTime.Now.ToString();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if(timerStarted == true)
            {
                try
                {
                    timerStop(sender, e);
                    MessageBox.Show("Timer stopped!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }
    }
}
