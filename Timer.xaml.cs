﻿using System;
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
        }
        
        private bool timerStarted = false;                      //bool für start-stopp bedingung festzulegen
        int count = 0;

        private void timerStart(object sender, EventArgs e)     //eventmethode? start
        {
            //Tickhandler für Zyklen
            newTimer.Tick += new EventHandler(startButton_Click);                 //subscribe .tick an event handler
            newTimer.Interval = TimeSpan.FromMilliseconds(1000);            //definiere angezeigtes zeitintervall
            newTimer.Start();                                       //starte timer

            timerStarted = true;                                //setze bool auf true für stopp-bed

            return;
        }

        private void timerStop()
        {
            newTimer.Tick += new EventHandler(stopButton_Click); //subscribe .tick an event handler
            newTimer.Interval = TimeSpan.FromMilliseconds(1000);            //definiere angezeigtes zeitintervall
            newTimer.Stop();

            timerStarted = false;

            return;
        }

        //Buttons
        private void startButton_Click(object sender, EventArgs e)
        {
            count++;
            label.Content = count;
            timerStart(sender, e);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if(timerStarted == true)
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
    }
}
