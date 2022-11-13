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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp9
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Point p;
        public bool f = true;
        private async void button1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(label1.Text))
            {
                using (StreamWriter F = new StreamWriter(label1.Text))
                {
                    await F.WriteLineAsync(textBox1.Text);
                }
                MessageBox.Show("Изменено");
                f = false;
            }
            else
                MessageBox.Show("Не найдено");

            Close();
        }

        private void X_Button_MouseEnter(object sender, EventArgs e)
        {
            X_Button.BorderStyle = BorderStyle.Fixed3D;
            X_Button.BackColor = Color.Thistle;
        }
        private void X_Button_MouseLeave(object sender, EventArgs e)
        {
            X_Button.BorderStyle = BorderStyle.FixedSingle;
            X_Button.BackColor = Color.WhiteSmoke;
        }
        private void X_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
        }
        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - p.X;
                Top += e.Y - p.Y;
            }
        }
    }
}
