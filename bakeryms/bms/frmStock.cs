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
    public partial class frmStock : Form
    {
        frmMain f2 = new frmMain();
        public frmStock()
        {
            
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select I_ID from items", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["I_ID"].ToString());
            }
            f2.oleDbConnection1.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cm = new OleDbCommand("select * from items where I_ID='"+comboBox1.Text+"'",f2.oleDbConnection1);
            OleDbDataReader d = cm.ExecuteReader();
            if (d.Read())
            {
                textBox1.Text = d["I_Name"].ToString();
                textBox2.Text = d["I_QTY"].ToString();
                textBox3.Text = d["I_TP"].ToString();
                textBox4.Text = d["I_RT"].ToString();
                
                
            }
            f2.oleDbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cm1 = new OleDbCommand("select * from items ", f2.oleDbConnection1);
            OleDbDataReader d1 = cm1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(d1);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into items(I_ID,I_Name,I_QTY,I_TP,I_RT)values(@I_ID,@I_Name,@I_QTY,@I_TP,@I_RT)",f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@I_ID",Convert.ToInt32(textBox5.Text));
            cmd.Parameters.AddWithValue("@I_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@I_QTY",textBox2.Text);
            cmd.Parameters.AddWithValue("@I_TP",textBox3.Text);
            cmd.Parameters.AddWithValue("@I_RT",textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("record inserted");
            f2.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cm2 = new OleDbCommand("update items set I_QTY=@I_QTY,I_TP=@I_TP,I_RT=@I_RT where I_ID='", f2.oleDbConnection1);
            cm2.Parameters.AddWithValue("@I_Name", textBox1.Text);
            cm2.Parameters.AddWithValue("@I_QTY", textBox2.Text);
            cm2.Parameters.AddWithValue("@I_TP", textBox3.Text);
            cm2.Parameters.AddWithValue("@I_RT", textBox4.Text);
            cm2.ExecuteNonQuery();
            MessageBox.Show("record updated");
            f2.oleDbConnection1.Close();

        }
    }
}
