namespace UrunYonetimi.UI
{
    partial class CategoryForm
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
            txtCategoryName = new TextBox();
            btnCategoryUpdate = new Button();
            btnCategoryAdd = new Button();
            dgwCategory = new DataGridView();
            cmsCategory = new ContextMenuStrip(components);
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            lblCategoryId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwCategory).BeginInit();
            cmsCategory.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori Adı :";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(96, 6);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(239, 23);
            txtCategoryName.TabIndex = 1;
            // 
            // btnCategoryUpdate
            // 
            btnCategoryUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnCategoryUpdate.Location = new Point(260, 35);
            btnCategoryUpdate.Name = "btnCategoryUpdate";
            btnCategoryUpdate.Size = new Size(75, 51);
            btnCategoryUpdate.TabIndex = 2;
            btnCategoryUpdate.Text = "GÜNCELLE";
            btnCategoryUpdate.UseVisualStyleBackColor = false;
            btnCategoryUpdate.Click += btnCategoryUpdate_Click;
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnCategoryAdd.Location = new Point(179, 35);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new Size(75, 51);
            btnCategoryAdd.TabIndex = 2;
            btnCategoryAdd.Text = "EKLE";
            btnCategoryAdd.UseVisualStyleBackColor = false;
            btnCategoryAdd.Click += btnCategoryAdd_Click;
            // 
            // dgwCategory
            // 
            dgwCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCategory.ContextMenuStrip = cmsCategory;
            dgwCategory.Location = new Point(12, 92);
            dgwCategory.Name = "dgwCategory";
            dgwCategory.RowTemplate.Height = 25;
            dgwCategory.Size = new Size(323, 152);
            dgwCategory.TabIndex = 3;
            dgwCategory.CellMouseDown += dgwCategory_CellMouseDown;
            // 
            // cmsCategory
            // 
            cmsCategory.Items.AddRange(new ToolStripItem[] { güncelleToolStripMenuItem, silToolStripMenuItem });
            cmsCategory.Name = "cmsCategory";
            cmsCategory.Size = new Size(121, 48);
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
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(12, 35);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(38, 15);
            lblCategoryId.TabIndex = 4;
            lblCategoryId.Text = "label2";
            lblCategoryId.Visible = false;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 462);
            Controls.Add(lblCategoryId);
            Controls.Add(dgwCategory);
            Controls.Add(btnCategoryAdd);
            Controls.Add(btnCategoryUpdate);
            Controls.Add(txtCategoryName);
            Controls.Add(label1);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCategory).EndInit();
            cmsCategory.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoryName;
        private Button btnCategoryUpdate;
        private Button btnCategoryAdd;
        private DataGridView dgwCategory;
        private ContextMenuStrip cmsCategory;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private Label lblCategoryId;
    }
}