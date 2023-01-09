using App2.Utils;

namespace App2
{
     public sealed partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMiladiToJalali_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(DateUtil.MiladiToJalai(DateTime.Now));
        }

        private void buttonGetJalaliMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateUtil.GetJalaliMonthName_switch(DateTime.Now));
        }

        private void btnJalaliToMiladi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateUtil.JalaliToMiladi("1401/10/19").ToLongDateString());
        }
    }

}