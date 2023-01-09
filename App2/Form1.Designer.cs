namespace App2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMiladiToJalali = new System.Windows.Forms.Button();
            this.buttonGetJalaliMonth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMiladiToJalali
            // 
            this.buttonMiladiToJalali.Location = new System.Drawing.Point(12, 12);
            this.buttonMiladiToJalali.Name = "buttonMiladiToJalali";
            this.buttonMiladiToJalali.Size = new System.Drawing.Size(146, 23);
            this.buttonMiladiToJalali.TabIndex = 0;
            this.buttonMiladiToJalali.Text = "Miladi 2 Jalali";
            this.buttonMiladiToJalali.UseVisualStyleBackColor = true;
            this.buttonMiladiToJalali.Click += new System.EventHandler(this.buttonMiladiToJalali_Click);
            // 
            // buttonGetJalaliMonth
            // 
            this.buttonGetJalaliMonth.Location = new System.Drawing.Point(12, 41);
            this.buttonGetJalaliMonth.Name = "buttonGetJalaliMonth";
            this.buttonGetJalaliMonth.Size = new System.Drawing.Size(146, 23);
            this.buttonGetJalaliMonth.TabIndex = 1;
            this.buttonGetJalaliMonth.Text = "Get Jalali Month";
            this.buttonGetJalaliMonth.UseVisualStyleBackColor = true;
            this.buttonGetJalaliMonth.Click += new System.EventHandler(this.buttonGetJalaliMonth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGetJalaliMonth);
            this.Controls.Add(this.buttonMiladiToJalali);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonMiladiToJalali;
        private Button buttonGetJalaliMonth;
    }
}