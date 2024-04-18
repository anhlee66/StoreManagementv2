namespace Lab8.Views
{
    partial class AdminCategory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            txtNumberCate = new Label();
            label4 = new Label();
            label3 = new Label();
            btnClear = new Button();
            btnSave = new Button();
            cbUnit = new ComboBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvCategories = new DataGridView();
            categoryId = new DataGridViewTextBoxColumn();
            categoryName = new DataGridViewTextBoxColumn();
            categoryUnit = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(cbUnit);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 126);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(1029, 82);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 41);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtNumberCate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, -14);
            groupBox1.MaximumSize = new Size(330, 400);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 130);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // txtNumberCate
            // 
            txtNumberCate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNumberCate.AutoSize = true;
            txtNumberCate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumberCate.ForeColor = Color.Peru;
            txtNumberCate.Location = new Point(129, 74);
            txtNumberCate.Name = "txtNumberCate";
            txtNumberCate.Size = new Size(96, 38);
            txtNumberCate.TabIndex = 12;
            txtNumberCate.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(9, 74);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(52, 33);
            label3.Name = "label3";
            label3.Size = new Size(205, 28);
            label3.TabIndex = 10;
            label3.Text = "Number of category";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Right;
            btnClear.BackColor = SystemColors.ControlDark;
            btnClear.Location = new Point(907, 82);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(106, 41);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Enabled = false;
            btnSave.Location = new Point(783, 82);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 41);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cbUnit
            // 
            cbUnit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbUnit.FormattingEnabled = true;
            cbUnit.Items.AddRange(new object[] { "Chai", "Thùng", "Can", "Kg", "Lít", "Mét khối", "Tắm", "Hộp", "Tấn", "Viên", "Cái" });
            cbUnit.Location = new Point(459, 82);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(281, 36);
            cbUnit.TabIndex = 3;
            cbUnit.SelectedIndexChanged += cbUnit_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(459, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(647, 34);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(376, 86);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 1;
            label2.Text = "Unit:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(376, 39);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToResizeRows = false;
            dgvCategories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategories.ColumnHeadersHeight = 40;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategories.Columns.AddRange(new DataGridViewColumn[] { categoryId, categoryName, categoryUnit });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategories.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.Location = new Point(0, 126);
            dgvCategories.MultiSelect = false;
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.RowHeadersWidth = 40;
            dgvCategories.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCategories.RowTemplate.DividerHeight = 1;
            dgvCategories.RowTemplate.Height = 35;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(1147, 418);
            dgvCategories.TabIndex = 1;
            dgvCategories.CellClick += dgvCategories_CellClick;
            // 
            // categoryId
            // 
            categoryId.DataPropertyName = "Id";
            categoryId.HeaderText = "ID";
            categoryId.MinimumWidth = 6;
            categoryId.Name = "categoryId";
            categoryId.ReadOnly = true;
            categoryId.Width = 125;
            // 
            // categoryName
            // 
            categoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            categoryName.DataPropertyName = "Name";
            categoryName.HeaderText = "Name";
            categoryName.MinimumWidth = 6;
            categoryName.Name = "categoryName";
            categoryName.ReadOnly = true;
            // 
            // categoryUnit
            // 
            categoryUnit.DataPropertyName = "Unit";
            categoryUnit.HeaderText = "Unit";
            categoryUnit.MinimumWidth = 6;
            categoryUnit.Name = "categoryUnit";
            categoryUnit.ReadOnly = true;
            categoryUnit.Width = 300;
            // 
            // AdminCategory
            // 
            ClientSize = new Size(1147, 544);
            Controls.Add(dgvCategories);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminCategory";
            Load += AdminCategory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Panel panel1;
        private GroupBox groupBox1;
        private Label txtNumberCate;
        private Label label4;
        private Label label3;
        private Button btnClear;
        private Button btnSave;
        private ComboBox cbUnit;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private DataGridView dgvCategories;
        private DataGridViewTextBoxColumn categoryId;
        private DataGridViewTextBoxColumn categoryName;
        private DataGridViewTextBoxColumn categoryUnit;
        private Button btnDelete;
    }
}