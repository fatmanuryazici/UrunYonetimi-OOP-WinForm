namespace UrunYonetimi.UI
{
    partial class OrderForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtOrderDescription = new TextBox();
            nudOrderTotalPrice = new NumericUpDown();
            cbCustomer = new ComboBox();
            dgwOrder = new DataGridView();
            cmsOrder = new ContextMenuStrip(components);
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            btnOrderAdd = new Button();
            btnOrderUpdate = new Button();
            lblOrderId = new Label();
            ((System.ComponentModel.ISupportInitialize)nudOrderTotalPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwOrder).BeginInit();
            cmsOrder.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Açıklama :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Toplam Tutar :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Müşteri :";
            // 
            // txtOrderDescription
            // 
            txtOrderDescription.Location = new Point(100, 35);
            txtOrderDescription.Multiline = true;
            txtOrderDescription.Name = "txtOrderDescription";
            txtOrderDescription.Size = new Size(197, 61);
            txtOrderDescription.TabIndex = 3;
            // 
            // nudOrderTotalPrice
            // 
            nudOrderTotalPrice.Location = new Point(100, 102);
            nudOrderTotalPrice.Name = "nudOrderTotalPrice";
            nudOrderTotalPrice.Size = new Size(197, 23);
            nudOrderTotalPrice.TabIndex = 8;
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(100, 6);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(197, 23);
            cbCustomer.TabIndex = 5;
            // 
            // dgwOrder
            // 
            dgwOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOrder.ContextMenuStrip = cmsOrder;
            dgwOrder.Location = new Point(12, 131);
            dgwOrder.MultiSelect = false;
            dgwOrder.Name = "dgwOrder";
            dgwOrder.ReadOnly = true;
            dgwOrder.RowTemplate.Height = 25;
            dgwOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwOrder.Size = new Size(447, 150);
            dgwOrder.TabIndex = 6;
            // 
            // cmsOrder
            // 
            cmsOrder.Items.AddRange(new ToolStripItem[] { güncelleToolStripMenuItem, silToolStripMenuItem });
            cmsOrder.Name = "cmsOrder";
            cmsOrder.Size = new Size(121, 48);
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(120, 22);
            güncelleToolStripMenuItem.Text = "Güncelle";
            güncelleToolStripMenuItem.Click += güncelleToolStripMenuItem_Click;
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(120, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // btnOrderAdd
            // 
            btnOrderAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnOrderAdd.Location = new Point(303, 69);
            btnOrderAdd.Name = "btnOrderAdd";
            btnOrderAdd.Size = new Size(75, 56);
            btnOrderAdd.TabIndex = 7;
            btnOrderAdd.Text = "EKLE";
            btnOrderAdd.UseVisualStyleBackColor = false;
            btnOrderAdd.Click += btnOrderAdd_Click;
            // 
            // btnOrderUpdate
            // 
            btnOrderUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnOrderUpdate.Location = new Point(384, 69);
            btnOrderUpdate.Name = "btnOrderUpdate";
            btnOrderUpdate.Size = new Size(75, 56);
            btnOrderUpdate.TabIndex = 7;
            btnOrderUpdate.Text = "GÜNCELLE";
            btnOrderUpdate.UseVisualStyleBackColor = false;
            btnOrderUpdate.Click += btnOrderUpdate_Click;
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(12, 69);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(38, 15);
            lblOrderId.TabIndex = 9;
            lblOrderId.Text = "label4";
            lblOrderId.Visible = false;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOrderId);
            Controls.Add(btnOrderUpdate);
            Controls.Add(btnOrderAdd);
            Controls.Add(dgwOrder);
            Controls.Add(cbCustomer);
            Controls.Add(nudOrderTotalPrice);
            Controls.Add(txtOrderDescription);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudOrderTotalPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwOrder).EndInit();
            cmsOrder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtOrderDescription;
        private NumericUpDown nudOrderTotalPrice;
        private ComboBox cbCustomer;
        private DataGridView dgwOrder;
        private Button btnOrderAdd;
        private Button btnOrderUpdate;
        private ContextMenuStrip cmsOrder;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private Label lblOrderId;
    }
}