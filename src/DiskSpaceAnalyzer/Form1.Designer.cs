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
            this.scannerWorker = new System.ComponentModel.BackgroundWorker();
            this.entryCountLabel = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.currentFileLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.foldersGrid = new System.Windows.Forms.DataGridView();
            this.directoryCSVNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthKbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthMbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthGbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directoryEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exclusionsTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foldersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryEntryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // scannerWorker
            // 
            this.scannerWorker.WorkerSupportsCancellation = true;
            this.scannerWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.scannerWorker_DoWork);
            // 
            // entryCountLabel
            // 
            this.entryCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entryCountLabel.Location = new System.Drawing.Point(12, 70);
            this.entryCountLabel.Name = "entryCountLabel";
            this.entryCountLabel.Size = new System.Drawing.Size(861, 13);
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
            this.currentFileLabel.Location = new System.Drawing.Point(12, 93);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(861, 13);
            this.currentFileLabel.TabIndex = 2;
            this.currentFileLabel.Text = "label1";
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Location = new System.Drawing.Point(753, 565);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(120, 29);
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
            this.foldersGrid.Location = new System.Drawing.Point(12, 120);
            this.foldersGrid.MultiSelect = false;
            this.foldersGrid.Name = "foldersGrid";
            this.foldersGrid.ReadOnly = true;
            this.foldersGrid.RowHeadersVisible = false;
            this.foldersGrid.Size = new System.Drawing.Size(861, 439);
            this.foldersGrid.TabIndex = 4;
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
            // directoryEntryBindingSource
            // 
            this.directoryEntryBindingSource.DataSource = typeof(DirSize.Form1.DirectoryEntry);
            // 
            // folderTextBox
            // 
            this.folderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderTextBox.Location = new System.Drawing.Point(133, 12);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(740, 20);
            this.folderTextBox.TabIndex = 5;
            this.folderTextBox.Text = "C:\\";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Folder to analyze:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Exclusions:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exclusionsTextBox
            // 
            this.exclusionsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exclusionsTextBox.Location = new System.Drawing.Point(133, 38);
            this.exclusionsTextBox.Name = "exclusionsTextBox";
            this.exclusionsTextBox.Size = new System.Drawing.Size(740, 20);
            this.exclusionsTextBox.TabIndex = 7;
            this.exclusionsTextBox.Text = "C:\\Windows;C:\\Program Files (x86);C:\\Program Files";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(627, 565);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 29);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 606);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exclusionsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.foldersGrid);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.currentFileLabel);
            this.Controls.Add(this.entryCountLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foldersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryEntryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox exclusionsTextBox;
        private System.Windows.Forms.Button startButton;
    }
}

