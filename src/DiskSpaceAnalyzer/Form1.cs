using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FileSystemExtensions;
using System.IO;

namespace DirSize
{

    public partial class Form1 : Form
    {

        public class DirectoryEntry
        {
            public DirectoryInfo Directory { get; set; }
            public long Length { get; set; }

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
        private FileInfo currentFile;
        private long fileCount;
        private Dictionary<string, DirectoryEntry> entries;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedDirectory = null;
            currentFile = null;
            fileCount = 0;
            entries = new Dictionary<string, DirectoryEntry>(StringComparer.OrdinalIgnoreCase);
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (Directory.Exists(dialog.SelectedPath))
            {
                selectedDirectory = new DirectoryInfo(dialog.SelectedPath);
                scannerWorker.RunWorkerAsync();
            }
        }

        private void scannerWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                foreach (FileInfo file in selectedDirectory.SafeEnumerateFiles("*", SearchOption.AllDirectories))
                {
                    fileCount++;
                    currentFile = file;
                    try
                    {
                        UpdateEntriesFor(file);
                    }
                    catch { /* Ignore */ }
                    if (scannerWorker.CancellationPending) break;
                }
            }
            finally
            {
                WriteResultsToFile();
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

        private void WriteResultsToFile()
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
                writer.WriteLine("directory,size (bytes),size (kB),size (MB), size (GB)");
                foreach (DirectoryEntry entry in entries.Values.OrderByDescending(each => each.Length).ToArray())
                {
                    writer.WriteLine(string.Format("{0},{1},{2},{3},{4}",
                        entry.DirectoryCSVName,
                        entry.Length,
                        entry.Length / 1024.0,
                        entry.Length / 1024.0 / 1024.0,
                        entry.Length / 1024.0 / 1024.0 / 1024.0));
                }
                writer.Flush();
            }

            MessageBox.Show(string.Format("Results written to: {0}", fileName));
            currentFile = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
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
            analyzeButton.Enabled = !scannerWorker.IsBusy;
            stopButton.Enabled = scannerWorker.IsBusy && !scannerWorker.CancellationPending;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            scannerWorker.CancelAsync();
        }
    }
}
