using DrawingTests.MainModule.Submodule;

namespace DrawingTests.MainModule
{
    partial class MainView
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelBottomControls = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.subViewLeft = new SubView2();
            this.subView1 = new SubView();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelBottomControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitContainer1);
            this.panelMain.Controls.Add(this.panelBottomControls);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(284, 262);
            this.panelMain.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.subViewLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.subView1);
            this.splitContainer1.Size = new System.Drawing.Size(284, 162);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 1;
            // 
            // panelBottomControls
            // 
            this.panelBottomControls.Controls.Add(this.btnStop);
            this.panelBottomControls.Controls.Add(this.btnStart);
            this.panelBottomControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomControls.Location = new System.Drawing.Point(0, 162);
            this.panelBottomControls.Name = "panelBottomControls";
            this.panelBottomControls.Size = new System.Drawing.Size(284, 100);
            this.panelBottomControls.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(19, 35);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // subViewLeft
            // 
            this.subViewLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subViewLeft.Location = new System.Drawing.Point(0, 0);
            this.subViewLeft.Name = "subViewLeft";
            this.subViewLeft.Size = new System.Drawing.Size(94, 162);
            this.subViewLeft.TabIndex = 0;
            // 
            // subView1
            // 
            this.subView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subView1.Location = new System.Drawing.Point(0, 0);
            this.subView1.Name = "subView1";
            this.subView1.Size = new System.Drawing.Size(186, 162);
            this.subView1.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panelMain);
            this.Name = "MainView";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelBottomControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelBottomControls;
        private SubView2 subViewLeft;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private SubView subView1;
    }
}

