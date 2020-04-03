namespace ATM
{
    partial class BankSystem
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
            this.labelHelloBank = new System.Windows.Forms.Label();
            this.labelChooseRace = new System.Windows.Forms.Label();
            this.buttonRace = new System.Windows.Forms.Button();
            this.buttonNonRace = new System.Windows.Forms.Button();
            this.buttonLaunchATM = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHelloBank
            // 
            this.labelHelloBank.AutoSize = true;
            this.labelHelloBank.Font = new System.Drawing.Font("Bahnschrift Condensed", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelloBank.ForeColor = System.Drawing.Color.White;
            this.labelHelloBank.Location = new System.Drawing.Point(237, 99);
            this.labelHelloBank.Name = "labelHelloBank";
            this.labelHelloBank.Size = new System.Drawing.Size(362, 82);
            this.labelHelloBank.TabIndex = 0;
            this.labelHelloBank.Text = "ATM Simulator";
            // 
            // labelChooseRace
            // 
            this.labelChooseRace.AutoSize = true;
            this.labelChooseRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseRace.ForeColor = System.Drawing.Color.White;
            this.labelChooseRace.Location = new System.Drawing.Point(155, 201);
            this.labelChooseRace.Name = "labelChooseRace";
            this.labelChooseRace.Size = new System.Drawing.Size(511, 32);
            this.labelChooseRace.TabIndex = 1;
            this.labelChooseRace.Text = "Please choose one of the option below:";
            // 
            // buttonRace
            // 
            this.buttonRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRace.Location = new System.Drawing.Point(225, 259);
            this.buttonRace.Name = "buttonRace";
            this.buttonRace.Size = new System.Drawing.Size(184, 55);
            this.buttonRace.TabIndex = 2;
            this.buttonRace.Text = "DATA RACE";
            this.buttonRace.UseVisualStyleBackColor = true;
            // 
            // buttonNonRace
            // 
            this.buttonNonRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNonRace.Location = new System.Drawing.Point(415, 259);
            this.buttonNonRace.Name = "buttonNonRace";
            this.buttonNonRace.Size = new System.Drawing.Size(184, 55);
            this.buttonNonRace.TabIndex = 3;
            this.buttonNonRace.Text = "NON-DATA RACE";
            this.buttonNonRace.UseVisualStyleBackColor = true;
            // 
            // buttonLaunchATM
            // 
            this.buttonLaunchATM.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonLaunchATM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLaunchATM.Location = new System.Drawing.Point(630, 466);
            this.buttonLaunchATM.Name = "buttonLaunchATM";
            this.buttonLaunchATM.Size = new System.Drawing.Size(120, 50);
            this.buttonLaunchATM.TabIndex = 4;
            this.buttonLaunchATM.Text = "START";
            this.buttonLaunchATM.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(51, 465);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 50);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // BankSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLaunchATM);
            this.Controls.Add(this.buttonNonRace);
            this.Controls.Add(this.buttonRace);
            this.Controls.Add(this.labelChooseRace);
            this.Controls.Add(this.labelHelloBank);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BankSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHelloBank;
        private System.Windows.Forms.Label labelChooseRace;
        private System.Windows.Forms.Button buttonRace;
        private System.Windows.Forms.Button buttonNonRace;
        private System.Windows.Forms.Button buttonLaunchATM;
        private System.Windows.Forms.Button buttonExit;
    }
}

