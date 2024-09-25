using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Witaj w tym programie\n";
            string choosenResault = " ";
            string myName = " ";

            message += "Ulubione przedmioty\n";

            if (checkBoxMath.Checked)
            {
                message += "Matematyka\n";
                choosenResault += "Matematyka\n";
                resault.Text = choosenResault;
            }
            if (checkBoxPolish.Checked)
            {
                message += "Polski\n";
                choosenResault += "Polski\n";
                resault.Text = choosenResault;
            }
            if (checkBoxWebDevelopment.Checked)
            {
                message += "Witryny Internetowe\n";
                choosenResault += "Witryny Internetowe\n";
                resault.Text = choosenResault;
            }

            if (radioButtonPizzaNo.Checked)
            {
                pizzaResault.Text = "Nie";
            }
            else
            {
                pizzaResault.Text = "Tak";
            }

            myName += textBoxName.Text + "\n";
            labelName.Text = myName;

            if (comboBox1.SelectedIndex != -1)
            {
                message += " Ulubiona gra to "
                    + comboBox1.Text + "\n";
            }

            MessageBox.Show("Witaj w tym programie",
            "Hello",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button2
            );

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxMath_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}