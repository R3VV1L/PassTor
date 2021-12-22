using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Password
        {
            public string Pass()
            {
                int[] pass = new int[16];
                Random random = new Random();
                string passw = " ";

                for (int i = 0; i <= 10; i++)
                {
                    pass[i] = random.Next(33, 125);
                    passw += (char)pass[i]; //char как символ элемента кода
                }
                return passw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Password A = new Password();
            var password = A.Pass();
            textBox1.Text = password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
