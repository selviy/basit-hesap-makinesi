namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1 = 0, sayi2 = 0, sayici = 0;
        string s1 = "0", s2 = "0", op;

        void islem()
        {
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            if (op == "+")
            {
                sayi1 += sayi2;
                textBox1.Text = Convert.ToString(sayi1);
                s1 = "0"; s2 = "0";
                s1 = Convert.ToString(sayi1);
                sayi1 = 0; sayi2 = 0;
            }
            else if (op == "-")
            {
                sayi1 -= sayi2;
                textBox1.Text = Convert.ToString(sayi1);
                s1 = "0"; s2 = "0";
                s1 = Convert.ToString(sayi1);
                sayi1 = 0; sayi2 = 0;
            }
            else if (op == "*")
            {
                sayi1 *= sayi2;
                textBox1.Text = Convert.ToString(sayi1);
                s1 = "0"; s2 = "0";
                s1 = Convert.ToString(sayi1);
                sayi1 = 0; sayi2 = 0;
            }
            else if (op == "/")
            {
                if (sayi2 != 0)
                {
                    sayi1 /= sayi2;
                    textBox1.Text = Convert.ToString(sayi1);
                    s1 = "0"; s2 = "0";
                    s1 = Convert.ToString(sayi1);
                    sayi1 = 0; sayi2 = 0;
                }
                else
                    MessageBox.Show("sýfýra bölme hatasý");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            if (sayici == 0)
            {
                s1 += "1";
            }
            else if (sayici == 1)
            {
                s2 += "1";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            if (sayici == 0)
            {
                s1 += "2";
            }
            else if (sayici == 1)
            {
                s2 += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            if (sayici == 0)
            {
                s1 += "3";
            }
            else if (sayici == 1)
            {
                s2 += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            if (sayici == 0)
            {
                s1 += "4";
            }
            else if (sayici == 1)
            {
                s2 += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            if (sayici == 0)
            {
                s1 += "5";
            }
            else if (sayici == 1)
            {
                s2 += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            if (sayici == 0)
            {
                s1 += "6";
            }
            else if (sayici == 1)
            {
                s2 += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            if (sayici == 0)
            {
                s1 += "7";
            }
            else if (sayici == 1)
            {
                s2 += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            if (sayici == 0)
            {
                s1 += "8";
            }
            else if (sayici == 1)
            {
                s2 += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            if (sayici == 0)
            {
                s1 += "9";
            }
            else if (sayici == 1)
            {
                s2 += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            if (sayici == 0)
            {
                s1 += "0";
            }
            else if (sayici == 1)
            {
                s2 += "0";
            }
        }

        private void button15C_Click(object sender, EventArgs e)
        {// C
            textBox1.Text = "";
            sayi1 = 0; sayi2 = 0; sayici = 0;
            s1 = "0"; s2 = "0";
        }
        private void button11a_Click(object sender, EventArgs e)
        {    // +        
            if(sayici==0)
            {
                textBox1.Text += "+";
                sayici++;
            }
            else if (sayici==1)
            {
                islem();
                textBox1.Text += "+";
            }
            op = "+";

        }

        private void button12e_Click(object sender, EventArgs e)
        { // -           
            if (sayici == 0)
            {
                textBox1.Text += "-";
                sayici++;
            }
            else if (sayici == 1)
            {
                islem();
                textBox1.Text += "-";
            }
            op = "-";
        }

        private void button13c_Click(object sender, EventArgs e)
        {// *
            if (sayici == 0)
            {
                textBox1.Text += "*";
                sayici++;
            }
            else if (sayici == 1)
            {
                islem();
                textBox1.Text += "*";
            }
            op = "*";
        }

        private void button14b_Click(object sender, EventArgs e)
        {// /
            if (sayici == 0)
            {
                textBox1.Text += "/";
                sayici++;
            }
            else if (sayici == 1)
            {
                islem();
                textBox1.Text += "/";
            }
            op = "/";
        }
        private void button16esit_Click(object sender, EventArgs e)
        {//=
            islem();
            
            op = "";
            sayici = 0;
        }
    }
}