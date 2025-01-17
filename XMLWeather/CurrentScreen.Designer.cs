﻿namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.todayTab = new System.Windows.Forms.Label();
            this.forecastTab = new System.Windows.Forms.Label();
            this.tabMarker = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.backImage = new System.Windows.Forms.PictureBox();
            this.degreesLabel = new System.Windows.Forms.Label();
            this.searchTab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(172, 331);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(142, 95);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(119, 436);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(33, 36);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.Text = "0";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(30, 436);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(67, 29);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "High";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(270, 436);
            this.minOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(33, 36);
            this.minOutput.TabIndex = 30;
            this.minOutput.Text = "0";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(188, 436);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(61, 29);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "Low";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(28, 118);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(179, 91);
            this.currentOutput.TabIndex = 28;
            this.currentOutput.Text = "10";
            this.currentOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // todayTab
            // 
            this.todayTab.BackColor = System.Drawing.Color.Transparent;
            this.todayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayTab.ForeColor = System.Drawing.Color.White;
            this.todayTab.Location = new System.Drawing.Point(28, 18);
            this.todayTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayTab.Name = "todayTab";
            this.todayTab.Size = new System.Drawing.Size(110, 34);
            this.todayTab.TabIndex = 40;
            this.todayTab.Text = "Today          ";
            // 
            // forecastTab
            // 
            this.forecastTab.BackColor = System.Drawing.Color.Transparent;
            this.forecastTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastTab.ForeColor = System.Drawing.Color.White;
            this.forecastTab.Location = new System.Drawing.Point(188, 18);
            this.forecastTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastTab.Name = "forecastTab";
            this.forecastTab.Size = new System.Drawing.Size(110, 34);
            this.forecastTab.TabIndex = 41;
            this.forecastTab.Text = "7 Day";
            this.forecastTab.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // tabMarker
            // 
            this.tabMarker.BackColor = System.Drawing.Color.Transparent;
            this.tabMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMarker.ForeColor = System.Drawing.Color.White;
            this.tabMarker.Location = new System.Drawing.Point(26, 31);
            this.tabMarker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tabMarker.Name = "tabMarker";
            this.tabMarker.Size = new System.Drawing.Size(153, 33);
            this.tabMarker.TabIndex = 42;
            this.tabMarker.Text = "____________________________";
            this.tabMarker.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabMarker.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(22, 331);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(142, 95);
            this.dateLabel.TabIndex = 43;
            this.dateLabel.Text = "Date";
            // 
            // conditionLabel
            // 
            this.conditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.conditionLabel.ForeColor = System.Drawing.Color.White;
            this.conditionLabel.Location = new System.Drawing.Point(34, 258);
            this.conditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(264, 52);
            this.conditionLabel.TabIndex = 45;
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backImage
            // 
            this.backImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.backImage.Image = global::XMLWeather.Properties.Resources.Rain3;
            this.backImage.InitialImage = global::XMLWeather.Properties.Resources.Rain3;
            this.backImage.Location = new System.Drawing.Point(0, 0);
            this.backImage.Name = "backImage";
            this.backImage.Size = new System.Drawing.Size(333, 492);
            this.backImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backImage.TabIndex = 46;
            this.backImage.TabStop = false;
            // 
            // degreesLabel
            // 
            this.degreesLabel.AutoSize = true;
            this.degreesLabel.BackColor = System.Drawing.Color.Transparent;
            this.degreesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreesLabel.ForeColor = System.Drawing.Color.White;
            this.degreesLabel.Location = new System.Drawing.Point(183, 118);
            this.degreesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.degreesLabel.Name = "degreesLabel";
            this.degreesLabel.Size = new System.Drawing.Size(50, 36);
            this.degreesLabel.TabIndex = 47;
            this.degreesLabel.Text = "°C";
            // 
            // searchTab
            // 
            this.searchTab.BackColor = System.Drawing.Color.Transparent;
            this.searchTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTab.ForeColor = System.Drawing.Color.White;
            this.searchTab.Location = new System.Drawing.Point(125, 64);
            this.searchTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchTab.Name = "searchTab";
            this.searchTab.Size = new System.Drawing.Size(189, 34);
            this.searchTab.TabIndex = 48;
            this.searchTab.Text = "City Search";
            this.searchTab.Click += new System.EventHandler(this.searchTabLabel_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.searchTab);
            this.Controls.Add(this.degreesLabel);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.forecastTab);
            this.Controls.Add(this.todayTab);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tabMarker);
            this.Controls.Add(this.backImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(333, 492);
            ((System.ComponentModel.ISupportInitialize)(this.backImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label todayTab;
        private System.Windows.Forms.Label forecastTab;
        private System.Windows.Forms.Label tabMarker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.PictureBox backImage;
        private System.Windows.Forms.Label degreesLabel;
        private System.Windows.Forms.Label searchTab;
    }
}
