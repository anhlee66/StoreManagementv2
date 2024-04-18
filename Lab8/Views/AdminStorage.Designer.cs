namespace Lab8.Views
{
    partial class AdminStorage
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            numPrice = new NumericUpDown();
            numImport = new NumericUpDown();
            numQuantity = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cbCategory = new ComboBox();
            txtSupplier = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnDelete = new Button();
            btnClear = new Button();
            btnSave = new Button();
            dgvProducts = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            CategoryId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Import = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Supplier = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numImport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1157, 330);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(numPrice);
            panel3.Controls.Add(numImport);
            panel3.Controls.Add(numQuantity);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cbCategory);
            panel3.Controls.Add(txtSupplier);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1157, 324);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(431, 18);
            label1.Name = "label1";
            label1.Size = new Size(235, 31);
            label1.TabIndex = 31;
            label1.Text = "Product Information";
            // 
            // numPrice
            // 
            numPrice.Anchor = AnchorStyles.None;
            numPrice.Font = new Font("Segoe UI", 12F);
            numPrice.Location = new Point(714, 172);
            numPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(406, 34);
            numPrice.TabIndex = 30;
            numPrice.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // numImport
            // 
            numImport.Anchor = AnchorStyles.None;
            numImport.Font = new Font("Segoe UI", 12F);
            numImport.Location = new Point(714, 120);
            numImport.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numImport.Name = "numImport";
            numImport.Size = new Size(406, 34);
            numImport.TabIndex = 29;
            numImport.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // numQuantity
            // 
            numQuantity.Anchor = AnchorStyles.None;
            numQuantity.Font = new Font("Segoe UI", 12F);
            numQuantity.Location = new Point(714, 70);
            numQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(406, 34);
            numQuantity.TabIndex = 28;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(573, 174);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 27;
            label5.Text = "Selling price:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(572, 120);
            label4.Name = "label4";
            label4.Size = new Size(124, 28);
            label4.TabIndex = 26;
            label4.Text = "Import price:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(573, 73);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 25;
            label3.Text = "Quantity:";
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.None;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Segoe UI", 12F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(142, 117);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(406, 36);
            cbCategory.TabIndex = 24;
            // 
            // txtSupplier
            // 
            txtSupplier.Anchor = AnchorStyles.None;
            txtSupplier.Font = new Font("Segoe UI", 12F);
            txtSupplier.Location = new Point(144, 174);
            txtSupplier.Multiline = true;
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(404, 57);
            txtSupplier.TabIndex = 23;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(142, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(406, 34);
            txtName.TabIndex = 22;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(36, 122);
            label7.Name = "label7";
            label7.Size = new Size(96, 28);
            label7.TabIndex = 21;
            label7.Text = "Category:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(36, 174);
            label6.Name = "label6";
            label6.Size = new Size(89, 28);
            label6.TabIndex = 20;
            label6.Text = "Supplier:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(36, 70);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 19;
            label2.Text = "Name:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnSave);
            panel2.Location = new Point(360, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 47);
            panel2.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(318, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 41);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkGray;
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(169, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 41);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Enabled = false;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(14, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 41);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProducts.ColumnHeadersHeight = 40;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ProductId, CategoryId, ProductName, CategoryName, Quantity, Import, Price, Supplier });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle5;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.Location = new Point(0, 330);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.LightGray;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 40;
            dgvProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProducts.RowTemplate.DividerHeight = 1;
            dgvProducts.RowTemplate.Height = 35;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1157, 386);
            dgvProducts.TabIndex = 4;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "ID";
            ProductId.MinimumWidth = 6;
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            ProductId.Visible = false;
            ProductId.Width = 125;
            // 
            // CategoryId
            // 
            CategoryId.DataPropertyName = "CategoryId";
            CategoryId.HeaderText = "CategoryId";
            CategoryId.MinimumWidth = 6;
            CategoryId.Name = "CategoryId";
            CategoryId.ReadOnly = true;
            CategoryId.Visible = false;
            CategoryId.Width = 125;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "Category";
            CategoryName.MinimumWidth = 6;
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            CategoryName.Width = 160;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 200;
            // 
            // Import
            // 
            Import.DataPropertyName = "Import";
            Import.HeaderText = "Import Price";
            Import.MinimumWidth = 6;
            Import.Name = "Import";
            Import.ReadOnly = true;
            Import.Width = 200;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Selling Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 200;
            // 
            // Supplier
            // 
            Supplier.DataPropertyName = "Supplier";
            Supplier.HeaderText = "Supplier";
            Supplier.MinimumWidth = 6;
            Supplier.Name = "Supplier";
            Supplier.ReadOnly = true;
            Supplier.Width = 350;
            // 
            // AdminStorage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 716);
            Controls.Add(dgvProducts);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminStorage";
            Text = "AdminStorage";
            Load += AdminStorage_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numImport).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn categoryUnit;
        private NumericUpDown numPrice;
        private NumericUpDown numImport;
        private NumericUpDown numQuantity;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbCategory;
        private TextBox txtSupplier;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Import;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Supplier;
    }
}