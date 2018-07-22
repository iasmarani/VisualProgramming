namespace bms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPurchase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSales = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStock = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdmin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.btnPurchase,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.btnSales,
            this.toolStripSeparator3,
            this.btnStock,
            this.toolStripSeparator5,
            this.btnAdmin,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(895, 86);
            this.toolStrip2.TabIndex = 26;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 86);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Image = global::bms.Properties.Resources.if_1_12_511567__1_;
            this.btnPurchase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPurchase.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(68, 83);
            this.btnPurchase.Tag = "2";
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 86);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 83);
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnSales
            // 
            this.btnSales.Image = global::bms.Properties.Resources.if_1_10_511565;
            this.btnSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSales.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(68, 83);
            this.btnSales.Tag = "2";
            this.btnSales.Text = "Sales";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 86);
            // 
            // btnStock
            // 
            this.btnStock.Image = global::bms.Properties.Resources.if_palet02_62584;
            this.btnStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStock.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(67, 83);
            this.btnStock.Tag = "2";
            this.btnStock.Text = "Stock";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 86);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Image = global::bms.Properties.Resources.if_admin_87402;
            this.btnAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdmin.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(68, 83);
            this.btnAdmin.Tag = "2";
            this.btnAdmin.Text = "Vendor";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 86);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::bms.Properties.Resources.if_exit_3226;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 83);
            this.toolStripButton1.Tag = "2";
            this.toolStripButton1.Text = "Logout";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::bms.Properties.Resources.SEO_and_Internet_Marketing_49_5121;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 83);
            this.toolStripButton2.Tag = "2";
            this.toolStripButton2.Text = "Customer";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 86);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(895, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=SQLOLEDB;Data Source=(local);Integrated Security=SSPI;Initial Catalog=bm" +
                "s";
            this.oleDbConnection1.InfoMessage += new System.Data.OleDb.OleDbInfoMessageEventHandler(this.oleDbConnection1_InfoMessage);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bms.Properties.Resources._635896582;
            this.ClientSize = new System.Drawing.Size(895, 464);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakery Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnPurchase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnSales;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnStock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAdmin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        public System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}