using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
        DispatcherTimer newTimer = new DispatcherTimer();       //datum und Uhrzeit
        public MainWindow()
        {
            InitializeComponent();

            newTimer.Tick += new EventHandler(startButton_Click);                 //subscribe .tick an event handler
            newTimer.Interval = TimeSpan.FromMilliseconds(1000);                  //timespan
        }

        //Timer
        private bool timerStarted = false;                      //bool für start-stopp bedingung festzulegen
        
        private void timerStart(object sender, EventArgs e)     //eventmethode? start
        {
            newTimer.Start();                                       //starte timer

            timerStarted = true;                                //setze bool auf true für stopp-bed

            return;
        }

        private void timerStop()
        {
            //definiere angezeigtes zeitintervall
            newTimer.Stop();

            timerStarted = false;

            return;
        }

        //Buttons
        private void startButton_Click(object sender, EventArgs e)
        {
            timerStart(sender, e);

            if (countUp.IsChecked == true)
            {
                int labelUpInt = Convert.ToInt32(label.Content);
                labelUpInt++;
                label.Content = labelUpInt;
            }
            
            else if (countDown.IsChecked == true)
            {
                int labelDownInt = Convert.ToInt32(label.Content);
                if (labelDownInt != 0)
                {
                    labelDownInt--;
                    label.Content = labelDownInt;
                }
            }
        } 

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (timerStarted == true)
            {
                try
                {
                    timerStop();
                    MessageBox.Show("Timer stopped!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }

        private void setInput_Click(object sender, RoutedEventArgs e)
        {
            string input = inputBox.Text.ToString();
            label.Content = input;
            inputBox.Text = "";
        }


        //Checkboxes
        private void countUp_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (countUp.IsChecked == true)
                {
                    countDown.IsChecked = false;
                }

                else if (countDown.IsChecked == true)
                {
                    countUp.IsChecked = false;
                }
            }
            catch (Exception cExc)
            {
                MessageBox.Show(cExc.ToString());
            }
        }
        private void countDown_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (countDown.IsChecked == true)
                {
                    countUp.IsChecked = false;
                }

                else if (countUp.IsChecked == true)
                {
                    countDown.IsChecked = false;
                }
            }
            catch (Exception cExc)
            {
                MessageBox.Show(cExc.ToString());
            }
        }

        private void bttf_time_machine_gif_MediaEnded(object sender, RoutedEventArgs e)
        { 
            bttf_time_machine_gif.Position = new TimeSpan(0, 0, 1);
            bttf_time_machine_gif.Play();
        }

        private void bttf_theme_song_MediaEnded(object sender, RoutedEventArgs e)
        {
            bttf_theme_song.Position = new TimeSpan(0, 0, 0, 1);
            bttf_theme_song.Play();
        }
    }
}
