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
            grpDiningOption = new GroupBox();
            rdoEatIn = new RadioButton();
            rdoDelivery = new RadioButton();
            rdoTakeOut = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            mnuSettings = new ToolStripMenuItem();
            btnDisplayLog_Click = new Button();
            grpDiningOption.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Italic | FontStyle.Underline);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(327, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 30);
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
            lblMenuItem.Size = new Size(75, 17);
            lblMenuItem.TabIndex = 1;
            lblMenuItem.Text = "Menu Item\r\n";
            // 
            // txtMenuItem
            // 
            txtMenuItem.BackColor = SystemColors.Window;
            txtMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMenuItem.Location = new Point(216, 204);
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
            label3.Location = new Point(74, 267);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 3;
            label3.Text = "Food Price";
            // 
            // txtFoodPrice
            // 
            txtFoodPrice.Location = new Point(229, 266);
            txtFoodPrice.Name = "txtFoodPrice";
            txtFoodPrice.Size = new Size(181, 22);
            txtFoodPrice.TabIndex = 4;
            // 
            // lstOut
            // 
            lstOut.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 17;
            lstOut.Location = new Point(57, 332);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(792, 242);
            lstOut.TabIndex = 6;
            lstOut.TabStop = false;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnCalculateTotal.ForeColor = Color.Blue;
            btnCalculateTotal.Location = new Point(86, 614);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(133, 78);
            btnCalculateTotal.TabIndex = 5;
            btnCalculateTotal.Text = "Calculate &Total";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Blue;
            btnClear.Location = new Point(366, 613);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 78);
            btnClear.TabIndex = 6;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.Blue;
            btnQuit.Location = new Point(634, 613);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(131, 78);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // grpDiningOption
            // 
            grpDiningOption.BackColor = Color.Transparent;
            grpDiningOption.BackgroundImageLayout = ImageLayout.None;
            grpDiningOption.Controls.Add(rdoEatIn);
            grpDiningOption.Controls.Add(rdoDelivery);
            grpDiningOption.Controls.Add(rdoTakeOut);
            grpDiningOption.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDiningOption.ForeColor = SystemColors.ActiveCaptionText;
            grpDiningOption.Location = new Point(57, 95);
            grpDiningOption.Name = "grpDiningOption";
            grpDiningOption.Size = new Size(825, 103);
            grpDiningOption.TabIndex = 8;
            grpDiningOption.TabStop = false;
            grpDiningOption.Text = "Dining Options";
            grpDiningOption.UseWaitCursor = true;
            grpDiningOption.Enter += grpEatingIn_Enter;
            // 
            // rdoEatIn
            // 
            rdoEatIn.AutoSize = true;
            rdoEatIn.Location = new Point(309, 32);
            rdoEatIn.Name = "rdoEatIn";
            rdoEatIn.Size = new Size(61, 21);
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
            rdoDelivery.Size = new Size(78, 21);
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
            rdoTakeOut.Size = new Size(81, 21);
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuSettings });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1222, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuSettings
            // 
            mnuSettings.Name = "mnuSettings";
            mnuSettings.Size = new Size(61, 20);
            mnuSettings.Text = "Settings";
            mnuSettings.Click += mnuSettings_Click;
            // 
            // btnDisplayLog_Click
            // 
            btnDisplayLog_Click.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplayLog_Click.ForeColor = Color.Blue;
            btnDisplayLog_Click.Location = new Point(864, 615);
            btnDisplayLog_Click.Name = "btnDisplayLog_Click";
            btnDisplayLog_Click.Size = new Size(131, 78);
            btnDisplayLog_Click.TabIndex = 10;
            btnDisplayLog_Click.Text = "&Quit";
            btnDisplayLog_Click.UseVisualStyleBackColor = true;
            btnDisplayLog_Click.Click += btnDisplayLog_Click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 714);
            Controls.Add(btnDisplayLog_Click);
            Controls.Add(grpDiningOption);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculateTotal);
            Controls.Add(lstOut);
            Controls.Add(txtFoodPrice);
            Controls.Add(label3);
            Controls.Add(txtMenuItem);
            Controls.Add(lblMenuItem);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "ruhshona";
            Load += Form1_Load;
            grpDiningOption.ResumeLayout(false);
            grpDiningOption.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private GroupBox grpDiningOption;
        private RadioButton rdoEatIn;
        private RadioButton rdoDelivery;
        private RadioButton rdoTakeOut;
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuSettings;
        private Button btnDisplayLog_Click;
    }
}
