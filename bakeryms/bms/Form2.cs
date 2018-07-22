using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace bms
{
    public partial class Form2 : Form
    {
        frmMain f2 = new frmMain();
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from customer", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            f2.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into vendor(C_ID,C_Name,C_PNO,C_ADD,C_Email)values(@C_ID,@C_Name,@C_PNO,@C_ADD,@C_Email)", f2.oleDbConnection1);

            cmd.Parameters.AddWithValue("@C_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@C_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@C_PNO", textBox3.Text);
            cmd.Parameters.AddWithValue("@C_ADD", textBox4.Text);
            cmd.Parameters.AddWithValue("@C_Email", textBox5.Text);
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("record inserted");
            f2.oleDbConnection1.Close();
        }
    }
}
