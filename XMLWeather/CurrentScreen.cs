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
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            
            currentOutput.Text = Truncate(Form1.days[0].currentTemp);
            minOutput.Text = Truncate(Form1.days[0].tempLow);
            maxOutput.Text = Truncate(Form1.days[0].tempHigh);
            //etc.
        }

        public static string Truncate(string input)
        {
            //currentOutput.Text = $"{Math.Truncate(Convert.ToDouble(Form1.days[0].currentTemp))}";
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
    }
}
