using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class Menu : Form
    {

        string city;
        string temp;
        int refreshRate;
        bool unit;
        public Menu()
        {
            city = "Munich";
            temp = "10";
            refreshRate = 600000;
            unit = true;
            InitializeComponent();
            CreateContextMenu();
            this.FormClosing += this.Form1_FormClosing;
            refreshTimer.Interval = refreshRate;
            refreshTimer.Start();
            display();
        }

        private void CreateContextMenu()
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            ToolStripMenuItem menuItem2 = new ToolStripMenuItem("About");
            menuItem2.Click += new EventHandler(menuItem2_Click);
            menuItem2.Name = "About";
            menuStrip.Items.Add(menuItem2);
            ToolStripMenuItem menuItem = new ToolStripMenuItem("Exit");
            menuItem.Click += new EventHandler(menuItem_Click);
            menuItem.Name = "Exit";
            menuStrip.Items.Add(menuItem);
            this.ContextMenuStrip = menuStrip;
        }

        void menuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;
            Environment.Exit(0);
        }
        void menuItem2_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;
            About a = new About();
            a.Show();
        }
        void display()
        {
            tempLabel.Text = temp + " °C";
            locLabel.Text = city;
            changeCityBox.Text = city;
            unitLabel.Text = "in °C";
            changeRRBox.Text = ((refreshRate / 60000).ToString());
            getWeather(city);
        }
        void getWeather(string city)
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=3840b828ef1e8c528ee63351a1914a45&units=metric");
                    var json = web.DownloadString(url);
                    var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                    setLabels(result);
                    setTrend();
                }
            }
            catch (Exception)
            {
                city = "London";
                getWeather(city);
            }
        }
        void setLabels(WeatherInfo.root result)
        {
            WeatherInfo.root outPut = result;
            locLabel.Text = string.Format("{0}, {1}", outPut.name, outPut.sys.country);
            cityTrendLabel.Text = locLabel.Text;
            if (unit)
            {
                tempLabel.Text = string.Format("{0} °C", Math.Round(outPut.main.temp, MidpointRounding.AwayFromZero));
            }
            else
            {
                tempLabel.Text = string.Format("{0} °F", Math.Round((outPut.main.temp * 5/9 + 32), MidpointRounding.AwayFromZero));
            }
            CurrentTemp.Text = locLabel.Text + " - " + tempLabel.Text;
            updateLabel.Text = "Updated: " + DateTime.Now.ToString();
            descLabel.Text = string.Format("{0}", outPut.weatherList[0].main);
            humidLabel.Text = string.Format("Humidity: {0}%", outPut.main.humidity);
            windLabel.Text = string.Format("Wind speed: {0}m/s", outPut.wind.speed);
            addWeatherData(outPut.name, outPut.main.temp);
        }
        void addWeatherData(string city, double temp)
        {
            string query = "INSERT INTO WeatherData (Date, City, Temp) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + city + "', '" + temp + "');";
            DBInsert dbcon = new DBInsert(query);
        }
        private void ApplyChangesButton_Click(object sender, EventArgs e)
        {
            change();
        }
        void change()
        {
            city = changeCityBox.Text;
            try
            {
                refreshRate = (Convert.ToInt32(changeRRBox.Text) * 60000);
                refreshTimer.Interval = refreshRate;
            }
            catch (InvalidCastException i)
            {
                throw new InvalidCastException("You need to fill in a number of minutes." + i.Message);
            }
            if (C.Checked)
            {
                unit = true;
                unitLabel.Text = " in °C";
            }
            else
            {
                unit = false;
                unitLabel.Text = " in °F";
            }
            Weather.SelectedIndex = 0;
            getWeather(city);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            refreshTimer.Interval = refreshRate;
            getWeather(city);
            refreshTimer.Start();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            WeatherApp.Visible = true;
        }
        private void WeatherApp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            WeatherApp.Visible = false;
        }
        void setTrend()
        {
            trendChart.Series["Average"].Points.Clear();
            double[] avgTempArr = new double[5];
            string[] dateStringArr = new string[5];
            for (int i = 0; i < 5; i++)
            {
                var date = DateTime.Now.AddDays(i - 4);
                string dateString = date.ToString("yyyy-MM-dd");
                string query = "SELECT AVG(Temp) FROM WeatherData WHERE City = '" + city + "' AND Date = '" + dateString + "';";
                DBSelect select = new DBSelect(query);
                avgTempArr[i] = select.getResult();
                dateStringArr[i] = dateString;
            }
            for (int i = 0; i < 5; i++)
            {
                double avgTemp;
                if (unit)
                {
                    avgTemp = avgTempArr[i];
                }
                else
                {
                    avgTemp = avgTempArr[i] * 5 / 9 + 32;
                }
                trendChart.Series["Average"].Points.AddXY(dateStringArr[i], avgTemp);
            }
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeatherApp_MouseDoubleClick(null, null);
            Weather.SelectedIndex = 2;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeatherApp_MouseDoubleClick(null, null);
            Weather.SelectedIndex = 0;
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getWeather(city);
        }
    }
}
