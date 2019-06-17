using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            InitCustomLabelFont();
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

            this.ConversionPage.Visible = true;
            this.Btn_Convert.Enabled = true;
            this.Btn_Convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(174)))), ((int)(((byte)(234)))));
        }

        private void OnConvertButtonClick(object sender, EventArgs e)
        {
            Stream htmlStream;

            
            

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "out.html",
                Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = false
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if ((htmlStream = saveFileDialog.OpenFile()) == null)
            {
                return;
            }

            //BtnConvert.Enabled = false;
            //Format_Options.Enabled = false;
            //btnRemoveFile.Enabled = false;
            //btn_ClearList.Enabled = false;
            //btn_AddOnlyFile.Enabled = false;
            btn_AddFiles.Enabled = false;
            fileDataGrid.Enabled = false;

            // Does not parse through section headers yet
            var parser = new USFMToolsSharp.USFMParser(new List<string> { "s5","s","s2","s3","s4" });

            //Configure Settings -- Spacing ? 1, Column# ? 1, TextDirection ? L2R 
            var renderer = new USFMToolsSharp.HtmlRenderer(isSingleSpaced, hasOneColumn, isL2RDirection,isTextJustified,willSeparateChap);

            
            // Added ULB License and Page Number
            renderer.FrontMatterHTML = GetLicenseInfo();
            renderer.InsertedFooter = GetFooterInfo();

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

            //BtnConvert.Enabled = true;
            //Format_Options.Enabled = true;
            //btnRemoveFile.Enabled = true;
            //btn_ClearList.Enabled = true;
            //btn_AddOnlyFile.Enabled = true;
            btn_AddFiles.Enabled = true;
            fileDataGrid.Enabled = true;
            Confirmation_Page.Visible = true;
            Btn_Convert.Enabled = false;
            Btn_Convert.BackColor = System.Drawing.Color.DarkGray;
        }
        private string GetLicenseInfo()
        {
            // Identifies License within Directory 
            string ULB_License_Doc = "insert_ULB_License.html";
            FileInfo f = new FileInfo(ULB_License_Doc);
            string fullname = f.FullName;
            string licenseHTML = "";

            if (File.Exists(ULB_License_Doc) == true)
            {

                using (FileStream fs = File.OpenRead(fullname))
                {
                    byte[] b = new byte[32 * 1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        licenseHTML += (temp.GetString(b));
                    }
                }
            }
            return licenseHTML;
        }
        private string GetFooterInfo()
        {
            // Format --  June 13, 2019 11:42
            string dateFormat = System.DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            StringBuilder footerHTML = new StringBuilder();
            footerHTML.AppendLine("<div class=FooterSection> ");
            footerHTML.AppendLine("<table id='hrdftrtbl' border='0' cellspacing='0' cellpadding='0'>");
            footerHTML.AppendLine("<tr><td>");
            footerHTML.AppendLine("<div style='mso-element:footer' id=f1>");
            footerHTML.AppendLine("<p class=MsoFooter></p>");
            footerHTML.AppendLine(dateFormat);
            footerHTML.AppendLine("<span style=mso-tab-count:1></span>");
            footerHTML.AppendLine("  <span style='mso-field-code: PAGE '></span><span style='mso-no-proof:yes'></span></span>");
            footerHTML.AppendLine("  <span style=mso-tab-count:1></span>");
            footerHTML.AppendLine("  <img alt=\"Creative Commons License\" style=\"border-width:0\" src=\"https://i.creativecommons.org/l/by/4.0/88x31.png\" />");
            footerHTML.AppendLine("</p>");
            footerHTML.AppendLine("   </div>");
            footerHTML.AppendLine("</td></tr>");
            footerHTML.AppendLine("</table>");
            footerHTML.AppendLine("</div>");
            return footerHTML.ToString();
        }
        private void onClearListButtonClick(object sender, EventArgs e)
        {
            fileDataGrid.Rows.Clear();
        }

        private void onAddOnlyFileClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "USFM files (*.usfm)|*.usfm|Text files (*.txt)|*.txt |All files (*.*)|*.*"
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
            this.ConversionPage.Visible = true;
            this.Btn_Convert.Enabled = true;
            this.Btn_Convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(174)))), ((int)(((byte)(234)))));

        }
        //private void Single_space_CheckedChanged(object sender,EventArgs e)
        //{
        //    //line-height: 1 ;
        //    if (Single_Space.Checked)
        //    {
        //        // Keep track of the selected RadioButton by saving a reference
        //        // to it.
        //        isSingleSpaced = true;
        //    }

        //}
        //private void Double_space_CheckedChanged(object sender, EventArgs e)
        //{
        //    //line-height: 2 ;
        //    if (Double_Space.Checked)
        //    {
        //        isSingleSpaced = false;
        //    }

        //}
        //private void Single_col_CheckedChanged(object sender, EventArgs e)
        //{
        //    /* Column count */
        //    //columns: auto;
        //    //columns: 1;
        //    if (Single_col.Checked)
        //    {
        //        hasOneColumn = true;
        //    }

        //}
        //private void Double_col_CheckedChanged(object sender, EventArgs e)
        //{
        //    /* Column count */
        //    //columns: auto;
        //    //columns: 2;
        //    if (Double_Col.Checked)
        //    {
        //        hasOneColumn = false;
        //    }

        //}
        //private void Direct_L2R_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (directL2R.Checked)
        //    {

        //        isL2RDirection = true;
        //    }
        //}
        //private void Direct_R2L_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (directR2L.Checked)
        //    {

        //        isL2RDirection = false;
        //    }
        //}

        //private void isJustified_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (isJustified.Checked)
        //    {

        //        isTextJustified = true;
        //    }
        //    else
        //    {
        //        isTextJustified = false;
        //    }
        //}

        //private void chapSeparate_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chapSeparate.Checked)
        //    {

        //        willSeparateChap = true;
        //    }
        //    else
        //    {
        //        willSeparateChap = false;
        //    }
        //}

        private void onRemoveFileButtonClick(object sender, EventArgs e)
        { 
            if(fileDataGrid.Rows.Count > 1)
            {
                foreach(DataGridViewCell CellObject in fileDataGrid.SelectedCells)
                {
                    fileDataGrid.Rows.Remove(CellObject.OwningRow);
                }
            }
                
        }

        private void Btn_BrowseFiles_Click(object sender, EventArgs e)
        {
            this.ConversionPage.Visible = true;
            this.Btn_Convert.Enabled = true;
            this.Btn_Convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(174)))), ((int)(((byte)(234)))));
        }

        private void Btn_NewProj_Click(object sender, EventArgs e)
        {
            ConversionPage.Visible = false;
            Confirmation_Page.Visible = false;
            fileDataGrid.Rows.Clear();
        }

        private void Btn_OpenFileLocation_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe",@"c:\does_not_exists");
        }
        private void fileDataGrid_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            DataGridViewElementStates state = e.StateChanged;
            int numFilesRemove = fileDataGrid.SelectedCells.Count;
            btn_Remove.Text = $"Remove ( {numFilesRemove} )";
        }
    }
}
