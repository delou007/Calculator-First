namespace Calculator_First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calcTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button4.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button7.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button9.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + button0.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            option = " + ";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            option = " / ";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            option = " * ";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            option = " - ";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void buttonEql_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);

            if (option.Equals(" + "))
            {
                result = num1 + num2;
            }

            else if (option.Equals(" - "))
            {
                result = num1 - num2;
            }

            else if (option.Equals(" * "))
            {
                result = num1 * num2;
            }
            else if (option.Equals(" / "))
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    MessageBox.Show("You can't divide by 0!");
                }
            }

            txtTotal.Text = result + "";
            /*switch (option) 
            {
                case (option = " + "):
                    result = num1 + num2;
                    break;
            }*/
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMan.Checked)
            {
                MessageBox.Show("You are male.");
            }
        }

        private void checkBoxWoman_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWoman.Checked)
            {
                MessageBox.Show("You are female.");
            }
        }
    }
}
