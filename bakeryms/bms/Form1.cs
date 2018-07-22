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
    public partial class frmitmupdate : Form
    {
        frmMain f2 = new frmMain();
        public frmitmupdate()
        {
            InitializeComponent();
        }

        private void frmitmupdate_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update items set I_Name=@I_Name,I_TP=@I_TP,I_RT=@I_RT where I_ID='"+comboBox1+"'",f2.oleDbConnection1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("items updated");
            f2.oleDbConnection1.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
