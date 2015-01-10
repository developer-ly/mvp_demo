namespace DrawingTests.MainModule.Submodule
{
    partial class SubView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnStopSwitching = new System.Windows.Forms.Button();
            this.btnStartSwitching = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.btnStopSwitching);
            this.panelMain.Controls.Add(this.btnStartSwitching);
            this.panelMain.Controls.Add(this.pictureBox);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(416, 505);
            this.panelMain.TabIndex = 0;
            // 
            // btnStopSwitching
            // 
            this.btnStopSwitching.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStopSwitching.Location = new System.Drawing.Point(0, 455);
            this.btnStopSwitching.Name = "btnStopSwitching";
            this.btnStopSwitching.Size = new System.Drawing.Size(412, 23);
            this.btnStopSwitching.TabIndex = 2;
            this.btnStopSwitching.Text = "stop";
            this.btnStopSwitching.UseVisualStyleBackColor = true;
            this.btnStopSwitching.Click += new System.EventHandler(this.btnStopSwitching_Click);
            // 
            // btnStartSwitching
            // 
            this.btnStartSwitching.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartSwitching.Location = new System.Drawing.Point(0, 478);
            this.btnStartSwitching.Name = "btnStartSwitching";
            this.btnStartSwitching.Size = new System.Drawing.Size(412, 23);
            this.btnStartSwitching.TabIndex = 1;
            this.btnStartSwitching.Text = "start";
            this.btnStartSwitching.UseVisualStyleBackColor = true;
            this.btnStartSwitching.Click += new System.EventHandler(this.btnStartSwitching_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(412, 501);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // SubView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "SubView";
            this.Size = new System.Drawing.Size(416, 505);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnStartSwitching;
        private System.Windows.Forms.Button btnStopSwitching;
    }
}
