﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();

             cityOutput.Parent = dateLabel.Parent = currentOutput.Parent = minLabel.Parent = maxLabel.Parent
                = minOutput.Parent  = maxOutput.Parent = conditionLabel.Parent = degreesLabel.Parent =
                todayTab.Parent = tabMarker.Parent = forecastTab.Parent = searchTab.Parent = backImage; // fix text transparencies


        }

        public void DisplayCurrent() // show current date and relevant info
        {
            cityOutput.Text = Form1.days[0].location;

            dateLabel.Text = $"{DateTime.Now.ToString("dddd")}, {DateTime.Now.ToString("MMM dd")}";

            currentOutput.Text = Truncate(Form1.days[0].currentTemp);
            minOutput.Text = Truncate(Form1.days[0].tempLow);
            maxOutput.Text = Truncate(Form1.days[0].tempHigh);
            conditionLabel.Text = Form1.days[0].condition;
        }

        public static string Truncate(string input) //round temperatures to whole numbers
        {
            double truncated = Math.Truncate(Convert.ToDouble(input));
            string result = Convert.ToString(truncated);

            return result;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchTabLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen fs = new SearchScreen();
            f.Controls.Add(fs);
        }
    }
}
