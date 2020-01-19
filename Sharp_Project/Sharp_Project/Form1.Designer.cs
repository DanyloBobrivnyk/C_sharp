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
            this.btnWthr = new System.Windows.Forms.Button();
            this.lblTmp = new System.Windows.Forms.Label();
            this.tbxCityName = new System.Windows.Forms.TextBox();
            this.txtboxResponce = new System.Windows.Forms.TextBox();
            this.lblResponce = new System.Windows.Forms.Label();
            this.grpbxWeather = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCity_inBox = new System.Windows.Forms.Label();
            this.pnlWeather = new System.Windows.Forms.Panel();
            this.grpbxWeather.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWthr
            // 
            this.btnWthr.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnWthr.Location = new System.Drawing.Point(642, 346);
            this.btnWthr.Name = "btnWthr";
            this.btnWthr.Size = new System.Drawing.Size(146, 92);
            this.btnWthr.TabIndex = 0;
            this.btnWthr.Text = "Show weather";
            this.btnWthr.UseVisualStyleBackColor = false;
            this.btnWthr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnWthr_MouseClick);
            // 
            // lblTmp
            // 
            this.lblTmp.AutoSize = true;
            this.lblTmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTmp.Location = new System.Drawing.Point(21, 24);
            this.lblTmp.Name = "lblTmp";
            this.lblTmp.Size = new System.Drawing.Size(57, 29);
            this.lblTmp.TabIndex = 2;
            this.lblTmp.Text = "City";
            // 
            // tbxCityName
            // 
            this.tbxCityName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxCityName.Location = new System.Drawing.Point(26, 56);
            this.tbxCityName.Name = "tbxCityName";
            this.tbxCityName.Size = new System.Drawing.Size(179, 20);
            this.tbxCityName.TabIndex = 3;
            this.tbxCityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCityName_KeyPress);
            // 
            // txtboxResponce
            // 
            this.txtboxResponce.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtboxResponce.Location = new System.Drawing.Point(619, 17);
            this.txtboxResponce.Multiline = true;
            this.txtboxResponce.Name = "txtboxResponce";
            this.txtboxResponce.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxResponce.Size = new System.Drawing.Size(169, 202);
            this.txtboxResponce.TabIndex = 4;
            // 
            // lblResponce
            // 
            this.lblResponce.AutoSize = true;
            this.lblResponce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResponce.Location = new System.Drawing.Point(23, 101);
            this.lblResponce.Name = "lblResponce";
            this.lblResponce.Size = new System.Drawing.Size(182, 25);
            this.lblResponce.TabIndex = 6;
            this.lblResponce.Text = "Weather forecast:";
            // 
            // grpbxWeather
            // 
            this.grpbxWeather.Controls.Add(this.label6);
            this.grpbxWeather.Controls.Add(this.label5);
            this.grpbxWeather.Controls.Add(this.groupBox1);
            this.grpbxWeather.Controls.Add(this.label3);
            this.grpbxWeather.Controls.Add(this.label2);
            this.grpbxWeather.Controls.Add(this.lblCity_inBox);
            this.grpbxWeather.Controls.Add(this.pnlWeather);
            this.grpbxWeather.Location = new System.Drawing.Point(26, 129);
            this.grpbxWeather.Name = "grpbxWeather";
            this.grpbxWeather.Size = new System.Drawing.Size(587, 309);
            this.grpbxWeather.TabIndex = 7;
            this.grpbxWeather.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wind";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // lblCity_inBox
            // 
            this.lblCity_inBox.AutoSize = true;
            this.lblCity_inBox.Location = new System.Drawing.Point(113, 20);
            this.lblCity_inBox.Name = "lblCity_inBox";
            this.lblCity_inBox.Size = new System.Drawing.Size(35, 13);
            this.lblCity_inBox.TabIndex = 1;
            this.lblCity_inBox.Text = "label1";
            // 
            // pnlWeather
            // 
            this.pnlWeather.BackColor = System.Drawing.SystemColors.Info;
            this.pnlWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlWeather.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWeather.Location = new System.Drawing.Point(6, 19);
            this.pnlWeather.Name = "pnlWeather";
            this.pnlWeather.Size = new System.Drawing.Size(100, 100);
            this.pnlWeather.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxResponce);
            this.Controls.Add(this.btnWthr);
            this.Controls.Add(this.grpbxWeather);
            this.Controls.Add(this.lblResponce);
            this.Controls.Add(this.tbxCityName);
            this.Controls.Add(this.lblTmp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxWeather.ResumeLayout(false);
            this.grpbxWeather.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWthr;
        private System.Windows.Forms.Label lblTmp;
        private System.Windows.Forms.TextBox tbxCityName;
        private System.Windows.Forms.TextBox txtboxResponce;
        private System.Windows.Forms.Label lblResponce;
        private System.Windows.Forms.GroupBox grpbxWeather;
        private System.Windows.Forms.Panel pnlWeather;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCity_inBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

