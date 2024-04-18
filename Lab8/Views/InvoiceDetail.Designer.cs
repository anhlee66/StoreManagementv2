namespace Lab8.Views
{
    partial class InvoiceDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new Label();
            numQuantity = new NumericUpDown();
            txtPrice = new Label();
            btnRemove = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.AutoSize = true;
            txtName.Location = new Point(12, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(92, 20);
            txtName.TabIndex = 0;
            txtName.Text = "Bao xi mang";
            // 
            // numQuantity
            // 
            numQuantity.Anchor = AnchorStyles.None;
            numQuantity.Location = new Point(178, 20);
            numQuantity.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(48, 27);
            numQuantity.TabIndex = 1;
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.None;
            txtPrice.AutoSize = true;
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(267, 21);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(94, 28);
            txtPrice.TabIndex = 2;
            txtPrice.Text = "100.000d";
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.None;
            btnRemove.Image = StoreManagement.Properties.Resources.close__Custom___1_1;
            btnRemove.Location = new Point(388, 20);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(35, 29);
            btnRemove.TabIndex = 3;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 4);
            panel1.TabIndex = 4;
            // 
            // InvoiceDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnRemove);
            Controls.Add(txtPrice);
            Controls.Add(numQuantity);
            Controls.Add(txtName);
            Name = "InvoiceDetail";
            Size = new Size(456, 68);
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtName;
        private NumericUpDown numQuantity;
        private Label txtPrice;
        private Button btnRemove;
        private Panel panel1;
    }
}
