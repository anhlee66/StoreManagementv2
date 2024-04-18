namespace Lab8.Views
{
    partial class AdminDashboard
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
            panel6 = new Panel();
            label5 = new Label();
            panel7 = new Panel();
            label6 = new Label();
            panel4 = new Panel();
            txtProfit = new Label();
            label3 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            txtRevenue = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            cbNumber = new ComboBox();
            label8 = new Label();
            dgvProducts = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 198);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.AutoSize = true;
            panel6.BackColor = SystemColors.ControlDark;
            panel6.Controls.Add(label5);
            panel6.Controls.Add(panel7);
            panel6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            panel6.ForeColor = Color.Transparent;
            panel6.Location = new Point(715, 27);
            panel6.Name = "panel6";
            panel6.Size = new Size(289, 168);
            panel6.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(74, 114);
            label5.Name = "label5";
            label5.Size = new Size(162, 38);
            label5.TabIndex = 2;
            label5.Text = "1,000,000d";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Orange;
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(289, 91);
            panel7.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 28);
            label6.Name = "label6";
            label6.Size = new Size(98, 38);
            label6.TabIndex = 0;
            label6.Text = "Salary";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.AutoSize = true;
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Controls.Add(txtProfit);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(panel5);
            panel4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            panel4.ForeColor = Color.Transparent;
            panel4.Location = new Point(370, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(289, 168);
            panel4.TabIndex = 1;
            // 
            // txtProfit
            // 
            txtProfit.Anchor = AnchorStyles.None;
            txtProfit.AutoSize = true;
            txtProfit.Location = new Point(74, 114);
            txtProfit.Name = "txtProfit";
            txtProfit.Size = new Size(138, 38);
            txtProfit.TabIndex = 2;
            txtProfit.Text = "100,000d";
            txtProfit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 63);
            label3.Name = "label3";
            label3.Size = new Size(0, 38);
            label3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Orange;
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(289, 91);
            panel5.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 28);
            label4.Name = "label4";
            label4.Size = new Size(92, 38);
            label4.TabIndex = 0;
            label4.Text = "Profit";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(txtRevenue);
            panel2.Controls.Add(panel3);
            panel2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(24, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 168);
            panel2.TabIndex = 0;
            // 
            // txtRevenue
            // 
            txtRevenue.Anchor = AnchorStyles.None;
            txtRevenue.AutoSize = true;
            txtRevenue.Location = new Point(74, 114);
            txtRevenue.Name = "txtRevenue";
            txtRevenue.Size = new Size(138, 38);
            txtRevenue.TabIndex = 1;
            txtRevenue.Text = "100,000d";
            txtRevenue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orange;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 91);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 28);
            label1.Name = "label1";
            label1.Size = new Size(128, 38);
            label1.TabIndex = 0;
            label1.Text = "Revenue";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Silver;
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 198);
            panel8.Name = "panel8";
            panel8.Size = new Size(1036, 5);
            panel8.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(dgvProducts);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 203);
            panel9.Name = "panel9";
            panel9.Size = new Size(1036, 406);
            panel9.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.None;
            panel10.Controls.Add(cbNumber);
            panel10.Controls.Add(label8);
            panel10.Location = new Point(0, 0);
            panel10.MaximumSize = new Size(0, 100);
            panel10.Name = "panel10";
            panel10.Size = new Size(1036, 62);
            panel10.TabIndex = 12;
            // 
            // cbNumber
            // 
            cbNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbNumber.FormattingEnabled = true;
            cbNumber.Items.AddRange(new object[] { "3", "5", "10" });
            cbNumber.Location = new Point(203, 13);
            cbNumber.Name = "cbNumber";
            cbNumber.Size = new Size(88, 39);
            cbNumber.TabIndex = 12;
            cbNumber.SelectedIndexChanged += cbNumber_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 16);
            label8.Name = "label8";
            label8.Size = new Size(154, 31);
            label8.TabIndex = 11;
            label8.Text = "Top products";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.Anchor = AnchorStyles.None;
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
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, Amount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.Location = new Point(0, 62);
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
            dgvProducts.Size = new Size(1036, 344);
            dgvProducts.TabIndex = 11;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "Id";
            ProductId.HeaderText = "ID";
            ProductId.MinimumWidth = 6;
            ProductId.Name = "ProductId";
            ProductId.ReadOnly = true;
            ProductId.Width = 125;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.DataPropertyName = "Name";
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 200;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1036, 609);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel6;
        private Panel panel7;
        private Label label6;
        private Panel panel4;
        private Label label3;
        private Panel panel5;
        private Label label4;
        private Panel panel2;
        private Label txtRevenue;
        private Panel panel3;
        private Label label1;
        private Label label5;
        private Label txtProfit;
        private Panel panel8;
        private Panel panel9;
        private DataGridView dgvProducts;
        private Panel panel10;
        private Label label8;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Amount;
        private ComboBox cbNumber;
    }
}