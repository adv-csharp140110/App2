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
            this.btnJalaliToMiladi = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.buttonTuple = new System.Windows.Forms.Button();
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
            // btnJalaliToMiladi
            // 
            this.btnJalaliToMiladi.Location = new System.Drawing.Point(12, 70);
            this.btnJalaliToMiladi.Name = "btnJalaliToMiladi";
            this.btnJalaliToMiladi.Size = new System.Drawing.Size(146, 23);
            this.btnJalaliToMiladi.TabIndex = 2;
            this.btnJalaliToMiladi.Text = "Jalali to Miladi";
            this.btnJalaliToMiladi.UseVisualStyleBackColor = true;
            this.btnJalaliToMiladi.Click += new System.EventHandler(this.btnJalaliToMiladi_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(12, 134);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(146, 23);
            this.buttonOut.TabIndex = 3;
            this.buttonOut.Text = "Out Example";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(12, 163);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(146, 23);
            this.buttonRef.TabIndex = 4;
            this.buttonRef.Text = "Ref Example";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // buttonTuple
            // 
            this.buttonTuple.Location = new System.Drawing.Point(12, 192);
            this.buttonTuple.Name = "buttonTuple";
            this.buttonTuple.Size = new System.Drawing.Size(146, 23);
            this.buttonTuple.TabIndex = 5;
            this.buttonTuple.Text = "Tuple Example";
            this.buttonTuple.UseVisualStyleBackColor = true;
            this.buttonTuple.Click += new System.EventHandler(this.buttonTuple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTuple);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.btnJalaliToMiladi);
            this.Controls.Add(this.buttonGetJalaliMonth);
            this.Controls.Add(this.buttonMiladiToJalali);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonMiladiToJalali;
        private Button buttonGetJalaliMonth;
        private Button btnJalaliToMiladi;
        private Button buttonOut;
        private Button buttonRef;
        private Button buttonTuple;
    }
}