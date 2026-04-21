using System;
using System.Windows.Forms;

namespace stopwatch
{
    public partial class StopWatch : Form
    {
        int hours = 0;
        int minutes = 0;
        int seconds = 0;

        public StopWatch()
        {
            InitializeComponent(); //loads ui
            timer1.Interval = 1000; 
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
            }

            if (minutes == 60)
            {
                minutes = 0;
                hours++;
            }

            label1.Text = hours.ToString("D2") + ":" +
                          minutes.ToString("D2") + ":" +
                          seconds.ToString("D2");
        }

        // START BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            hours = 0;
            minutes = 0;
            seconds = 0;

            label1.Text = "00:00:00";
            timer1.Start();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}