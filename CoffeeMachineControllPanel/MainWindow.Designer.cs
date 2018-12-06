namespace CoffeeMachineControllerClient
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.turnon_btn = new System.Windows.Forms.Button();
            this.turnoff_btn = new System.Windows.Forms.Button();
            this.turnOffMode_drpdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ip_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.brewdelay_number = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customturnoff_number = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.brewdelay_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customturnoff_number)).BeginInit();
            this.SuspendLayout();
            // 
            // turnon_btn
            // 
            this.turnon_btn.Location = new System.Drawing.Point(39, 435);
            this.turnon_btn.Margin = new System.Windows.Forms.Padding(6);
            this.turnon_btn.Name = "turnon_btn";
            this.turnon_btn.Size = new System.Drawing.Size(150, 44);
            this.turnon_btn.TabIndex = 2;
            this.turnon_btn.Text = "Turn On";
            this.turnon_btn.UseVisualStyleBackColor = true;
            this.turnon_btn.Click += new System.EventHandler(this.turnon_btn_Click);
            // 
            // turnoff_btn
            // 
            this.turnoff_btn.Enabled = false;
            this.turnoff_btn.Location = new System.Drawing.Point(227, 435);
            this.turnoff_btn.Margin = new System.Windows.Forms.Padding(6);
            this.turnoff_btn.Name = "turnoff_btn";
            this.turnoff_btn.Size = new System.Drawing.Size(150, 44);
            this.turnoff_btn.TabIndex = 3;
            this.turnoff_btn.Text = "Turn Off";
            this.turnoff_btn.UseVisualStyleBackColor = true;
            this.turnoff_btn.Click += new System.EventHandler(this.turnoff_btn_Click);
            // 
            // turnOffMode_drpdown
            // 
            this.turnOffMode_drpdown.FormattingEnabled = true;
            this.turnOffMode_drpdown.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.turnOffMode_drpdown.Location = new System.Drawing.Point(39, 363);
            this.turnOffMode_drpdown.Name = "turnOffMode_drpdown";
            this.turnOffMode_drpdown.Size = new System.Drawing.Size(338, 33);
            this.turnOffMode_drpdown.TabIndex = 8;
            this.turnOffMode_drpdown.SelectedValueChanged += new System.EventHandler(this.turnOffMode_drpdown_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Turn Off Mode";
            // 
            // ip_txt
            // 
            this.ip_txt.Location = new System.Drawing.Point(39, 61);
            this.ip_txt.Name = "ip_txt";
            this.ip_txt.Size = new System.Drawing.Size(338, 31);
            this.ip_txt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "IP Address:";
            // 
            // brewdelay_number
            // 
            this.brewdelay_number.Location = new System.Drawing.Point(172, 164);
            this.brewdelay_number.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.brewdelay_number.Name = "brewdelay_number";
            this.brewdelay_number.Size = new System.Drawing.Size(97, 31);
            this.brewdelay_number.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Delay brew";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "minutes.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Custom turn off in minutes";
            // 
            // customturnoff_number
            // 
            this.customturnoff_number.Location = new System.Drawing.Point(303, 220);
            this.customturnoff_number.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.customturnoff_number.Name = "customturnoff_number";
            this.customturnoff_number.Size = new System.Drawing.Size(74, 31);
            this.customturnoff_number.TabIndex = 16;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 750);
            this.Controls.Add(this.customturnoff_number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brewdelay_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ip_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.turnOffMode_drpdown);
            this.Controls.Add(this.turnoff_btn);
            this.Controls.Add(this.turnon_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Machine Controller";
            ((System.ComponentModel.ISupportInitialize)(this.brewdelay_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customturnoff_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button turnon_btn;
        private System.Windows.Forms.Button turnoff_btn;
        private System.Windows.Forms.ComboBox turnOffMode_drpdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ip_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown brewdelay_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown customturnoff_number;
    }
}

