namespace UrunYonetimi.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            msCustomer = new MenuStrip();
            müşterilerToolStripMenuItem1 = new ToolStripMenuItem();
            ürünlerToolStripMenuItem = new ToolStripMenuItem();
            kategoriToolStripMenuItem = new ToolStripMenuItem();
            siparişToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            msCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // msCustomer
            // 
            msCustomer.Items.AddRange(new ToolStripItem[] { müşterilerToolStripMenuItem1, ürünlerToolStripMenuItem, kategoriToolStripMenuItem, siparişToolStripMenuItem });
            msCustomer.Location = new Point(0, 0);
            msCustomer.Name = "msCustomer";
            msCustomer.Size = new Size(724, 24);
            msCustomer.TabIndex = 1;
            msCustomer.Text = "menuStrip1";
            msCustomer.ItemClicked += msCustomer_ItemClicked;
            // 
            // müşterilerToolStripMenuItem1
            // 
            müşterilerToolStripMenuItem1.Name = "müşterilerToolStripMenuItem1";
            müşterilerToolStripMenuItem1.Size = new Size(72, 20);
            müşterilerToolStripMenuItem1.Text = "Müşteriler";
            
            // 
            // ürünlerToolStripMenuItem
            // 
            ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            ürünlerToolStripMenuItem.Size = new Size(58, 20);
            ürünlerToolStripMenuItem.Text = "Ürünler";
            ürünlerToolStripMenuItem.Click += ürünlerToolStripMenuItem_Click;
            // 
            // kategoriToolStripMenuItem
            // 
            kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            kategoriToolStripMenuItem.Size = new Size(63, 20);
            kategoriToolStripMenuItem.Text = "Kategori";
            kategoriToolStripMenuItem.Click += kategoriToolStripMenuItem_Click;
            // 
            // siparişToolStripMenuItem
            // 
            siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            siparişToolStripMenuItem.Size = new Size(53, 20);
            siparişToolStripMenuItem.Text = "Sipariş";
            
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(670, 435);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 474);
            Controls.Add(pictureBox1);
            Controls.Add(msCustomer);
            MainMenuStrip = msCustomer;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            msCustomer.ResumeLayout(false);
            msCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip cmsMain;
        private ToolStripMenuItem müşterilerToolStripMenuItem;
        private MenuStrip msCustomer;
        private ToolStripMenuItem müşterilerToolStripMenuItem1;
        private ToolStripMenuItem ürünlerToolStripMenuItem;
        private ToolStripMenuItem kategoriToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem siparişToolStripMenuItem;
    }
}
