using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labaform3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =
                new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, button7.Width, button7.Height);
            Region myRegion = new Region(myPath);
            button7.Region = myRegion;

            System.Drawing.Drawing2D.GraphicsPath myPath2 =
            new System.Drawing.Drawing2D.GraphicsPath();
            myPath2.AddEllipse(0, 0, button7.Width, button7.Height);
            Region myRegion2 = new Region(myPath2);
            button12.Region = myRegion2;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show(button.Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Otzivi otzivi = new Otzivi();
            otzivi.Show();
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            Regictrasia regictrasia = new Regictrasia();
            regictrasia.Show();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            Autorizacia autorizacia = new Autorizacia();
            autorizacia.Show();
        }
    }
}
