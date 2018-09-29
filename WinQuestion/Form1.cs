using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinQuestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Проверочка как работает репозюторючка от Гитхабчика
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text == "Привет" || textBox1.Text == "Здарова" || textBox1.Text == "Ку")
                label3.Visible = true;
                label3.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
                btnYes.Text = "Да";
                btnNo.Text = "Нет";
                label1.Text = "Вы довольны своей зарплатой?";
            button3.Enabled = false;
            button3.Visible = false;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я и не сомневался, что ты так думать брат!");
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            btnNo.Top -= e.Y;
            btnNo.Left += e.X;
            if (btnNo.Top < -10 || btnNo.Top > 100)
                btnNo.Top = 60;
            if (btnNo.Left < -80 || btnNo.Left > 250)
                btnNo.Left = 120;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            label1.Text = "Попал по кнопочке, умница какой.";
        }
    }
}
