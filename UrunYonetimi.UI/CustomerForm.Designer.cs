namespace UrunYonetimi.UI
{
    partial class CustomerForm
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
            dgwCustomer = new DataGridView();
            cmsCustomer = new ContextMenuStrip(components);
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCustomerName = new TextBox();
            txtCustomerPhoneNumber = new TextBox();
            txtCustomerAdress = new TextBox();
            btnCustomerAdd = new Button();
            btnCustomerUpdate = new Button();
            lblCustomerId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwCustomer).BeginInit();
            cmsCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // dgwCustomer
            // 
            dgwCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCustomer.ContextMenuStrip = cmsCustomer;
            dgwCustomer.Location = new Point(12, 204);
            dgwCustomer.MultiSelect = false;
            dgwCustomer.Name = "dgwCustomer";
            dgwCustomer.ReadOnly = true;
            dgwCustomer.RowTemplate.Height = 25;
            dgwCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwCustomer.Size = new Size(474, 317);
            dgwCustomer.TabIndex = 0;
            // 
            // cmsCustomer
            // 
            cmsCustomer.Items.AddRange(new ToolStripItem[] { güncelleToolStripMenuItem, silToolStripMenuItem });
            cmsCustomer.Name = "cmsCustomer";
            cmsCustomer.Size = new Size(121, 48);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Şirket Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Adres :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "İletişim :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(81, 6);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(405, 23);
            txtCustomerName.TabIndex = 4;
            // 
            // txtCustomerPhoneNumber
            // 
            txtCustomerPhoneNumber.Location = new Point(81, 104);
            txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            txtCustomerPhoneNumber.Size = new Size(405, 23);
            txtCustomerPhoneNumber.TabIndex = 6;
            // 
            // txtCustomerAdress
            // 
            txtCustomerAdress.Location = new Point(81, 35);
            txtCustomerAdress.Multiline = true;
            txtCustomerAdress.Name = "txtCustomerAdress";
            txtCustomerAdress.Size = new Size(405, 63);
            txtCustomerAdress.TabIndex = 5;
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnCustomerAdd.Location = new Point(296, 133);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(92, 65);
            btnCustomerAdd.TabIndex = 7;
            btnCustomerAdd.Text = "EKLE";
            btnCustomerAdd.UseVisualStyleBackColor = false;
            btnCustomerAdd.Click += btnCustomerAdd_Click;
            // 
            // btnCustomerUpdate
            // 
            btnCustomerUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnCustomerUpdate.Location = new Point(394, 133);
            btnCustomerUpdate.Name = "btnCustomerUpdate";
            btnCustomerUpdate.Size = new Size(92, 65);
            btnCustomerUpdate.TabIndex = 7;
            btnCustomerUpdate.Text = "GÜNCELLE";
            btnCustomerUpdate.UseVisualStyleBackColor = false;
            btnCustomerUpdate.Click += btnCustomerUpdate_Click;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Location = new Point(17, 144);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(38, 15);
            lblCustomerId.TabIndex = 8;
            lblCustomerId.Text = "label4";
            lblCustomerId.Visible = false;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 598);
            Controls.Add(lblCustomerId);
            Controls.Add(btnCustomerUpdate);
            Controls.Add(btnCustomerAdd);
            Controls.Add(txtCustomerPhoneNumber);
            Controls.Add(txtCustomerAdress);
            Controls.Add(txtCustomerName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgwCustomer);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCustomer).EndInit();
            cmsCustomer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwCustomer;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCustomerName;
        private TextBox txtCustomerPhoneNumber;
        private TextBox txtCustomerAdress;
        private Button btnCustomerAdd;
        private Button btnCustomerUpdate;
        private ContextMenuStrip cmsCustomer;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private Label lblCustomerId;
    }
}