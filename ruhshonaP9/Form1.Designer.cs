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
            label1.Location = new Point(304, 25);
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
            lblMenuItem.Location = new Point(78, 149);
            lblMenuItem.Name = "lblMenuItem";
            lblMenuItem.Size = new Size(75, 17);
            lblMenuItem.TabIndex = 1;
            lblMenuItem.Text = "Menu Item\r\n";
            // 
            // txtMenuItem
            // 
            txtMenuItem.BackColor = SystemColors.Window;
            txtMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMenuItem.Location = new Point(218, 148);
            txtMenuItem.Name = "txtMenuItem";
            txtMenuItem.Size = new Size(229, 23);
            txtMenuItem.TabIndex = 2;
            txtMenuItem.Enter += txtMenuItem_Enter;
            txtMenuItem.Leave += txtMenuItem_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 200);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 3;
            label3.Text = "Food Price";
            // 
            // txtFoodPrice
            // 
            txtFoodPrice.Location = new Point(229, 194);
            txtFoodPrice.Name = "txtFoodPrice";
            txtFoodPrice.Size = new Size(181, 23);
            txtFoodPrice.TabIndex = 4;
            txtFoodPrice.TextChanged += txtFoodPrice_TextChanged;
            // 
            // lstOut
            // 
            lstOut.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 17;
            lstOut.Location = new Point(42, 223);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(738, 174);
            lstOut.TabIndex = 6;
            lstOut.TabStop = false;
            lstOut.SelectedIndexChanged += lstOut_SelectedIndexChanged;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateTotal.ForeColor = Color.Blue;
            btnCalculateTotal.Location = new Point(78, 432);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(82, 61);
            btnCalculateTotal.TabIndex = 5;
            btnCalculateTotal.Text = "Calculate &Total";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Blue;
            btnClear.Location = new Point(374, 434);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 57);
            btnClear.TabIndex = 6;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.Blue;
            btnQuit.Location = new Point(670, 432);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(93, 57);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // grpDishtypes
            // 
            grpDishtypes.BackColor = Color.FromArgb(255, 192, 192);
            grpDishtypes.BackgroundImageLayout = ImageLayout.None;
            grpDishtypes.Controls.Add(radioButton2);
            grpDishtypes.Controls.Add(rdoDrinks);
            grpDishtypes.Controls.Add(rdoAppetizers);
            grpDishtypes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDishtypes.ForeColor = SystemColors.ActiveCaptionText;
            grpDishtypes.Location = new Point(57, 70);
            grpDishtypes.Name = "grpDishtypes";
            grpDishtypes.Size = new Size(723, 67);
            grpDishtypes.TabIndex = 8;
            grpDishtypes.TabStop = false;
            grpDishtypes.Text = "Dish Types";
            grpDishtypes.UseWaitCursor = true;
            grpDishtypes.Enter += grpDishtypes_Enter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(309, 32);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 21);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Desserts";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.UseWaitCursor = true;
            // 
            // rdoDrinks
            // 
            rdoDrinks.AutoSize = true;
            rdoDrinks.Location = new Point(608, 32);
            rdoDrinks.Name = "rdoDrinks";
            rdoDrinks.Size = new Size(66, 21);
            rdoDrinks.TabIndex = 10;
            rdoDrinks.TabStop = true;
            rdoDrinks.Text = "Drinks";
            rdoDrinks.UseVisualStyleBackColor = true;
            rdoDrinks.UseWaitCursor = true;
            // 
            // rdoAppetizers
            // 
            rdoAppetizers.AutoSize = true;
            rdoAppetizers.Location = new Point(7, 32);
            rdoAppetizers.Name = "rdoAppetizers";
            rdoAppetizers.Size = new Size(91, 21);
            rdoAppetizers.TabIndex = 0;
            rdoAppetizers.TabStop = true;
            rdoAppetizers.Text = "Appetizers";
            rdoAppetizers.UseVisualStyleBackColor = true;
            rdoAppetizers.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 530);
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
            Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
