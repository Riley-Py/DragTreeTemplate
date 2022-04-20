using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragTree 
{
    public partial class Form1 : Form
    {
        // TODO - create an int variable to track currentRow,
        int currentRow = 1;
        // TODO - create a Stopwatch object called stopwatch 
        Stopwatch tracker = new Stopwatch();

        // TODO - create a timer on the form called lightTimer (interval 400ms)
        // TODO - create the tick event for the lightTimer

        // place the following comments in the lighTimer tick event
        // TODO - create a switch block that checks currentRow. In each case
        // it will light up the appropriate lights, (labels). 

        // TODO - increment the currentRow value by 1

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // TODO - start the timer
            tracker.Start();
            timer.Enabled = true;

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // TODO - stop the stopwatch
            tracker.Stop();
            TimeSpan elapsed = tracker.Elapsed;
            // TODO - check if the ellapsed time in milliseconds is > 0. 
            if ()
            {
                if (row4col1.BackColor == Color.LightGreen)
                {
                    timeLabel.Text = tracker.Elapsed.TotalMilliseconds + " ";
                }
            }
            else
            {
                timeLabel.Text = "FOUL START!";
            }
            // If yes show the time.
            // If no show "FOUL START" 

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // TODO - reset the stopwatch

            // TODO - put rows 1-3 colours back to DimGray and row 4 back to DarkOliveGreen

            // TODO - reset row value and timeLabel text

            tracker.Reset();
            timer.Stop();

            row1col1.BackColor = Color.DimGray;
            row1col2.BackColor = Color.DimGray;

            row2col1.BackColor = Color.DimGray;
            row2col2.BackColor = Color.DimGray;

            row3col1.BackColor = Color.DimGray;
            row3col2.BackColor = Color.DimGray;

            row4col1.BackColor = Color.DarkOliveGreen;
            row4col2.BackColor = Color.DarkOliveGreen;

            timeLabel.Text = "0.000";

            currentRow = 1;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // TODO - create a switch block that checks currentRow. In each case
            // it will light up the appropriate lights, (labels). 

            // TODO - increment the currentRow value by 1

            switch (currentRow)
            {
                case 1:
                    row1col1.BackColor = Color.Yellow;
                    row1col2.BackColor = Color.Yellow;
                    currentRow++;
                    break;
                case 2:
                    row2col1.BackColor = Color.Yellow;
                    row2col2.BackColor = Color.Yellow;
                    currentRow++;
                    break;
                case 3:
                    row3col1.BackColor = Color.Yellow;
                    row3col2.BackColor = Color.Yellow;
                    currentRow++;
                    break;
                case 4:
                    row4col1.BackColor = Color.LightGreen;
                    row4col2.BackColor = Color.LightGreen;
                    currentRow++;
                    break;
            }

        }
    }
}
