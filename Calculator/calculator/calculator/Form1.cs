using System;
using System.Text;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a = 0; double b = 0;
        char c = 'A';
        string[] num = new string[9999];
        double fnum;
        int count = 0;
        double ans;



        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn1.Text;
            num[count] = "1";
            count++;
            b = a;
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn2.Text;
            num[count] = "2";
            count++;
            b = a;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn3.Text;
            num[count] = "3";
            count++;
            b = a;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn4.Text;
            num[count] = "4";
            count++;
            b = a;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn5.Text;
            num[count] = "5";
            count++;
            b = a;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn6.Text;
            num[count] = "6";
            count++;
            b = a;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn7.Text;
            num[count] = "7";
            count++;
            b = a;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn8.Text;
            num[count] = "8";
            count++;
            b = a;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn9.Text;
            num[count] = "9";
            count++;
            b = a;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn0.Text;
            num[count] = "0";
            count++;
            b = a;


        }
        private void btnans_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + Convert.ToString(ans);
            num[count] = Convert.ToString(ans);
            count++;
            b = a;

        }
        private void btnnmin_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btnnmin.Text;
            num[count] = "-";
            count++;
            b = a;
        }
        private void btnpi_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            txtTotal.Text = txtTotal.Text + Convert.ToString(pi);
            num[count] = Convert.ToString(pi);
            count++;
            b = a;

        }


        private void btneql_Click(object sender, EventArgs e)
        {

            txtTotal.Clear();
            string answer;
            double d;


            StringBuilder sb = new StringBuilder();
            foreach (string str in num)
            {
                sb.Append(str);
            }

            string result = sb.ToString();

            b = Convert.ToDouble(result);
            txtTotal.Clear();
            if (c == '+')
            {
                d = a + b;
                ans = d;
                answer = Convert.ToString(d);
                txtTotal.Text = answer;
            }
            if (c == '-')
            {
                d = a - b;
                ans = d;
                answer = Convert.ToString(d);
                txtTotal.Text = answer;
            }
            if (c == '*')
            {
                d = a * b;
                ans = d;
                answer = Convert.ToString(d);
                txtTotal.Text = answer;
            }
            if (c == '/')
            {
                d = a / b;
                ans = d;
                answer = Convert.ToString(d);
                txtTotal.Text = answer;
            }
            if (c == 'h')
            {
                d = Math.Pow(a, b); ;
                answer = Convert.ToString(d);
                ans = d;
                txtTotal.Text = answer;
            }
            if (c == 'r')
            {
                d = Math.Pow(a, 1.0 / b); ;
                answer = Convert.ToString(d);
                ans = d;
                txtTotal.Text = answer;
            }



            Array.Clear(num, 0, num.Length);
            count = 0;
            a = 0;
            b = 0;
            c = '0';


        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            c = '+';
            StringBuilder sb = new StringBuilder();
            foreach (string str in num)
            {
                sb.Append(str);
            }

            string result = sb.ToString();
            a = Convert.ToDouble(result);
            Array.Clear(num, 0, num.Length);
            count = 0;

        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            c = '-';
            StringBuilder sb = new StringBuilder();
            foreach (string str in num)
            {
                sb.Append(str);
            }

            string result = sb.ToString();
            a = Convert.ToDouble(result);
            Array.Clear(num, 0, num.Length);
            count = 0;

        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            c = '/';
            StringBuilder sb = new StringBuilder();
            foreach (string str in num)
            {
                sb.Append(str);
            }

            string result = sb.ToString();
            a = Convert.ToDouble(result);
            Array.Clear(num, 0, num.Length);
            count = 0;
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            c = '*';
            StringBuilder sb = new StringBuilder();
            foreach (string str in num)
            {
                sb.Append(str);
            }

            string result = sb.ToString();
            a = Convert.ToDouble(result);
            Array.Clear(num, 0, num.Length);
            count = 0;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            a = 0;
            b = 0;
            Array.Clear(num, 0, num.Length);
            count = 0;
            c = '0';
        }

        private void btnttpo_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            c = 'h';
            StringBuilder sb = new StringBuilder();
            foreach (string str in num)
            {
                sb.Append(str);
            }

            string result = sb.ToString();
            a = Convert.ToDouble(result);
            Array.Clear(num, 0, num.Length);
            count = 0;

        }

        private void btnqr_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            c = 'r';
            StringBuilder sb = new StringBuilder();
            foreach (string str in num)
            {
                sb.Append(str);
            }

            string result = sb.ToString();
            a = Convert.ToDouble(result);
            Array.Clear(num, 0, num.Length);
            count = 0;

        }

       
    }
}