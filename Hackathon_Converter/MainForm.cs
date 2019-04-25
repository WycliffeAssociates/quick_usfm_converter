using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_Converter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            fileDataGrid.ColumnCount = 1;
            fileDataGrid.Columns[0].Name = "File";
            fileDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void OnAddFilesButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the directory containing the files you want to convert.";
            // Default to the My Documents folder.
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            //Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            var folderName = folderBrowserDialog.SelectedPath;
            var dirinfo = new DirectoryInfo(folderName);
            var allFiles = dirinfo.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo fileInfo in allFiles)
            {
                if (fileInfo.FullName.ToLower().EndsWith(".usfm") ||
                    fileInfo.FullName.ToLower().EndsWith(".txt"))
                {
                    fileDataGrid.Rows.Add(new String[] { fileInfo.FullName });
                }
            }
        }

        private void OnConvertButtonClick(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "out.html";
            saveFileDialog1.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if ((myStream = saveFileDialog1.OpenFile()) == null)
            {
                return;
            }

            BtnConvert.Enabled = false;
            btn_AddFiles.Enabled = false;
            fileDataGrid.Enabled = false;

            var parser = new USFMToolsSharp.USFMParser();
            var renderer = new USFMToolsSharp.HtmlRenderer();

            var usfm = new USFMToolsSharp.Models.Markers.USFMDocument();
            foreach (DataGridViewRow row in fileDataGrid.Rows)
            {
                var cell = row.Cells[0];
                if (cell.Value == null)
                {
                    continue;
                }
                var filename = cell.Value.ToString();
                var text = File.ReadAllText(filename);
                usfm.Contents.AddRange(parser.ParseFromString(text).Contents);
            }
            var html = renderer.Render(usfm);
            var bytes = Encoding.Default.GetBytes(html);
            myStream.Write(bytes, 0, bytes.Length);
            myStream.Close();
            BtnConvert.Enabled = true;
            btn_AddFiles.Enabled = true;
            fileDataGrid.Enabled = true;
        }
    }
}
