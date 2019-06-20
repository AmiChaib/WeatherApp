namespace WeatherApp
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage tabPage1;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.windLabel = new System.Windows.Forms.Label();
            this.humidLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.updateLabel = new System.Windows.Forms.Label();
            this.locLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.Weather = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trendChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cityTrendLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.changeRRBox = new System.Windows.Forms.TextBox();
            this.changeCityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.WeatherApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage1.SuspendLayout();
            this.Weather.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trendChart)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            tabPage1.BackgroundImage = global::WeatherApp.Properties.Resources.sky;
            tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tabPage1.Controls.Add(this.windLabel);
            tabPage1.Controls.Add(this.humidLabel);
            tabPage1.Controls.Add(this.descLabel);
            tabPage1.Controls.Add(this.updateLabel);
            tabPage1.Controls.Add(this.locLabel);
            tabPage1.Controls.Add(this.tempLabel);
            tabPage1.Location = new System.Drawing.Point(4, 45);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(867, 442);
            tabPage1.TabIndex = 0;
            tabPage1.Text = " Current ";
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.windLabel.Location = new System.Drawing.Point(479, 227);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(62, 36);
            this.windLabel.TabIndex = 7;
            this.windLabel.Text = "Wind";
            // 
            // humidLabel
            // 
            this.humidLabel.AutoSize = true;
            this.humidLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.humidLabel.Location = new System.Drawing.Point(479, 193);
            this.humidLabel.Name = "humidLabel";
            this.humidLabel.Size = new System.Drawing.Size(96, 36);
            this.humidLabel.TabIndex = 6;
            this.humidLabel.Text = "Humidity";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.BackColor = System.Drawing.Color.Transparent;
            this.descLabel.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.descLabel.Location = new System.Drawing.Point(476, 150);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(172, 50);
            this.descLabel.TabIndex = 5;
            this.descLabel.Text = "Description";
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.BackColor = System.Drawing.Color.Transparent;
            this.updateLabel.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.updateLabel.Location = new System.Drawing.Point(578, 393);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(73, 27);
            this.updateLabel.TabIndex = 4;
            this.updateLabel.Text = "Updated:";
            // 
            // locLabel
            // 
            this.locLabel.AutoSize = true;
            this.locLabel.BackColor = System.Drawing.Color.Transparent;
            this.locLabel.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.locLabel.Location = new System.Drawing.Point(94, 215);
            this.locLabel.Name = "locLabel";
            this.locLabel.Size = new System.Drawing.Size(229, 58);
            this.locLabel.TabIndex = 2;
            this.locLabel.Text = "City, Country";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.tempLabel.Location = new System.Drawing.Point(86, 130);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(407, 106);
            this.tempLabel.TabIndex = 3;
            this.tempLabel.Text = "Temperature";
            // 
            // Weather
            // 
            this.Weather.Controls.Add(tabPage1);
            this.Weather.Controls.Add(this.tabPage2);
            this.Weather.Controls.Add(this.tabPage3);
            this.Weather.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Weather.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weather.Location = new System.Drawing.Point(-7, 1);
            this.Weather.Multiline = true;
            this.Weather.Name = "Weather";
            this.Weather.Padding = new System.Drawing.Point(10, 5);
            this.Weather.SelectedIndex = 0;
            this.Weather.Size = new System.Drawing.Size(875, 491);
            this.Weather.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage2.BackgroundImage = global::WeatherApp.Properties.Resources.sky;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.trendChart);
            this.tabPage2.Controls.Add(this.cityTrendLabel);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 45);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(867, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Trend ";
            // 
            // trendChart
            // 
            this.trendChart.BackColor = System.Drawing.Color.Transparent;
            this.trendChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.trendChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.trendChart.ChartAreas.Add(chartArea1);
            this.trendChart.ImeMode = System.Windows.Forms.ImeMode.Disable;
            legend1.Name = "Legend1";
            this.trendChart.Legends.Add(legend1);
            this.trendChart.Location = new System.Drawing.Point(25, 82);
            this.trendChart.Name = "trendChart";
            this.trendChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Average °C";
            this.trendChart.Series.Add(series1);
            this.trendChart.Size = new System.Drawing.Size(798, 277);
            this.trendChart.TabIndex = 4;
            this.trendChart.Text = "trendChart";
            // 
            // cityTrendLabel
            // 
            this.cityTrendLabel.AutoSize = true;
            this.cityTrendLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityTrendLabel.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTrendLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.cityTrendLabel.Location = new System.Drawing.Point(15, 21);
            this.cityTrendLabel.Name = "cityTrendLabel";
            this.cityTrendLabel.Size = new System.Drawing.Size(229, 58);
            this.cityTrendLabel.TabIndex = 3;
            this.cityTrendLabel.Text = "City, Country";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage3.BackgroundImage = global::WeatherApp.Properties.Resources.sky;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.changeRRBox);
            this.tabPage3.Controls.Add(this.changeCityBox);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 45);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(867, 442);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = " Options ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "(in number of minutes)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(446, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // changeRRBox
            // 
            this.changeRRBox.Location = new System.Drawing.Point(446, 201);
            this.changeRRBox.Name = "changeRRBox";
            this.changeRRBox.Size = new System.Drawing.Size(218, 41);
            this.changeRRBox.TabIndex = 3;
            // 
            // changeCityBox
            // 
            this.changeCityBox.Location = new System.Drawing.Point(446, 109);
            this.changeCityBox.Name = "changeCityBox";
            this.changeCityBox.Size = new System.Drawing.Size(218, 41);
            this.changeCityBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Change Refresh Rate: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change City: ";
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // WeatherApp
            // 
            this.WeatherApp.ContextMenuStrip = this.contextMenuStrip1;
            this.WeatherApp.Icon = ((System.Drawing.Icon)(resources.GetObject("WeatherApp.Icon")));
            this.WeatherApp.Text = "notifyIcon1";
            this.WeatherApp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WeatherApp_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 52);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = global::WeatherApp.Properties.Resources.sky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 473);
            this.Controls.Add(this.Weather);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 520);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            this.Weather.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trendChart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Weather;
        private System.Windows.Forms.Label locLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label humidLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox changeRRBox;
        private System.Windows.Forms.TextBox changeCityBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.NotifyIcon WeatherApp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart trendChart;
        private System.Windows.Forms.Label cityTrendLabel;
    }
}

