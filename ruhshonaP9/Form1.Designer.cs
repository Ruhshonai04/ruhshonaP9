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
            textBox1 = new TextBox();
            IstOut = new ListBox();
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
            label1.Size = new Size(70, 28);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 119);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "costomer name";
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
            label3.Location = new Point(70, 167);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Ticket Price";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 4;
            // 
            // IstOut
            // 
            IstOut.FormattingEnabled = true;
            IstOut.ItemHeight = 15;
            IstOut.Location = new Point(44, 244);
            IstOut.Name = "IstOut";
            IstOut.Size = new Size(687, 154);
            IstOut.TabIndex = 6;
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
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(586, 419);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 36);
            btnQuit.TabIndex = 9;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 527);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btn);
            Controls.Add(IstOut);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private ListBox IstOut;
        private Button btn;
        private Button btnClear;
        private Button btnQuit;
    }
}
