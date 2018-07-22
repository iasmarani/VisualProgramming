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
    public partial class frmAdmin : Form
    {
        frmMain f2 = new frmMain();
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from vendor",f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            f2.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into vendor(V_ID,V_Name,V_PNO,V_CMP,V_ADD,V_Email)values(@V_ID,@V_Name,@V_PNO,@V_CMP,@V_ADD,@V_Email)", f2.oleDbConnection1);
           
            cmd.Parameters.AddWithValue("@V_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@V_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@V_PNO", textBox3.Text);
            cmd.Parameters.AddWithValue("@V_CMP", textBox4.Text);
             cmd.Parameters.AddWithValue("@V_ADD", textBox5.Text);
             cmd.Parameters.AddWithValue("@V_Email", textBox5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("record inserted");
            f2.oleDbConnection1.Close();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
