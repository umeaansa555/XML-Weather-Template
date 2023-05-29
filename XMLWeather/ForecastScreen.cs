using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
            todayTab.Parent = forecastTab.Parent = label5.Parent = date1.Parent = date2.Parent
                = date3.Parent = maxLabel1.Parent = maxLabel2.Parent = maxLabel3.Parent =
                minLabel1.Parent = minLabel2.Parent = minLabel3.Parent = max1.Parent =
                max2.Parent = max3.Parent = min1.Parent = min2.Parent = min3.Parent =
                conditions1.Parent = conditions2.Parent = conditions3.Parent = symbolIcon1.Parent = backImage; // fix text transparencies

        }

        public void displayForecast()
        {
            //  start at tomorrow's forecast [1]
            date1.Text = $"Tomorrow, {DateTime.Now.AddDays(1).ToString("MMM dd")}";
            conditions1.Text = Form1.days[1].condition;
            max1.Text = CurrentScreen.Truncate(Form1.days[1].tempHigh);
            min1.Text = CurrentScreen.Truncate(Form1.days[1].tempLow);
            
            date2.Text = $"{DateTime.Now.AddDays(2).ToString("dddd")}, {DateTime.Now.AddDays(2).ToString("MMM dd")}";          //date2.Text = Form1.days[2].date;
            conditions2.Text = Form1.days[2].condition;
            max2.Text = CurrentScreen.Truncate(Form1.days[2].tempHigh);
            min2.Text = CurrentScreen.Truncate(Form1.days[2].tempLow);

            date3.Text = $"{DateTime.Now.AddDays(3).ToString("dddd")}, {DateTime.Now.AddDays(3).ToString("MMM dd")}";
            conditions3.Text = Form1.days[3].condition;
            max3.Text = CurrentScreen.Truncate(Form1.days[3].tempHigh);
            min3.Text = CurrentScreen.Truncate(Form1.days[3].tempLow);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
