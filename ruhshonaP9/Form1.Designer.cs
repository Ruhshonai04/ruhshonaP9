namespace ruhshonaP9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblMenuItem = new Label();
            txtMenuItem = new TextBox();
            label3 = new Label();
            txtFoodPrice = new TextBox();
            lstOut = new ListBox();
            btnCalculateTotal = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            grpDishtypes = new GroupBox();
            radioButton2 = new RadioButton();
            rdoDrinks = new RadioButton();
            rdoAppetizers = new RadioButton();
            grpDishtypes.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19F, FontStyle.Italic | FontStyle.Underline);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(266, 25);
            label1.Name = "label1";
            label1.Size = new Size(235, 30);
            label1.TabIndex = 0;
            label1.Text = "Food Restaurant";
            label1.Click += label1_Click;
            // 
            // lblMenuItem
            // 
            lblMenuItem.AllowDrop = true;
            lblMenuItem.AutoSize = true;
            lblMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuItem.ForeColor = SystemColors.ControlText;
            lblMenuItem.Location = new Point(68, 149);
            lblMenuItem.Name = "lblMenuItem";
            lblMenuItem.Size = new Size(75, 17);
            lblMenuItem.TabIndex = 1;
            lblMenuItem.Text = "Menu Item\r\n";
            // 
            // txtMenuItem
            // 
            txtMenuItem.BackColor = SystemColors.Window;
            txtMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMenuItem.Location = new Point(191, 148);
            txtMenuItem.Name = "txtMenuItem";
            txtMenuItem.Size = new Size(201, 23);
            txtMenuItem.TabIndex = 2;
            txtMenuItem.Enter += txtMenuItem_Enter;
            txtMenuItem.Leave += txtMenuItem_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 200);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 3;
            label3.Text = "Food Price";
            // 
            // txtFoodPrice
            // 
            txtFoodPrice.Location = new Point(200, 194);
            txtFoodPrice.Name = "txtFoodPrice";
            txtFoodPrice.Size = new Size(159, 23);
            txtFoodPrice.TabIndex = 4;
            txtFoodPrice.TextChanged += txtFoodPrice_TextChanged;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(50, 233);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(673, 184);
            lstOut.TabIndex = 6;
            lstOut.TabStop = false;
            lstOut.SelectedIndexChanged += lstOut_SelectedIndexChanged;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateTotal.ForeColor = Color.Blue;
            btnCalculateTotal.Location = new Point(76, 432);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(72, 61);
            btnCalculateTotal.TabIndex = 5;
            btnCalculateTotal.Text = "Calculate &Total";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Blue;
            btnClear.Location = new Point(340, 434);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 57);
            btnClear.TabIndex = 6;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.Blue;
            btnQuit.Location = new Point(602, 436);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(81, 57);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // grpDishtypes
            // 
            grpDishtypes.Controls.Add(radioButton2);
            grpDishtypes.Controls.Add(rdoDrinks);
            grpDishtypes.Controls.Add(rdoAppetizers);
            grpDishtypes.Font = new Font("Segoe UI", 10F);
            grpDishtypes.Location = new Point(50, 70);
            grpDishtypes.Name = "grpDishtypes";
            grpDishtypes.Size = new Size(653, 67);
            grpDishtypes.TabIndex = 8;
            grpDishtypes.TabStop = false;
            grpDishtypes.Text = "Dish Types";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(270, 32);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 23);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Desserts";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdoDrinks
            // 
            rdoDrinks.AutoSize = true;
            rdoDrinks.Location = new Point(532, 32);
            rdoDrinks.Name = "rdoDrinks";
            rdoDrinks.Size = new Size(66, 23);
            rdoDrinks.TabIndex = 10;
            rdoDrinks.TabStop = true;
            rdoDrinks.Text = "Drinks";
            rdoDrinks.UseVisualStyleBackColor = true;
            // 
            // rdoAppetizers
            // 
            rdoAppetizers.AutoSize = true;
            rdoAppetizers.Location = new Point(6, 32);
            rdoAppetizers.Name = "rdoAppetizers";
            rdoAppetizers.Size = new Size(91, 23);
            rdoAppetizers.TabIndex = 0;
            rdoAppetizers.TabStop = true;
            rdoAppetizers.Text = "Appetizers";
            rdoAppetizers.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 527);
            Controls.Add(grpDishtypes);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculateTotal);
            Controls.Add(lstOut);
            Controls.Add(txtFoodPrice);
            Controls.Add(label3);
            Controls.Add(txtMenuItem);
            Controls.Add(lblMenuItem);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ruhshona";
            Load += Form1_Load;
            grpDishtypes.ResumeLayout(false);
            grpDishtypes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMenuItem;
        private TextBox txtMenuItem;
        private Label label3;
        private TextBox txtFoodPrice;
      //  private MaskedTextBox maskedTextBox1;
        private ListBox lstOut;
        private Button btnCalculateTotal;
        private Button btnClear;
        private Button btnQuit;
        private GroupBox grpDishtypes;
        private RadioButton radioButton2;
        private RadioButton rdoDrinks;
        private RadioButton rdoAppetizers;
    }
}
