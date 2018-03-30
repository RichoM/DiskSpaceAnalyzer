namespace DirSize
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.scannerWorker = new System.ComponentModel.BackgroundWorker();
            this.entryCountLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.currentFileLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(13, 13);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(220, 38);
            this.analyzeButton.TabIndex = 0;
            this.analyzeButton.Text = "Analyze folder...";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // scannerWorker
            // 
            this.scannerWorker.WorkerSupportsCancellation = true;
            this.scannerWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.scannerWorker_DoWork);
            // 
            // entryCountLabel
            // 
            this.entryCountLabel.AutoSize = true;
            this.entryCountLabel.Location = new System.Drawing.Point(12, 65);
            this.entryCountLabel.Name = "entryCountLabel";
            this.entryCountLabel.Size = new System.Drawing.Size(35, 13);
            this.entryCountLabel.TabIndex = 1;
            this.entryCountLabel.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // currentFileLabel
            // 
            this.currentFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentFileLabel.AutoEllipsis = true;
            this.currentFileLabel.Location = new System.Drawing.Point(12, 88);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(528, 13);
            this.currentFileLabel.TabIndex = 2;
            this.currentFileLabel.Text = "label1";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(239, 13);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(220, 38);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 126);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.currentFileLabel);
            this.Controls.Add(this.entryCountLabel);
            this.Controls.Add(this.analyzeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button analyzeButton;
        private System.ComponentModel.BackgroundWorker scannerWorker;
        private System.Windows.Forms.Label entryCountLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label currentFileLabel;
        private System.Windows.Forms.Button stopButton;
    }
}

