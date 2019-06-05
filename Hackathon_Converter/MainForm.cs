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
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Select the directory containing the files you want to convert.",
                // Default to the My Documents folder.
                RootFolder = Environment.SpecialFolder.MyComputer,
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            };

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
            Stream htmlStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "out.html",
                Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if ((htmlStream = saveFileDialog.OpenFile()) == null)
            {
                return;
            }

            BtnConvert.Enabled = false;
            Format_Options.Enabled = false;
            btn_ClearList.Enabled = false;
            btn_AddOnlyFile.Enabled = false;
            btn_AddFiles.Enabled = false;
            fileDataGrid.Enabled = false;

            var parser = new USFMToolsSharp.USFMParser(new List<string> { "s5" });
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
                usfm.Insert(parser.ParseFromString(text));
            }
            var html = renderer.Render(usfm);
            var bytes = Encoding.UTF8.GetBytes(html);
            htmlStream.Write(bytes, 0, bytes.Length);
            htmlStream.Close();

            var htmlFilename = saveFileDialog.FileName;
            var dirname = Path.GetDirectoryName(htmlFilename);
            var cssFilename = Path.Combine(dirname, "style.css");
            if (File.Exists(cssFilename) == false)
            {
                File.Copy("style.css", cssFilename);
            }

            BtnConvert.Enabled = true;
            Format_Options.Enabled = true;
            btn_ClearList.Enabled = true;
            btn_AddOnlyFile.Enabled = true;
            btn_AddFiles.Enabled = true;
            fileDataGrid.Enabled = true;
        }
        private void onRemoveFile(object sender, EventArgs e)
        {
            //Receives Cell that is double clicked

            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                fileDataGrid.Rows.Remove(dgv.CurrentRow);
            }
        }
        private void onClearListButtonClick(object sender, EventArgs e)
        {
            //Empties/Resets entire list
            fileDataGrid.Rows.Clear();
        }

        private void onAddOnlyFileClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                
            };

            //Show the FolderBrowserDialog.
            DialogResult result = openFileDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            var filePath = openFileDialog.FileName;

            if (filePath.ToLower().EndsWith(".usfm") ||
                filePath.ToLower().EndsWith(".txt"))
            {
                fileDataGrid.Rows.Add(new String[] { filePath });
            }
            
        }
        private void Single_space_CheckedChanged(object sender,EventArgs e)
        {

        }
        private void Double_space_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Single_col_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Double_col_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Direct_L2R_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Direct_R2L_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
