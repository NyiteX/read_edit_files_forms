using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Basic_Window : Form
    {
        Point p;
        Thread thread;
        bool changes = false;
        string path = "";
        public Basic_Window()
        {
            InitializeComponent();
            edit_Button.BackColor = Color.FromArgb(80, 255, 255, 255);
        }

        //Basic_Window
        private void Basic_Window_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
        }
        private void Basic_Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - p.X;
                Top += e.Y - p.Y;
            }
        }

        //Basic_buttons
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Minimize_Button.BorderStyle = BorderStyle.Fixed3D;
            Minimize_Button.BackColor = Color.Khaki;
            X_Button.BorderStyle = BorderStyle.FixedSingle;
            X_Button.BackColor = Color.WhiteSmoke;
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Minimize_Button.BorderStyle = BorderStyle.FixedSingle;
            Minimize_Button.BackColor = Color.WhiteSmoke;           
        }
        private void label1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void X_Button_MouseEnter(object sender, EventArgs e)
        {
            X_Button.BorderStyle = BorderStyle.Fixed3D;
            X_Button.BackColor = Color.Tomato;
            Minimize_Button.BorderStyle = BorderStyle.FixedSingle;
            Minimize_Button.BackColor = Color.WhiteSmoke;
        }
        private void X_Button_MouseLeave(object sender, EventArgs e)
        {
            X_Button.BorderStyle = BorderStyle.FixedSingle;
            X_Button.BackColor = Color.WhiteSmoke;
        }
        private void X_Button_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Abort();
            }
            catch (Exception) { }
            Close();
        }

        //My funcs

        private void open(object sender, EventArgs e)
        {
            thread = new Thread(() =>
            {
                Basic_Window form = new Basic_Window();

                System.Windows.Forms.Application.Run(form);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void SaveAS_File(object sender, EventArgs e)
        {
            Form2 tmpForm = new Form2(0);
            tmpForm.Str = textBox1.Text;
            tmpForm.Show();
        }
        private void File_Open(object sender, EventArgs e)
        {
            Form2 form = new Form2(1);
            form.Str = textBox1.Text;
            form.ShowDialog();
            textBox1.Text = form.Str;
            path = form.textBox1.Text;
            changes = form.f;
        }
        private void load_Button_Click(object sender, EventArgs e)
        {
            File_Open(sender,e);
            if(changes)
            {
                edit_Button.BackColor = load_Button.BackColor;
            }
        }

        private void edit_Button_Click(object sender, EventArgs e)
        {
            if(changes)
            {
                Form4 form = new Form4();
                form.label1.Text = path;
                form.textBox1.Text = textBox1.Text;
                form.ShowDialog();
                if (!form.f)
                {
                    textBox1.Text = "";
                    edit_Button.BackColor = Color.FromArgb(80, 255, 255, 255);
                    changes = form.f;
                }
            }
        }
    }
}
