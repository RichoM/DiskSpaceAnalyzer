using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections.Concurrent;
using FileSystemExtensions;

namespace DirSize
{

    public partial class Form1 : Form
    {

        public class DirectoryEntry
        {
            public DirectoryInfo Directory { get; set; }
            public long Length { get; set; }

            public double LengthKb { get { return Length / 1024.0; } }
            public double LengthMb { get { return LengthKb / 1024.0; } }
            public double LengthGb { get { return LengthMb / 1024.0; } }

            public string DirectoryCSVName
            {
                get
                {
                    if (Directory.FullName.Contains(','))
                    {
                        return "\"" + Directory.FullName + "\"";
                    }
                    else
                    {
                        return Directory.FullName;
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private DirectoryInfo selectedDirectory;
        private IEnumerable<DirectoryInfo> exclusions;
        private FileInfo currentFile;
        private long fileCount;
        private ConcurrentDictionary<string, DirectoryEntry> entries;
        private bool dirtyGrid = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = string.Format("Disk Space Analyzer v{0}", Application.ProductVersion);
            updateTimer.Enabled = true;
        }

        private void scannerWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                foreach (FileInfo file in selectedDirectory.SafeEnumerateFiles("*", SearchOption.AllDirectories, exclusions))
                {
                    fileCount++;
                    currentFile = file;
                    try
                    {
                        UpdateEntriesFor(file);
                        dirtyGrid = true;
                    }
                    catch { /* Ignore */ }
                    if (scannerWorker.CancellationPending) break;
                }
            }
            finally
            {
                dirtyGrid = true;
                string reportFile = WriteResultsToFile();
                Process.Start(reportFile);
            }
        }

        private void UpdateEntriesFor(FileInfo file)
        {
            DirectoryInfo directory = file.Directory;
            do
            {
                if (!entries.ContainsKey(directory.FullName))
                {
                    entries[directory.FullName] = new DirectoryEntry()
                    {
                        Directory = directory,
                        Length = 0
                    };
                }
                entries[directory.FullName].Length += file.Length;

                directory = directory.Parent;
            }
            while (directory != null && 
                (selectedDirectory.PathEqual(directory) || 
                selectedDirectory.Contains(directory)));
        }

        private string WriteResultsToFile()
        {
            string fileName;
            int index = 0;
            do
            {
                fileName = string.Format("results.{0}.{1}.csv", DateTime.Now.ToString("yyyyMMdd"), ++index);
            }
            while (File.Exists(fileName));

            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                writer.WriteLine("directory,size (bytes),size (kB),size (MB),size (GB)");
                foreach (DirectoryEntry entry in entries.Values.OrderByDescending(each => each.Length).ToArray())
                {
                    writer.WriteLine(string.Format("{0},{1},{2},{3},{4}",
                        entry.DirectoryCSVName,
                        entry.Length,
                        entry.LengthKb,
                        entry.LengthMb,
                        entry.LengthGb));
                }
                writer.Flush();
            }

            MessageBox.Show(string.Format("Results written to: {0}", fileName));
            currentFile = null;
            return fileName;
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            entryCountLabel.Text = string.Format("Files: {0}, Folders: {1}", fileCount, entries != null ? entries.Count : 0);
            if (currentFile == null)
            {
                currentFileLabel.Text = "";
            }
            else
            {
                currentFile.SafeFullNameDo(name => currentFileLabel.Text = name);
            }
            startButton.Enabled = !scannerWorker.IsBusy;
            stopButton.Enabled = scannerWorker.IsBusy && !scannerWorker.CancellationPending;
            folderTextBox.Enabled = !scannerWorker.IsBusy;
            exclusionsTextBox.Enabled = !scannerWorker.IsBusy;

            if (dirtyGrid)
            {
                dirtyGrid = false;

                if (entries != null)
                {
                    foldersGrid.DataSource = entries.Values
                        .OrderByDescending(each => each.Length)
                        .Take(100)
                        .ToArray();
                }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            scannerWorker.CancelAsync();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            selectedDirectory = null;
            currentFile = null;
            fileCount = 0;
            entries = new ConcurrentDictionary<string, DirectoryEntry>(StringComparer.OrdinalIgnoreCase);
            if (Directory.Exists(folderTextBox.Text))
            {
                selectedDirectory = new DirectoryInfo(folderTextBox.Text);
                exclusions = exclusionsTextBox.Text.Split(';').Select(each => new DirectoryInfo(each));
                scannerWorker.RunWorkerAsync();
            }
        }
    }
}
