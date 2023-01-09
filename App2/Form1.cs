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
            var now = DateTime.Now;
            
            DateUtil.ToJalali(now);
            now.ToJalali();



            MessageBox.Show(DateUtil.MiladiToJalai(DateTime.Now));
        }

        private void buttonGetJalaliMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateUtil.GetJalaliMonthName_switch(DateTime.Now));
            MessageBox.Show(DateTime.Now.GetJalaliMonthName_switch());
        }

        private void btnJalaliToMiladi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateUtil.JalaliToMiladi("1401/10/19").ToLongDateString());
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            //int days;
            //DateUtil.ToJalaliAndDays_out(new DateTime(2001, 11, 9), out days);


            var jalali = DateUtil.ToJalaliAndDays_out(new DateTime(2001, 11, 9), out int days);
            MessageBox.Show($"date: {jalali}, days: {days}");
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {

            //Convert.ToInt32()
            //if (int.TryParse("sdfh", out int result))
            //{
            //    result
            //}

            int days = 0;
            var jalali = DateUtil.ToJalaliAndDays_ref(new DateTime(2001, 11, 9), ref days);
            MessageBox.Show($"date: {jalali}, days: {days}");
        }
    }

}