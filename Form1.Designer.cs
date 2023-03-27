namespace OpLearn
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
            components = new System.ComponentModel.Container();
            panelLayout = new TableLayoutPanel();
            panelPropeties = new Panel();
            lblStatus = new Label();
            btnReset = new Button();
            btnStart = new Button();
            lblMinutes = new Label();
            txtMinutes = new TextBox();
            panelTimer = new Panel();
            lblTimer = new Label();
            timerCountdown = new System.Windows.Forms.Timer(components);
            panelLayout.SuspendLayout();
            panelPropeties.SuspendLayout();
            panelTimer.SuspendLayout();
            SuspendLayout();
            // 
            // panelLayout
            // 
            panelLayout.ColumnCount = 1;
            panelLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelLayout.Controls.Add(panelPropeties, 0, 0);
            panelLayout.Controls.Add(panelTimer, 0, 1);
            panelLayout.Location = new Point(12, 12);
            panelLayout.Name = "panelLayout";
            panelLayout.RowCount = 2;
            panelLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelLayout.Size = new Size(776, 426);
            panelLayout.TabIndex = 0;
            // 
            // panelPropeties
            // 
            panelPropeties.BackColor = SystemColors.ControlDarkDark;
            panelPropeties.Controls.Add(lblStatus);
            panelPropeties.Controls.Add(btnReset);
            panelPropeties.Controls.Add(btnStart);
            panelPropeties.Controls.Add(lblMinutes);
            panelPropeties.Controls.Add(txtMinutes);
            panelPropeties.Dock = DockStyle.Fill;
            panelPropeties.Location = new Point(3, 3);
            panelPropeties.Name = "panelPropeties";
            panelPropeties.Size = new Size(770, 207);
            panelPropeties.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe Print", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lblStatus.Location = new Point(326, 94);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 42);
            lblStatus.TabIndex = 4;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(402, 153);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(202, 38);
            btnReset.TabIndex = 3;
            btnReset.Text = "&Exit";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(153, 153);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(202, 38);
            btnStart.TabIndex = 2;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblMinutes
            // 
            lblMinutes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMinutes.AutoSize = true;
            lblMinutes.Font = new Font("Segoe Script", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMinutes.Location = new Point(315, 25);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(135, 42);
            lblMinutes.TabIndex = 1;
            lblMinutes.Text = "Minutes";
            // 
            // txtMinutes
            // 
            txtMinutes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMinutes.BackColor = SystemColors.ControlDarkDark;
            txtMinutes.BorderStyle = BorderStyle.None;
            txtMinutes.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMinutes.Location = new Point(26, 34);
            txtMinutes.Name = "txtMinutes";
            txtMinutes.Size = new Size(283, 29);
            txtMinutes.TabIndex = 0;
            txtMinutes.Text = "Enter Minutes Here";
            txtMinutes.TextAlign = HorizontalAlignment.Center;
            // 
            // panelTimer
            // 
            panelTimer.BackColor = SystemColors.ControlDarkDark;
            panelTimer.Controls.Add(lblTimer);
            panelTimer.Dock = DockStyle.Fill;
            panelTimer.Location = new Point(3, 216);
            panelTimer.Name = "panelTimer";
            panelTimer.Size = new Size(770, 207);
            panelTimer.TabIndex = 1;
            // 
            // lblTimer
            // 
            lblTimer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("LED Display7", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.Location = new Point(265, 92);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(47, 28);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "0";
            // 
            // timerCountdown
            // 
            timerCountdown.Interval = 1000;
            timerCountdown.Tick += timerCountdown_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelLayout);
            Name = "Form1";
            Text = "OperationLearn";
            panelLayout.ResumeLayout(false);
            panelPropeties.ResumeLayout(false);
            panelPropeties.PerformLayout();
            panelTimer.ResumeLayout(false);
            panelTimer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel panelLayout;
        private Panel panelPropeties;
        private Label lblStatus;
        private Button btnStart;
        private Label lblMinutes;
        private TextBox txtMinutes;
        private Panel panelTimer;
        private Label lblTimer;
        private System.Windows.Forms.Timer timerCountdown;
        private Button btnReset;
    }
}