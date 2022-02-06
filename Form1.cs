using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int toplam1=0, toplam2;

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a=random.Next(1,7);
            b=random.Next(1,7);
            label3.Text = a.ToString();
            label4.Text = b.ToString();
            toplam1 =toplam1+a+ b;
            label11.Text = toplam1.ToString();
            if (a == 1) pictureBox1.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\1.png";
            else if (a == 2) pictureBox1.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\2.png";
            else if (a == 3) pictureBox1.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\3.png";
            else if (a == 4) pictureBox1.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\4.png";
            else if (a == 5) pictureBox1.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\5.png";
            else if (a == 6) pictureBox1.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\6.png";
            
            if (b == 1) pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\1.png";
            else if (b == 2) pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\2.png";
            else if (b == 3) pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\3.png";
            else if (b == 4) pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\4.png";
            else if (b == 5) pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\5.png";
            else if (b == 6) pictureBox2.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\6.png";
            if (toplam1 > toplam2 && toplam1 >= 40) MessageBox.Show("1.PC WIN");
            else if (toplam2 > toplam1 && toplam2 >= 40) MessageBox.Show("2.PC WIN");
            button1.Enabled = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c, d;
            c = random.Next(1, 7);
            d = random.Next(1, 7);
            label7.Text = c.ToString();
            label6.Text = d.ToString();
            toplam2 = toplam2 + c + d;
            label10.Text = toplam2.ToString();
            if (c == 1) pictureBox3.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\1.png";
            else if (c == 2) pictureBox3.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\2.png";
            else if (c == 3) pictureBox3.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\3.png";
            else if (c == 4) pictureBox3.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\4.png";
            else if (c == 5) pictureBox3.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\5.png";
            else if (c == 6) pictureBox3.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\6.png";

            if (d == 1) pictureBox4.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\1.png";
            else if (d == 2) pictureBox4.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\2.png";
            else if (d == 3) pictureBox4.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\3.png";
            else if (d == 4) pictureBox4.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\4.png";
            else if (d == 5) pictureBox4.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\5.png";
            else if (d == 6) pictureBox4.ImageLocation = "D:\\Documents\\Visual Studio 2019\\C# FORM\\Zar Oyunu\\6.png";
            if (toplam1 > toplam2 && toplam1 >= 40) MessageBox.Show("1.PC WIN");
            else if (toplam2 > toplam1 && toplam2 >= 40) MessageBox.Show("2.PC WIN");
            button2.Enabled = false;
            button1.Enabled = true;
        }
    }
}
