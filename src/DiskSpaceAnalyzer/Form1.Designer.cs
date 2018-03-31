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
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.currentFileLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.foldersGrid = new System.Windows.Forms.DataGridView();
            this.directoryEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoryCSVNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthKbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthMbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthGbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.foldersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryEntryBindingSource)).BeginInit();
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
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
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
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // currentFileLabel
            // 
            this.currentFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentFileLabel.AutoEllipsis = true;
            this.currentFileLabel.Location = new System.Drawing.Point(12, 88);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(861, 13);
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
            // foldersGrid
            // 
            this.foldersGrid.AllowUserToAddRows = false;
            this.foldersGrid.AllowUserToDeleteRows = false;
            this.foldersGrid.AllowUserToResizeRows = false;
            this.foldersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foldersGrid.AutoGenerateColumns = false;
            this.foldersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foldersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.directoryCSVNameDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.lengthKbDataGridViewTextBoxColumn,
            this.lengthMbDataGridViewTextBoxColumn,
            this.lengthGbDataGridViewTextBoxColumn});
            this.foldersGrid.DataSource = this.directoryEntryBindingSource;
            this.foldersGrid.Location = new System.Drawing.Point(12, 119);
            this.foldersGrid.MultiSelect = false;
            this.foldersGrid.Name = "foldersGrid";
            this.foldersGrid.ReadOnly = true;
            this.foldersGrid.RowHeadersVisible = false;
            this.foldersGrid.Size = new System.Drawing.Size(861, 475);
            this.foldersGrid.TabIndex = 4;
            // 
            // directoryEntryBindingSource
            // 
            this.directoryEntryBindingSource.DataSource = typeof(DirSize.Form1.DirectoryEntry);
            // 
            // directoryCSVNameDataGridViewTextBoxColumn
            // 
            this.directoryCSVNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.directoryCSVNameDataGridViewTextBoxColumn.DataPropertyName = "DirectoryCSVName";
            this.directoryCSVNameDataGridViewTextBoxColumn.HeaderText = "Directory";
            this.directoryCSVNameDataGridViewTextBoxColumn.Name = "directoryCSVNameDataGridViewTextBoxColumn";
            this.directoryCSVNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Size (bytes)";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthKbDataGridViewTextBoxColumn
            // 
            this.lengthKbDataGridViewTextBoxColumn.DataPropertyName = "LengthKb";
            this.lengthKbDataGridViewTextBoxColumn.HeaderText = "Size (KB)";
            this.lengthKbDataGridViewTextBoxColumn.Name = "lengthKbDataGridViewTextBoxColumn";
            this.lengthKbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthMbDataGridViewTextBoxColumn
            // 
            this.lengthMbDataGridViewTextBoxColumn.DataPropertyName = "LengthMb";
            this.lengthMbDataGridViewTextBoxColumn.HeaderText = "Size (MB)";
            this.lengthMbDataGridViewTextBoxColumn.Name = "lengthMbDataGridViewTextBoxColumn";
            this.lengthMbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthGbDataGridViewTextBoxColumn
            // 
            this.lengthGbDataGridViewTextBoxColumn.DataPropertyName = "LengthGb";
            this.lengthGbDataGridViewTextBoxColumn.HeaderText = "Size (GB)";
            this.lengthGbDataGridViewTextBoxColumn.Name = "lengthGbDataGridViewTextBoxColumn";
            this.lengthGbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 606);
            this.Controls.Add(this.foldersGrid);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.currentFileLabel);
            this.Controls.Add(this.entryCountLabel);
            this.Controls.Add(this.analyzeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foldersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryEntryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button analyzeButton;
        private System.ComponentModel.BackgroundWorker scannerWorker;
        private System.Windows.Forms.Label entryCountLabel;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label currentFileLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.DataGridView foldersGrid;
        private System.Windows.Forms.BindingSource directoryEntryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn directoryCSVNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthKbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthMbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthGbDataGridViewTextBoxColumn;
    }
}

