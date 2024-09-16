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
            label2 = new Label();
            txtCustomerName = new TextBox();
            label3 = new Label();
            txtFoodPrice = new TextBox();
            lstOut = new ListBox();
            btn = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(322, 36);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 0;
            label1.Text = "Food Restaurant";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(60, 119);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Costumer name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(233, 119);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(201, 23);
            txtCustomerName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(70, 167);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 3;
            label3.Text = "Food Price";
            // 
            // txtFoodPrice
            // 
            txtFoodPrice.Location = new Point(233, 159);
            txtFoodPrice.Name = "txtFoodPrice";
            txtFoodPrice.Size = new Size(159, 23);
            txtFoodPrice.TabIndex = 4;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(44, 244);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(687, 154);
            lstOut.TabIndex = 6;
            lstOut.SelectedIndexChanged += lstOut_SelectedIndexChanged;
            // 
            // btn
            // 
            btn.Location = new Point(60, 415);
            btn.Name = "btn";
            btn.Size = new Size(75, 40);
            btn.TabIndex = 7;
            btn.Text = "Calculate &Total";
            btn.UseVisualStyleBackColor = true;
            btn.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(317, 419);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 36);
            btnClear.TabIndex = 8;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(586, 419);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 36);
            btnQuit.TabIndex = 9;
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
            Controls.Add(btn);
            Controls.Add(lstOut);
            Controls.Add(txtFoodPrice);
            Controls.Add(label3);
            Controls.Add(txtCustomerName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ruhshona";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCustomerName;
        private Label label3;
        private TextBox txtFoodPrice;
        private MaskedTextBox maskedTextBox1;
        private ListBox lstOut;
        private Button btn;
        private Button btnClear;
        private Button btnQuit;
    }
}
