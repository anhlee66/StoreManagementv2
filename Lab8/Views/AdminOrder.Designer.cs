namespace Lab8
{
    partial class AdminOrder
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtDate = new Label();
            label8 = new Label();
            txtEmployee = new Label();
            label6 = new Label();
            txtAmount = new Label();
            label4 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            txtTotalPrice = new Label();
            label2 = new Label();
            flowInvoices = new FlowLayoutPanel();
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            dgvProducts = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            CategoryId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Import = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Supplier = new DataGridViewTextBoxColumn();
            dgvInvoices = new DataGridView();
            panel3 = new Panel();
            InvoiceId = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            DataCreated = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(txtDate);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtEmployee);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtTotalPrice);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(flowInvoices);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 652);
            panel1.TabIndex = 0;
            // 
            // txtDate
            // 
            txtDate.AutoSize = true;
            txtDate.Font = new Font("Segoe UI", 12F);
            txtDate.Location = new Point(398, 65);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(105, 28);
            txtDate.TabIndex = 14;
            txtDate.Text = "20/4/2024";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(335, 65);
            label8.Name = "label8";
            label8.Size = new Size(57, 28);
            label8.TabIndex = 13;
            label8.Text = "Date:";
            // 
            // txtEmployee
            // 
            txtEmployee.AutoSize = true;
            txtEmployee.Font = new Font("Segoe UI", 12F);
            txtEmployee.Location = new Point(133, 65);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(118, 28);
            txtEmployee.TabIndex = 12;
            txtEmployee.Text = "Le Tuan Anh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(20, 65);
            label6.Name = "label6";
            label6.Size = new Size(107, 28);
            label6.TabIndex = 11;
            label6.Text = "Employee: ";
            // 
            // txtAmount
            // 
            txtAmount.AutoSize = true;
            txtAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(456, 518);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(24, 28);
            txtAmount.TabIndex = 10;
            txtAmount.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(346, 518);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 9;
            label4.Text = "Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 19);
            label1.Name = "label1";
            label1.Size = new Size(165, 31);
            label1.TabIndex = 6;
            label1.Text = "Create invoice";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.AppWorkspace;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(279, 585);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 35);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(153, 585);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Create";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.AutoSize = true;
            txtTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(153, 518);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(43, 28);
            txtTotalPrice.TabIndex = 3;
            txtTotalPrice.Text = "0 đ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 518);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 2;
            label2.Text = "Total price:";
            // 
            // flowInvoices
            // 
            flowInvoices.AutoScroll = true;
            flowInvoices.BackColor = SystemColors.ButtonFace;
            flowInvoices.FlowDirection = FlowDirection.TopDown;
            flowInvoices.Location = new Point(20, 113);
            flowInvoices.Name = "flowInvoices";
            flowInvoices.Size = new Size(497, 378);
            flowInvoices.TabIndex = 1;
            flowInvoices.WrapContents = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(535, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 65);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(370, 9);
            button1.Name = "button1";
            button1.Size = new Size(163, 41);
            button1.TabIndex = 1;
            button1.Text = "Add to invoice";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(44, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(427, 38);
            textBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(192, 22);
            label3.Name = "label3";
            label3.Size = new Size(170, 38);
            label3.TabIndex = 9;
            label3.Text = "Invoice lists";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeight = 40;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ProductId, CategoryId, ProductName, CategoryName, Quantity, Import, Price, Supplier });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.Location = new Point(535, 65);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 40;
            dgvProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProducts.RowTemplate.DividerHeight = 1;
            dgvProducts.RowTemplate.Height = 35;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(555, 587);
            dgvProducts.TabIndex = 8;
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
            CategoryName.Visible = false;
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
            Import.Visible = false;
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
            Supplier.Visible = false;
            Supplier.Width = 350;
            // 
            // dgvInvoices
            // 
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToResizeRows = false;
            dgvInvoices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvInvoices.ColumnHeadersHeight = 40;
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInvoices.Columns.AddRange(new DataGridViewColumn[] { InvoiceId, EmployeeName, DataCreated, TotalPrice, TotalAmount });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvInvoices.DefaultCellStyle = dataGridViewCellStyle5;
            dgvInvoices.Dock = DockStyle.Bottom;
            dgvInvoices.EnableHeadersVisualStyles = false;
            dgvInvoices.Location = new Point(535, 435);
            dgvInvoices.MultiSelect = false;
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.LightGray;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvInvoices.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.RowHeadersWidth = 40;
            dgvInvoices.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvInvoices.RowTemplate.DividerHeight = 1;
            dgvInvoices.RowTemplate.Height = 35;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.Size = new Size(555, 217);
            dgvInvoices.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(535, 366);
            panel3.MaximumSize = new Size(0, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(555, 69);
            panel3.TabIndex = 9;
            // 
            // InvoiceId
            // 
            InvoiceId.DataPropertyName = "Id";
            InvoiceId.HeaderText = "ID";
            InvoiceId.MinimumWidth = 6;
            InvoiceId.Name = "InvoiceId";
            InvoiceId.ReadOnly = true;
            InvoiceId.Visible = false;
            InvoiceId.Width = 125;
            // 
            // EmployeeName
            // 
            EmployeeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeName.DataPropertyName = "Employee";
            EmployeeName.HeaderText = "Employee";
            EmployeeName.MinimumWidth = 6;
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            // 
            // DataCreated
            // 
            DataCreated.DataPropertyName = "DataCreated";
            DataCreated.HeaderText = "Date";
            DataCreated.MinimumWidth = 6;
            DataCreated.Name = "DataCreated";
            DataCreated.ReadOnly = true;
            DataCreated.Width = 200;
            // 
            // TotalPrice
            // 
            TotalPrice.DataPropertyName = "TotalPrice";
            TotalPrice.HeaderText = "Total price";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            TotalPrice.Width = 200;
            // 
            // TotalAmount
            // 
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "Total Amount";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            TotalAmount.Width = 200;
            // 
            // AdminOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 652);
            Controls.Add(panel3);
            Controls.Add(dgvInvoices);
            Controls.Add(dgvProducts);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminOrder";
            Text = "AdminOrder";
            Load += AdminOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Label txtTotalPrice;
        private Label label2;
        private FlowLayoutPanel flowInvoices;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Import;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Supplier;
        private DataGridView dgvInvoices;
        private Button btnCancel;
        private Button btnAdd;
        private Label label1;
        private Button button1;
        private Label label3;
        private Panel panel3;
        private Label txtAmount;
        private Label label4;
        private Label txtDate;
        private Label label8;
        private Label txtEmployee;
        private Label label6;
        private DataGridViewTextBoxColumn InvoiceId;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn DataCreated;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn TotalAmount;
    }
}