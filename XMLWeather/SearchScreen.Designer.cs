namespace XMLWeather
{
    partial class SearchScreen
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
            this.forecastTab = new System.Windows.Forms.Label();
            this.todayTab = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTabLabel = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.formatLabel = new System.Windows.Forms.Label();
            this.submitCityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forecastTab
            // 
            this.forecastTab.BackColor = System.Drawing.Color.Transparent;
            this.forecastTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastTab.ForeColor = System.Drawing.Color.White;
            this.forecastTab.Location = new System.Drawing.Point(179, 18);
            this.forecastTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastTab.Name = "forecastTab";
            this.forecastTab.Size = new System.Drawing.Size(110, 34);
            this.forecastTab.TabIndex = 65;
            this.forecastTab.Text = "7 Day";
            this.forecastTab.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // todayTab
            // 
            this.todayTab.BackColor = System.Drawing.Color.Transparent;
            this.todayTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayTab.ForeColor = System.Drawing.Color.White;
            this.todayTab.Location = new System.Drawing.Point(19, 18);
            this.todayTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayTab.Name = "todayTab";
            this.todayTab.Size = new System.Drawing.Size(110, 34);
            this.todayTab.TabIndex = 64;
            this.todayTab.Text = "Today";
            this.todayTab.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(128, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 33);
            this.label5.TabIndex = 66;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchTabLabel
            // 
            this.searchTabLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTabLabel.ForeColor = System.Drawing.Color.White;
            this.searchTabLabel.Location = new System.Drawing.Point(125, 61);
            this.searchTabLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchTabLabel.Name = "searchTabLabel";
            this.searchTabLabel.Size = new System.Drawing.Size(189, 34);
            this.searchTabLabel.TabIndex = 67;
            this.searchTabLabel.Text = "City Search";
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(17, 196);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(217, 22);
            this.cityInput.TabIndex = 68;
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.BackColor = System.Drawing.Color.Transparent;
            this.formatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatLabel.ForeColor = System.Drawing.Color.White;
            this.formatLabel.Location = new System.Drawing.Point(30, 151);
            this.formatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(268, 29);
            this.formatLabel.TabIndex = 69;
            this.formatLabel.Text = "City name, country code";
            // 
            // submitCityButton
            // 
            this.submitCityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitCityButton.Location = new System.Drawing.Point(240, 192);
            this.submitCityButton.Name = "submitCityButton";
            this.submitCityButton.Size = new System.Drawing.Size(74, 31);
            this.submitCityButton.TabIndex = 0;
            this.submitCityButton.Text = "Search";
            this.submitCityButton.UseVisualStyleBackColor = true;
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.submitCityButton);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.searchTabLabel);
            this.Controls.Add(this.forecastTab);
            this.Controls.Add(this.todayTab);
            this.Controls.Add(this.label5);
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(333, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastTab;
        private System.Windows.Forms.Label todayTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label searchTabLabel;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.Button submitCityButton;
    }
}
