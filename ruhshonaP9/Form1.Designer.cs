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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(283, 46);
            label1.Name = "label1";
            label1.Size = new Size(216, 27);
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
            lblMenuItem.Location = new Point(70, 119);
            lblMenuItem.Name = "lblMenuItem";
            lblMenuItem.Size = new Size(75, 17);
            lblMenuItem.TabIndex = 1;
            lblMenuItem.Text = "Menu Item\r\n";
            // 
            // txtMenuItem
            // 
            txtMenuItem.BackColor = SystemColors.Window;
            txtMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMenuItem.Location = new Point(233, 113);
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
            label3.Location = new Point(70, 167);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 3;
            label3.Text = "Food Price";
            // 
            // txtFoodPrice
            // 
            txtFoodPrice.Location = new Point(233, 159);
            txtFoodPrice.Name = "txtFoodPrice";
            txtFoodPrice.Size = new Size(159, 23);
            txtFoodPrice.TabIndex = 4;
            txtFoodPrice.TextChanged += txtFoodPrice_TextChanged;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(50, 215);
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
            btnCalculateTotal.Location = new Point(84, 415);
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
            btnClear.Location = new Point(335, 419);
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
            btnQuit.Location = new Point(602, 417);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(81, 57);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 527);
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
    }
}
