using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace erp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text == "asma" && this.textBox2.Text == "asma1")
            {
                Form7 f7 = new Form7();
                f7.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("incorrect id or passsword");
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.button1;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }

        
    }
}
