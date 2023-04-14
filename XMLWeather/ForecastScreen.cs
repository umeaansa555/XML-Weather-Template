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
        }

        public void displayForecast()
        {
            //  start at tomorrow's forecast [1]
            date1.Text = Form1.days[1].date;
            max1.Text = CurrentScreen.Truncate(Form1.days[1].tempHigh);
            min1.Text = CurrentScreen.Truncate(Form1.days[1].tempLow);
            //symbolIcon1.Image = (Form1.days[1].icon); //find icon img url and set it to picturebox src

            date2.Text = Form1.days[2].date;
            max2.Text = CurrentScreen.Truncate(Form1.days[2].tempHigh);
            min2.Text = CurrentScreen.Truncate(Form1.days[2].tempLow);

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
