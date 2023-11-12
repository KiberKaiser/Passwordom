using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form : System.Windows.Forms.Form
    {
        Point point;
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
        public string PasswordGeneration(bool lowerCase, bool upperCase, bool Numberic, bool specialCharacter, int length)
        {
            string Numbers = "1234567890";
            string LowerCase = "abcdefghijklmnopqrstuvwxyz";
            string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string SpecialSymbols = "!@#$%&~()";

            char[] password = new char[length];
            string charSet = "";
            Random PasswordRandom = new Random();
            if (lowerCase)
                charSet += LowerCase;
            if (upperCase)
                charSet += Uppercase;
            if (Numberic)
                charSet += Numbers;
            if (specialCharacter)
                charSet += SpecialSymbols;

            for (int i = 0; i < length; i++)
            {
                password[i] = charSet[PasswordRandom.Next(charSet.Length - 1)];
            }
            return string.Join(null, password);
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCover_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            try{
                TextBox.Text = PasswordGeneration(LowerCaseBox.Checked, UpperCaseBox.Checked, NumbericBox.Checked, SpecialSymbolsBox.Checked, int.Parse(LengthBox.Text));
            }
            catch
            {
                MessageBox.Show("The length of password is empty! Please, enter the number.", "Error of length password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            base.OnMouseMove(e);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }
    }
}
