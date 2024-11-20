namespace ruhshonaP9
{
    partial class Form2
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
            txtTaxRate = new TextBox();
            btnSetReturn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTakeOutFee = new TextBox();
            txtEatInFee = new TextBox();
            txtDeliveryFee = new TextBox();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // txtTaxRate
            // 
            txtTaxRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaxRate.Location = new Point(206, 83);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(100, 29);
            txtTaxRate.TabIndex = 0;
            txtTaxRate.Leave += txtTaxRate_Leave;
            // 
            // btnSetReturn
            // 
            btnSetReturn.Location = new Point(145, 317);
            btnSetReturn.Name = "btnSetReturn";
            btnSetReturn.Size = new Size(87, 39);
            btnSetReturn.TabIndex = 1;
            btnSetReturn.Text = "&Set && Return";
            btnSetReturn.UseVisualStyleBackColor = true;
            btnSetReturn.Click += btnSetReturn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 83);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 2;
            label1.Text = "Tax Rate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(92, 141);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 3;
            label2.Text = "Take Out Fee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(96, 203);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 4;
            label3.Text = "Eat In Fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(96, 260);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 5;
            label4.Text = "Delivery Fee";
            // 
            // txtTakeOutFee
            // 
            txtTakeOutFee.Font = new Font("Segoe UI", 12F);
            txtTakeOutFee.Location = new Point(206, 133);
            txtTakeOutFee.Name = "txtTakeOutFee";
            txtTakeOutFee.Size = new Size(100, 29);
            txtTakeOutFee.TabIndex = 6;
            // 
            // txtEatInFee
            // 
            txtEatInFee.Font = new Font("Segoe UI", 12F);
            txtEatInFee.Location = new Point(206, 195);
            txtEatInFee.Name = "txtEatInFee";
            txtEatInFee.Size = new Size(100, 29);
            txtEatInFee.TabIndex = 7;
            // 
            // txtDeliveryFee
            // 
            txtDeliveryFee.Font = new Font("Segoe UI", 12F);
            txtDeliveryFee.Location = new Point(206, 260);
            txtDeliveryFee.Name = "txtDeliveryFee";
            txtDeliveryFee.Size = new Size(100, 29);
            txtDeliveryFee.TabIndex = 8;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(124, 383);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(0, 21);
            lblErrorMsg.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 413);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtDeliveryFee);
            Controls.Add(txtEatInFee);
            Controls.Add(txtTakeOutFee);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSetReturn);
            Controls.Add(txtTaxRate);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSetReturn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox txtTaxRate;
        public TextBox txtTakeOutFee;
        public TextBox txtEatInFee;
        public TextBox txtDeliveryFee;
        private Label lblErrorMsg;
    }
}