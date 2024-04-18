namespace Lab8
{
    partial class HomeForm
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
            panel2 = new Panel();
            panel3 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel1 = new Panel();
            txtName = new Label();
            label1 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            sbLogout = new Button();
            panel9 = new Panel();
            sbOrder = new Button();
            panel8 = new Panel();
            sbCategory = new Button();
            panel7 = new Panel();
            sbStorage = new Button();
            panel6 = new Panel();
            sbDashboard = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1402, 69);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(txtSearch);
            panel3.Location = new Point(266, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 48);
            panel3.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightSlateGray;
            btnSearch.Location = new Point(352, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 42);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(3, 3);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(343, 41);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(1108, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 51);
            panel1.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(128, 11);
            txtName.Name = "txtName";
            txtName.Size = new Size(70, 28);
            txtName.TabIndex = 1;
            txtName.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.CadetBlue;
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 69);
            panel5.Name = "panel5";
            panel5.Size = new Size(269, 646);
            panel5.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(sbLogout);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 268);
            panel4.Name = "panel4";
            panel4.Size = new Size(269, 67);
            panel4.TabIndex = 7;
            // 
            // sbLogout
            // 
            sbLogout.FlatAppearance.BorderSize = 0;
            sbLogout.FlatStyle = FlatStyle.Flat;
            sbLogout.Image = StoreManagement.Properties.Resources.logout__Custom_;
            sbLogout.ImageAlign = ContentAlignment.MiddleLeft;
            sbLogout.Location = new Point(0, 3);
            sbLogout.Name = "sbLogout";
            sbLogout.Size = new Size(266, 61);
            sbLogout.TabIndex = 0;
            sbLogout.Text = "          Logout";
            sbLogout.TextAlign = ContentAlignment.MiddleLeft;
            sbLogout.UseVisualStyleBackColor = true;
            sbLogout.Click += sbLogout_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(sbOrder);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 201);
            panel9.Name = "panel9";
            panel9.Size = new Size(269, 67);
            panel9.TabIndex = 6;
            // 
            // sbOrder
            // 
            sbOrder.FlatAppearance.BorderSize = 0;
            sbOrder.FlatStyle = FlatStyle.Flat;
            sbOrder.Image = StoreManagement.Properties.Resources.checkout__Custom_1;
            sbOrder.ImageAlign = ContentAlignment.MiddleLeft;
            sbOrder.Location = new Point(3, 6);
            sbOrder.Name = "sbOrder";
            sbOrder.Size = new Size(266, 61);
            sbOrder.TabIndex = 4;
            sbOrder.Text = "          Orders";
            sbOrder.TextAlign = ContentAlignment.MiddleLeft;
            sbOrder.UseVisualStyleBackColor = true;
            sbOrder.Click += sbOrder_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(sbCategory);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 134);
            panel8.Name = "panel8";
            panel8.Size = new Size(269, 67);
            panel8.TabIndex = 5;
            // 
            // sbCategory
            // 
            sbCategory.Dock = DockStyle.Top;
            sbCategory.FlatAppearance.BorderSize = 0;
            sbCategory.FlatStyle = FlatStyle.Flat;
            sbCategory.Image = StoreManagement.Properties.Resources.categories__Custom_;
            sbCategory.ImageAlign = ContentAlignment.MiddleLeft;
            sbCategory.Location = new Point(0, 0);
            sbCategory.Name = "sbCategory";
            sbCategory.Size = new Size(269, 64);
            sbCategory.TabIndex = 0;
            sbCategory.Text = "          Category";
            sbCategory.TextAlign = ContentAlignment.MiddleLeft;
            sbCategory.UseVisualStyleBackColor = true;
            sbCategory.Click += sbCategory_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(sbStorage);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 67);
            panel7.Name = "panel7";
            panel7.Size = new Size(269, 67);
            panel7.TabIndex = 4;
            // 
            // sbStorage
            // 
            sbStorage.FlatAppearance.BorderSize = 0;
            sbStorage.FlatStyle = FlatStyle.Flat;
            sbStorage.Image = StoreManagement.Properties.Resources.hosting__Custom_;
            sbStorage.ImageAlign = ContentAlignment.MiddleLeft;
            sbStorage.Location = new Point(3, 3);
            sbStorage.Name = "sbStorage";
            sbStorage.Size = new Size(263, 61);
            sbStorage.TabIndex = 0;
            sbStorage.Text = "          Storage";
            sbStorage.TextAlign = ContentAlignment.MiddleLeft;
            sbStorage.UseVisualStyleBackColor = true;
            sbStorage.Click += sbStorage_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(sbDashboard);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(269, 67);
            panel6.TabIndex = 3;
            // 
            // sbDashboard
            // 
            sbDashboard.FlatAppearance.BorderSize = 0;
            sbDashboard.FlatStyle = FlatStyle.Flat;
            sbDashboard.Image = StoreManagement.Properties.Resources.dashboard__Custom_;
            sbDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            sbDashboard.Location = new Point(3, 3);
            sbDashboard.Name = "sbDashboard";
            sbDashboard.Size = new Size(263, 61);
            sbDashboard.TabIndex = 0;
            sbDashboard.Text = "          Dashboard";
            sbDashboard.TextAlign = ContentAlignment.MiddleLeft;
            sbDashboard.UseVisualStyleBackColor = true;
            sbDashboard.Click += sbDashboard_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1402, 715);
            Controls.Add(panel5);
            Controls.Add(panel2);
            IsMdiContainer = true;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            WindowState = FormWindowState.Maximized;
            FormClosed += HomeForm_Closed;
            Load += HomeForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label txtName;
        private Label label1;
        private Panel panel5;
        private Panel panel9;
        private Button sbLogout;
        private Panel panel8;
        private Button sbCategory;
        private Panel panel7;
        private Button sbStorage;
        private Panel panel6;
        private Button sbDashboard;
        private Panel panel3;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel4;
        private Button sbOrder;
    }
}