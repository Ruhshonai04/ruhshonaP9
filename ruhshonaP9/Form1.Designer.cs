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
            grpEatingIn = new GroupBox();
            rdoEatIn = new RadioButton();
            rdoDelivery = new RadioButton();
            rdoTakeOut = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            grpEatingIn.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Italic | FontStyle.Underline);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(327, 0);
            label1.Name = "label1";
            label1.Size = new Size(402, 59);
            label1.TabIndex = 0;
            label1.Text = "Food Restaurant";
            // 
            // lblMenuItem
            // 
            lblMenuItem.AllowDrop = true;
            lblMenuItem.AutoSize = true;
            lblMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuItem.ForeColor = SystemColors.ControlText;
            lblMenuItem.Location = new Point(57, 207);
            lblMenuItem.Name = "lblMenuItem";
            lblMenuItem.Size = new Size(149, 36);
            lblMenuItem.TabIndex = 1;
            lblMenuItem.Text = "Menu Item\r\n";
            // 
            // txtMenuItem
            // 
            txtMenuItem.BackColor = SystemColors.Window;
            txtMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMenuItem.Location = new Point(216, 204);
            txtMenuItem.Name = "txtMenuItem";
            txtMenuItem.Size = new Size(229, 39);
            txtMenuItem.TabIndex = 2;
            txtMenuItem.Enter += txtMenuItem_Enter;
            txtMenuItem.Leave += txtMenuItem_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 267);
            label3.Name = "label3";
            label3.Size = new Size(143, 36);
            label3.TabIndex = 3;
            label3.Text = "Food Price";
            // 
            // txtFoodPrice
            // 
            txtFoodPrice.Location = new Point(229, 266);
            txtFoodPrice.Name = "txtFoodPrice";
            txtFoodPrice.Size = new Size(181, 37);
            txtFoodPrice.TabIndex = 4;
            // 
            // lstOut
            // 
            lstOut.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 36;
            lstOut.Location = new Point(57, 332);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(780, 184);
            lstOut.TabIndex = 6;
            lstOut.TabStop = false;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateTotal.ForeColor = Color.Blue;
            btnCalculateTotal.Location = new Point(98, 568);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(125, 78);
            btnCalculateTotal.TabIndex = 5;
            btnCalculateTotal.Text = "Calculate &Total";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Blue;
            btnClear.Location = new Point(366, 568);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 74);
            btnClear.TabIndex = 6;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.Blue;
            btnQuit.Location = new Point(631, 568);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(124, 66);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // grpEatingIn
            // 
            grpEatingIn.BackColor = Color.Transparent;
            grpEatingIn.BackgroundImageLayout = ImageLayout.None;
            grpEatingIn.Controls.Add(rdoEatIn);
            grpEatingIn.Controls.Add(rdoDelivery);
            grpEatingIn.Controls.Add(rdoTakeOut);
            grpEatingIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpEatingIn.ForeColor = SystemColors.ActiveCaptionText;
            grpEatingIn.Location = new Point(57, 95);
            grpEatingIn.Name = "grpEatingIn";
            grpEatingIn.Size = new Size(752, 103);
            grpEatingIn.TabIndex = 8;
            grpEatingIn.TabStop = false;
            grpEatingIn.Text = "Dining Options";
            grpEatingIn.UseWaitCursor = true;
            grpEatingIn.Enter += grpEatingIn_Enter;
            // 
            // rdoEatIn
            // 
            rdoEatIn.AutoSize = true;
            rdoEatIn.Location = new Point(309, 32);
            rdoEatIn.Name = "rdoEatIn";
            rdoEatIn.Size = new Size(115, 40);
            rdoEatIn.TabIndex = 9;
            rdoEatIn.TabStop = true;
            rdoEatIn.Text = "Eat In";
            rdoEatIn.UseVisualStyleBackColor = true;
            rdoEatIn.UseWaitCursor = true;
            rdoEatIn.CheckedChanged += rdoEatIn_CheckedChanged;
            // 
            // rdoDelivery
            // 
            rdoDelivery.AutoSize = true;
            rdoDelivery.Location = new Point(608, 32);
            rdoDelivery.Name = "rdoDelivery";
            rdoDelivery.Size = new Size(146, 40);
            rdoDelivery.TabIndex = 10;
            rdoDelivery.TabStop = true;
            rdoDelivery.Text = "Delivery";
            rdoDelivery.UseVisualStyleBackColor = true;
            rdoDelivery.UseWaitCursor = true;
            rdoDelivery.CheckedChanged += rdoDelivery_CheckedChanged;
            // 
            // rdoTakeOut
            // 
            rdoTakeOut.AccessibleRole = AccessibleRole.MenuBar;
            rdoTakeOut.AutoSize = true;
            rdoTakeOut.Location = new Point(7, 32);
            rdoTakeOut.Name = "rdoTakeOut";
            rdoTakeOut.Size = new Size(155, 40);
            rdoTakeOut.TabIndex = 0;
            rdoTakeOut.TabStop = true;
            rdoTakeOut.Text = "Take Out";
            rdoTakeOut.UseVisualStyleBackColor = true;
            rdoTakeOut.UseWaitCursor = true;
            rdoTakeOut.CheckedChanged += rdoTakeOut_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 714);
            Controls.Add(grpEatingIn);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculateTotal);
            Controls.Add(lstOut);
            Controls.Add(txtFoodPrice);
            Controls.Add(label3);
            Controls.Add(txtMenuItem);
            Controls.Add(lblMenuItem);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "ruhshona";
            Load += Form1_Load;
            grpEatingIn.ResumeLayout(false);
            grpEatingIn.PerformLayout();
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
        private GroupBox grpEatingIn;
        private RadioButton rdoEatIn;
        private RadioButton rdoDelivery;
        private RadioButton rdoTakeOut;
        private OpenFileDialog openFileDialog1;
    }
}
