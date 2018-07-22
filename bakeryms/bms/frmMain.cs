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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            frmPurchase f3 = new frmPurchase();
            f3.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales sales = new frmSales();
            sales.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock stock = new frmStock();
            stock.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void oleDbConnection1_InfoMessage(object sender, OleDbInfoMessageEventArgs e)
        {

        }
    }
}
