namespace CoffeeMachineControllerClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.state_lbl = new System.Windows.Forms.Label();
            this.brew_btn = new System.Windows.Forms.Button();
            this.standby_btn = new System.Windows.Forms.Button();
            this.automatic_btn = new System.Windows.Forms.Button();
            this.maual_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.controllerState_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COFFEE STATE:";
            // 
            // state_lbl
            // 
            this.state_lbl.AutoSize = true;
            this.state_lbl.Location = new System.Drawing.Point(108, 13);
            this.state_lbl.Name = "state_lbl";
            this.state_lbl.Size = new System.Drawing.Size(17, 13);
            this.state_lbl.TabIndex = 1;
            this.state_lbl.Text = "lol";
            // 
            // brew_btn
            // 
            this.brew_btn.Location = new System.Drawing.Point(16, 92);
            this.brew_btn.Name = "brew_btn";
            this.brew_btn.Size = new System.Drawing.Size(75, 23);
            this.brew_btn.TabIndex = 2;
            this.brew_btn.Text = "Brew";
            this.brew_btn.UseVisualStyleBackColor = true;
            this.brew_btn.Click += new System.EventHandler(this.brew_btn_Click);
            // 
            // standby_btn
            // 
            this.standby_btn.Enabled = false;
            this.standby_btn.Location = new System.Drawing.Point(120, 92);
            this.standby_btn.Name = "standby_btn";
            this.standby_btn.Size = new System.Drawing.Size(75, 23);
            this.standby_btn.TabIndex = 3;
            this.standby_btn.Text = "Standby";
            this.standby_btn.UseVisualStyleBackColor = true;
            this.standby_btn.Click += new System.EventHandler(this.standby_btn_Click);
            // 
            // automatic_btn
            // 
            this.automatic_btn.Enabled = false;
            this.automatic_btn.Location = new System.Drawing.Point(222, 92);
            this.automatic_btn.Name = "automatic_btn";
            this.automatic_btn.Size = new System.Drawing.Size(75, 23);
            this.automatic_btn.TabIndex = 4;
            this.automatic_btn.Text = "Automatic";
            this.automatic_btn.UseVisualStyleBackColor = true;
            this.automatic_btn.Click += new System.EventHandler(this.automatic_btn_Click);
            // 
            // maual_btn
            // 
            this.maual_btn.Location = new System.Drawing.Point(325, 92);
            this.maual_btn.Name = "maual_btn";
            this.maual_btn.Size = new System.Drawing.Size(75, 23);
            this.maual_btn.TabIndex = 5;
            this.maual_btn.Text = "Manual";
            this.maual_btn.UseVisualStyleBackColor = true;
            this.maual_btn.Click += new System.EventHandler(this.maual_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CONTROLLER STATE:";
            // 
            // controllerState_lbl
            // 
            this.controllerState_lbl.AutoSize = true;
            this.controllerState_lbl.Location = new System.Drawing.Point(140, 58);
            this.controllerState_lbl.Name = "controllerState_lbl";
            this.controllerState_lbl.Size = new System.Drawing.Size(17, 13);
            this.controllerState_lbl.TabIndex = 7;
            this.controllerState_lbl.Text = "lol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 136);
            this.Controls.Add(this.controllerState_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maual_btn);
            this.Controls.Add(this.automatic_btn);
            this.Controls.Add(this.standby_btn);
            this.Controls.Add(this.brew_btn);
            this.Controls.Add(this.state_lbl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Machine Control Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label state_lbl;
        private System.Windows.Forms.Button brew_btn;
        private System.Windows.Forms.Button standby_btn;
        private System.Windows.Forms.Button automatic_btn;
        private System.Windows.Forms.Button maual_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label controllerState_lbl;
    }
}

