using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labaform3
{
    public partial class Regictrasia : Form
    {
        public Regictrasia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"@");
            string str = textBox3.Text;
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                MessageBox.Show("Емайл верен");
            }
            else
            {
                MessageBox.Show("Емайл неверный");
            }
            if (textBox5.Text == textBox6.Text)
            {
                MessageBox.Show("Вы зарегистрированы");
            }
            else
            {
                MessageBox.Show("Пароль не совпадает");
            }
            
        }
    }
}
