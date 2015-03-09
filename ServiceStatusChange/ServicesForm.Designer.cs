namespace ServiceStatusChange
{
    partial class ServicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesForm));
            this.ServicesDataGridView = new System.Windows.Forms.DataGridView();
            this.InfoStatusStrip = new System.Windows.Forms.StatusStrip();
            this.EnabledButton = new System.Windows.Forms.Button();
            this.DisabledButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.StatusToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataGridView)).BeginInit();
            this.InfoStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServicesDataGridView
            // 
            this.ServicesDataGridView.AllowUserToAddRows = false;
            this.ServicesDataGridView.AllowUserToDeleteRows = false;
            this.ServicesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ServicesDataGridView.Name = "ServicesDataGridView";
            this.ServicesDataGridView.ReadOnly = true;
            this.ServicesDataGridView.Size = new System.Drawing.Size(624, 205);
            this.ServicesDataGridView.TabIndex = 0;
            // 
            // InfoStatusStrip
            // 
            this.InfoStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StatusToolStripStatusLabel,
            this.StatusToolStripProgressBar});
            this.InfoStatusStrip.Location = new System.Drawing.Point(0, 252);
            this.InfoStatusStrip.Name = "InfoStatusStrip";
            this.InfoStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.InfoStatusStrip.Size = new System.Drawing.Size(649, 22);
            this.InfoStatusStrip.TabIndex = 1;
            this.InfoStatusStrip.Text = "Info";
            // 
            // EnabledButton
            // 
            this.EnabledButton.Location = new System.Drawing.Point(12, 223);
            this.EnabledButton.Name = "EnabledButton";
            this.EnabledButton.Size = new System.Drawing.Size(120, 23);
            this.EnabledButton.TabIndex = 2;
            this.EnabledButton.Text = "Service(s) Enable";
            this.EnabledButton.UseVisualStyleBackColor = true;
            this.EnabledButton.Click += new System.EventHandler(this.EnabledButton_Click);
            // 
            // DisabledButton
            // 
            this.DisabledButton.Location = new System.Drawing.Point(138, 223);
            this.DisabledButton.Name = "DisabledButton";
            this.DisabledButton.Size = new System.Drawing.Size(120, 23);
            this.DisabledButton.TabIndex = 3;
            this.DisabledButton.Text = "Service(s) Disable";
            this.DisabledButton.UseVisualStyleBackColor = true;
            this.DisabledButton.Click += new System.EventHandler(this.DisabledButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(264, 223);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Service(s) Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(390, 223);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(120, 23);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Service(s) Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(516, 223);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(120, 23);
            this.RestartButton.TabIndex = 6;
            this.RestartButton.Text = "Service(s) Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // StatusToolStripProgressBar
            // 
            this.StatusToolStripProgressBar.Name = "StatusToolStripProgressBar";
            this.StatusToolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // StatusToolStripStatusLabel
            // 
            this.StatusToolStripStatusLabel.Name = "StatusToolStripStatusLabel";
            this.StatusToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 274);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DisabledButton);
            this.Controls.Add(this.EnabledButton);
            this.Controls.Add(this.InfoStatusStrip);
            this.Controls.Add(this.ServicesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServicesForm";
            this.Text = "Service Status Enable/Disable";
            this.Load += new System.EventHandler(this.ServicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataGridView)).EndInit();
            this.InfoStatusStrip.ResumeLayout(false);
            this.InfoStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ServicesDataGridView;
        private System.Windows.Forms.StatusStrip InfoStatusStrip;
        private System.Windows.Forms.Button EnabledButton;
        private System.Windows.Forms.Button DisabledButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar StatusToolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusToolStripStatusLabel;
    }
}

