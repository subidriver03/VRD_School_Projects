namespace Turner_SalesTaxCalc_Project
{
    partial class frmBbvstc
    {
               private System.ComponentModel.IContainer components = null;
             
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
            lblVBP = new Label();
            txtPriceWholeDollar = new TextBox();
            lblWarranty = new Label();
            cmbWarranty = new ComboBox();
            lblStateSold = new Label();
            cmbStateSelect = new ComboBox();
            Calculate = new Button();
            btnExit = new Button();
            btnClear = new Button();
            lblResult = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblVBP
            // 
            lblVBP.AutoSize = true;
            lblVBP.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVBP.Location = new Point(18, 108);
            lblVBP.Name = "lblVBP";
            lblVBP.Size = new Size(215, 25);
            lblVBP.TabIndex = 1;
            lblVBP.Text = "Vehicle Base Price : $";
            lblVBP.Click += label1_Click;
            // 
            // txtPriceWholeDollar
            // 
            txtPriceWholeDollar.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPriceWholeDollar.Location = new Point(462, 108);
            txtPriceWholeDollar.Name = "txtPriceWholeDollar";
            txtPriceWholeDollar.Size = new Size(220, 30);
            txtPriceWholeDollar.TabIndex = 2;
            txtPriceWholeDollar.TextChanged += txtPriceWholeDollar_TextChanged;
            // 
            // lblWarranty
            // 
            lblWarranty.AutoSize = true;
            lblWarranty.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblWarranty.Location = new Point(18, 165);
            lblWarranty.Name = "lblWarranty";
            lblWarranty.Size = new Size(206, 25);
            lblWarranty.TabIndex = 3;
            lblWarranty.Text = "Extended Warranty :";
            // 
            // cmbWarranty
            // 
            cmbWarranty.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cmbWarranty.FormattingEnabled = true;
            cmbWarranty.Items.AddRange(new object[] { "None", "One Year", "Two Year", "Three Year" });
            cmbWarranty.Location = new Point(462, 164);
            cmbWarranty.Name = "cmbWarranty";
            cmbWarranty.Size = new Size(220, 31);
            cmbWarranty.TabIndex = 4;
            cmbWarranty.SelectedIndexChanged += cmbWarranty_SelectedIndexChanged;
            // 
            // lblStateSold
            // 
            lblStateSold.AutoSize = true;
            lblStateSold.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblStateSold.Location = new Point(18, 218);
            lblStateSold.Name = "lblStateSold";
            lblStateSold.Size = new Size(121, 25);
            lblStateSold.TabIndex = 5;
            lblStateSold.Text = "State Sold :";
            lblStateSold.Click += lblStateSold_Click;
            // 
            // cmbStateSelect
            // 
            cmbStateSelect.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cmbStateSelect.FormattingEnabled = true;
            cmbStateSelect.Items.AddRange(new object[] { "WA", "OR" });
            cmbStateSelect.Location = new Point(582, 212);
            cmbStateSelect.Name = "cmbStateSelect";
            cmbStateSelect.Size = new Size(100, 31);
            cmbStateSelect.TabIndex = 6;
            cmbStateSelect.SelectedIndexChanged += cmbStateSelect_SelectedIndexChanged;
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Calculate.Location = new Point(538, 268);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(144, 50);
            Calculate.TabIndex = 7;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(626, 392);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(106, 32);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(512, 392);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 32);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(19, 337);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 30);
            lblResult.TabIndex = 10;
            lblResult.Click += label1_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(168, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(427, 31);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Billy Bob's Vehicle Sales Tax Calculator";
            lblTitle.Click += lblTitle_Click;
            // 
            // frmBbvstc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(740, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblResult);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(Calculate);
            Controls.Add(cmbStateSelect);
            Controls.Add(lblStateSold);
            Controls.Add(cmbWarranty);
            Controls.Add(lblWarranty);
            Controls.Add(txtPriceWholeDollar);
            Controls.Add(lblVBP);
            Name = "frmBbvstc";
            Text = "Billy Bob's Vehicle Sales Tax Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblVBP;
        private TextBox txtPriceWholeDollar;
        private Label lblWarranty;
        private ComboBox cmbWarranty;
        private Label lblStateSold;
        private ComboBox cmbStateSelect;
        private Button Calculate;
        private Button btnExit;
        private Button btnClear;
        private Label lblResult;
        private Label lblTitle;
    }
}