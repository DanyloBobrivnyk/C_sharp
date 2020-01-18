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
            this.SuspendLayout();
            // 
            // btnWthr
            // 
            this.btnWthr.Location = new System.Drawing.Point(650, 397);
            this.btnWthr.Name = "btnWthr";
            this.btnWthr.Size = new System.Drawing.Size(138, 41);
            this.btnWthr.TabIndex = 0;
            this.btnWthr.Text = "Show weather";
            this.btnWthr.UseVisualStyleBackColor = true;
            this.btnWthr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnWthr_MouseClick);
            // 
            // lblTmp
            // 
            this.lblTmp.AutoSize = true;
            this.lblTmp.Location = new System.Drawing.Point(23, 21);
            this.lblTmp.Name = "lblTmp";
            this.lblTmp.Size = new System.Drawing.Size(24, 13);
            this.lblTmp.TabIndex = 2;
            this.lblTmp.Text = "City";
            // 
            // tbxCityName
            // 
            this.tbxCityName.Location = new System.Drawing.Point(26, 47);
            this.tbxCityName.Name = "tbxCityName";
            this.tbxCityName.Size = new System.Drawing.Size(424, 20);
            this.tbxCityName.TabIndex = 3;
            this.tbxCityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCityName_KeyPress);
            // 
            // txtboxResponce
            // 
            this.txtboxResponce.Location = new System.Drawing.Point(26, 120);
            this.txtboxResponce.Multiline = true;
            this.txtboxResponce.Name = "txtboxResponce";
            this.txtboxResponce.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxResponce.Size = new System.Drawing.Size(554, 129);
            this.txtboxResponce.TabIndex = 4;
            // 
            // lblResponce
            // 
            this.lblResponce.AutoSize = true;
            this.lblResponce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResponce.Location = new System.Drawing.Point(23, 81);
            this.lblResponce.Name = "lblResponce";
            this.lblResponce.Size = new System.Drawing.Size(115, 25);
            this.lblResponce.TabIndex = 6;
            this.lblResponce.Text = "Responce:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResponce);
            this.Controls.Add(this.txtboxResponce);
            this.Controls.Add(this.tbxCityName);
            this.Controls.Add(this.lblTmp);
            this.Controls.Add(this.btnWthr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWthr;
        private System.Windows.Forms.Label lblTmp;
        private System.Windows.Forms.TextBox tbxCityName;
        private System.Windows.Forms.TextBox txtboxResponce;
        private System.Windows.Forms.Label lblResponce;
    }
}

