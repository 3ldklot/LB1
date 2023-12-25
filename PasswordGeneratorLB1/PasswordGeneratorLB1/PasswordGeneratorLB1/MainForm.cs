using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGeneratorLB1
{
    public partial class MainForm : Form
    {
        
        Password password = new Password();

        public MainForm()
        {
            InitializeComponent();
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.setSS(checkUseSpecialSymbols.Checked);
            label1.Visible = password.countPasswordPower();
            labelWarningMessage.Visible = !password.countPasswordPower();

        }
        public void сheckBoxUseDigits_CheckedChanged(object sender, EventArgs e)
        {
            password.setDig(checkBoxUseDigits.Checked);
            label1.Visible = password.countPasswordPower();
            labelWarningMessage.Visible = !password.countPasswordPower();
        }

        public void checkBoxUseLowercaseLetters_CheckedChanged(object sender, EventArgs e)
        {
            password.setDownC(checkBoxUseLowercaseLetters.Checked);
            label1.Visible = password.countPasswordPower();
            labelWarningMessage.Visible = !password.countPasswordPower();
        }

        public void checkBoxUseUppercaseLetters_CheckedChanged(object sender, EventArgs e)
        {
            password.setUpC(checkBoxUseUppercaseLetters.Checked);
            label1.Visible = password.countPasswordPower();
            labelWarningMessage.Visible = !password.countPasswordPower();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxUseUppercaseLetters.Checked | checkBoxUseLowercaseLetters.Checked | checkBoxUseDigits.Checked | checkUseSpecialSymbols.Checked)
            {
                labelPasswordCopiedToClipboard.Hide();
                timerShowLabelCopiedToClipboard.Stop();
                textBoxGeneratedPassword.Text = "";
                textBoxGeneratedPassword.Text = password.genRndPassword();
                Clipboard.SetText(textBoxGeneratedPassword.Text);

                labelPasswordCopiedToClipboard.Show();
                timerShowLabelCopiedToClipboard.Start();

                StreamWriter sw = new StreamWriter("Test.txt");
                sw.WriteLine(textBoxGeneratedPassword.Text);
                sw.Close();
            }
            else textBoxGeneratedPassword.Text = "Выберите хотя бы один набор символов";

        }

        private void timerShowLabelCopiedToClipboard_Tick(object sender, EventArgs e)
        {
            labelPasswordCopiedToClipboard.Hide();
            timerShowLabelCopiedToClipboard.Stop();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelPasswordLengthValue.Text = trackBarPasswordLength.Value.ToString();
        }

        private void trackBarPasswordLength_ValueChanged(object sender, EventArgs e)
        {
            password.setLength(trackBarPasswordLength.Value);
            label1.Visible = password.countPasswordPower();
            labelWarningMessage.Visible = !password.countPasswordPower();
            labelPasswordLengthValue.Text = trackBarPasswordLength.Value.ToString();
        }

        private void labelWarningMessage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelWarningMessageTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
