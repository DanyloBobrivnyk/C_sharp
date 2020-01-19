namespace Sharp_Project
{
    partial class Form1
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
            this.tbxCityName = new System.Windows.Forms.TextBox();
            this.lblResponce = new System.Windows.Forms.Label();
            this.pnlWeather = new System.Windows.Forms.Panel();
            this.txtboxResponce = new System.Windows.Forms.TextBox();
            this.btnWthr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSimpleForecast = new System.Windows.Forms.Button();
            this.btnExtendedForecast = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxCityName
            // 
            this.tbxCityName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCityName.Location = new System.Drawing.Point(6, 34);
            this.tbxCityName.Name = "tbxCityName";
            this.tbxCityName.Size = new System.Drawing.Size(179, 29);
            this.tbxCityName.TabIndex = 3;
            this.tbxCityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCityName_KeyPress);
            // 
            // lblResponce
            // 
            this.lblResponce.AutoSize = true;
            this.lblResponce.BackColor = System.Drawing.SystemColors.Menu;
            this.lblResponce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResponce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResponce.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResponce.Location = new System.Drawing.Point(29, 134);
            this.lblResponce.Name = "lblResponce";
            this.lblResponce.Size = new System.Drawing.Size(184, 27);
            this.lblResponce.TabIndex = 6;
            this.lblResponce.Text = "Weather forecast:";
            // 
            // pnlWeather
            // 
            this.pnlWeather.BackColor = System.Drawing.SystemColors.Info;
            this.pnlWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlWeather.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWeather.Location = new System.Drawing.Point(279, 17);
            this.pnlWeather.Name = "pnlWeather";
            this.pnlWeather.Size = new System.Drawing.Size(100, 100);
            this.pnlWeather.TabIndex = 0;
            // 
            // txtboxResponce
            // 
            this.txtboxResponce.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtboxResponce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxResponce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxResponce.Location = new System.Drawing.Point(12, 17);
            this.txtboxResponce.Multiline = true;
            this.txtboxResponce.Name = "txtboxResponce";
            this.txtboxResponce.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxResponce.Size = new System.Drawing.Size(250, 258);
            this.txtboxResponce.TabIndex = 4;
            // 
            // btnWthr
            // 
            this.btnWthr.BackColor = System.Drawing.SystemColors.Menu;
            this.btnWthr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWthr.Location = new System.Drawing.Point(289, 185);
            this.btnWthr.Name = "btnWthr";
            this.btnWthr.Size = new System.Drawing.Size(90, 90);
            this.btnWthr.TabIndex = 0;
            this.btnWthr.Text = "Show weather";
            this.btnWthr.UseVisualStyleBackColor = false;
            this.btnWthr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnWthr_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.txtboxResponce);
            this.panel1.Controls.Add(this.btnWthr);
            this.panel1.Controls.Add(this.pnlWeather);
            this.panel1.Location = new System.Drawing.Point(29, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 319);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Controls.Add(this.tbxCityName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City:";
            // 
            // btnSimpleForecast
            // 
            this.btnSimpleForecast.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSimpleForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSimpleForecast.Location = new System.Drawing.Point(238, 13);
            this.btnSimpleForecast.Name = "btnSimpleForecast";
            this.btnSimpleForecast.Size = new System.Drawing.Size(90, 62);
            this.btnSimpleForecast.TabIndex = 9;
            this.btnSimpleForecast.Text = "Simple Forecast";
            this.btnSimpleForecast.UseVisualStyleBackColor = false;
            this.btnSimpleForecast.Click += new System.EventHandler(this.btnSimpleForecast_Click);
            // 
            // btnExtendedForecast
            // 
            this.btnExtendedForecast.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnExtendedForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExtendedForecast.Location = new System.Drawing.Point(339, 13);
            this.btnExtendedForecast.Name = "btnExtendedForecast";
            this.btnExtendedForecast.Size = new System.Drawing.Size(90, 62);
            this.btnExtendedForecast.TabIndex = 10;
            this.btnExtendedForecast.Text = "Extended Forecast";
            this.btnExtendedForecast.UseVisualStyleBackColor = false;
            this.btnExtendedForecast.Click += new System.EventHandler(this.btnExtendedForecast_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(272, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::Sharp_Project.Properties.Resources._5c790acfaed94_thumb900;
            this.ClientSize = new System.Drawing.Size(452, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExtendedForecast);
            this.Controls.Add(this.btnSimpleForecast);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResponce);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxCityName;
        private System.Windows.Forms.Label lblResponce;
        private System.Windows.Forms.Panel pnlWeather;
        private System.Windows.Forms.TextBox txtboxResponce;
        private System.Windows.Forms.Button btnWthr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExtendedForecast;
        private System.Windows.Forms.Button btnSimpleForecast;
        private System.Windows.Forms.Button button1;
    }
}

