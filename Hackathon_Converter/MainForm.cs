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

            Show_Conversion_Page();
            this.Btn_Convert.Enabled = true;
            
        }

        private void OnConvertButtonClick(object sender, EventArgs e)
        {
            Stream htmlStream;

            StringBuilder fileName = new StringBuilder();
            fileName.Append(FileNameInput.Text.Trim());
            if (fileName.ToString().Length > 0)
                fileName.Append(".html");
            else
                fileName.Append("out.html");
            

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = fileName.ToString(),
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
                Show_Error_Page();
            }
            else
            { 
                btn_AddFiles.Enabled = false;
                fileDataGrid.Enabled = false;
                //Show_Loading_Page();


                // Does not parse through section headers yet
                var parser = new USFMToolsSharp.USFMParser(new List<string> { "s5","s","s2","s3","s4" });

                //Configure Settings -- Spacing ? 1, Column# ? 1, TextDirection ? L2R 
                var renderer = new USFMToolsSharp.HtmlRenderer(isSingleSpaced, hasOneColumn, isL2RDirection,isTextJustified,willSeparateChap);

            
                // Added ULB License and Page Number
                renderer.FrontMatterHTML = GetLicenseInfo();
                renderer.InsertedFooter = GetFooterInfo();

                var usfm = new USFMToolsSharp.Models.Markers.USFMDocument();

                //var progress = fileDataGrid.RowCount-1;
                //var progressStep = 0;

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

                    //progressStep++;
                    //LoadingBar.Value = (int)(progressStep / (float)progress * 100);
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

                btn_AddFiles.Enabled = true;
                fileDataGrid.Enabled = true;
                //LoadingBar.Value = 0;
                Show_Success_Page();
            }
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
            

        }

        private void onRemoveFileButtonClick(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection SelectedFiles = fileDataGrid.SelectedCells;
            int numRemove = 1;
            if (fileDataGrid.Rows.Count > 1)
            {

                
                foreach(DataGridViewCell SelectFile in SelectedFiles)
                {
                    if(SelectFile.OwningRow.Index != fileDataGrid.RowCount-1)
                        fileDataGrid.Rows.Remove(SelectFile.OwningRow);
                }
            }

            
            if (fileDataGrid.Rows.Count == 1)
                numRemove = 0;

            btn_Remove.Text = $"Delete ({numRemove}) Files";


        }

        private void Btn_NewProj_Click(object sender, EventArgs e)
        {
            Show_Home_Page();
            fileDataGrid.Rows.Clear();
        }

        private void Btn_OpenFileLocation_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }
        private void fileDataGrid_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
            DataGridViewElementStates state = e.StateChanged;
            DataGridViewSelectedCellCollection SelectedFiles = fileDataGrid.SelectedCells;


            int numFilesRemove = SelectedFiles.Count;
            if (SelectedFiles.Contains(fileDataGrid[0, fileDataGrid.RowCount-1]))
                numFilesRemove--;

            //if (SelectedFiles.Contains(fileDataGrid.Rows[fileDataGrid.RowCount - 1].Cells[1]))
            //    numFilesRemove--;
            btn_Remove.Text = $"Delete ({numFilesRemove}) Files";
        }

        private void Btn_Format_Click(object sender, EventArgs e)
        {
            Show_Format_Page();
        }

        private void Btn_Spaced_Click(object sender, EventArgs e)
        {
            // Pseudo Radio Button Styling
            isSingleSpaced = !isSingleSpaced;
            if (isSingleSpaced)
            {
                this.Btn_SingleSpaced.BackColor = System.Drawing.Color.White;
                this.Btn_SingleSpaced.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
                this.Btn_SingleSpaced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));

                // Grayed Out Button
                this.Btn_DoubleSpaced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
                this.Btn_DoubleSpaced.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
                this.Btn_DoubleSpaced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            }
            else
            {
                this.Btn_DoubleSpaced.BackColor = System.Drawing.Color.White;
                this.Btn_DoubleSpaced.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
                this.Btn_DoubleSpaced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));

                // Grayed Out Button
                this.Btn_SingleSpaced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
                this.Btn_SingleSpaced.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
                this.Btn_SingleSpaced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            }
        }

        private void Btn_Col_Click(object sender, EventArgs e)
        {
            hasOneColumn = !hasOneColumn;
            if (hasOneColumn)
            {
                this.Btn_OneCol.BackColor = System.Drawing.Color.White;
                this.Btn_OneCol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
                this.Btn_OneCol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));

                // Grayed Out Button
                this.Btn_TwoCol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
                this.Btn_TwoCol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
                this.Btn_TwoCol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            }
            else
            {
                this.Btn_TwoCol.BackColor = System.Drawing.Color.White;
                this.Btn_TwoCol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
                this.Btn_TwoCol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));

                // Grayed Out Button
                this.Btn_OneCol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
                this.Btn_OneCol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
                this.Btn_OneCol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            }
        }

        private void Btn_Direction_Click(object sender, EventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            isL2RDirection = !isL2RDirection;
            if (isL2RDirection)
            {
                this.Btn_LTR.BackColor = System.Drawing.Color.White;
                this.Btn_LTR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
                this.Btn_LTR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));

                // Grayed Out Button
                this.Btn_RTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
                this.Btn_RTL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
                this.Btn_RTL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));

                // Switch Alignment
                this.Btn_TextAlignDefault.Text = "   Left Aligned";
                this.Btn_TextAlignDefault.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TextAlignDefault.Image")));
                this.Btn_TextAlignDefault.TextImageRelation = TextImageRelation.ImageBeforeText;

            }
            else
            {
                this.Btn_RTL.BackColor = System.Drawing.Color.White;
                this.Btn_RTL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
                this.Btn_RTL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));

                // Grayed Out Button
                this.Btn_LTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
                this.Btn_LTR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
                this.Btn_LTR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));

                // Switch Alignment
                this.Btn_TextAlignDefault.Text = "   Right Aligned";
                this.Btn_TextAlignDefault.Image = global::Hackathon_Converter.Properties.Resources.Text_Align_R;
                this.Btn_TextAlignDefault.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }
        private void Btn_TextAlign_Click(object sender, EventArgs e)
        {
            isTextJustified = !isTextJustified;
            if (isTextJustified)
            {
                this.Btn_TextJustify.BackColor = System.Drawing.Color.White;
                this.Btn_TextJustify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
                this.Btn_TextJustify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));

                // Grayed Out Button
                this.Btn_TextAlignDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
                this.Btn_TextAlignDefault.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
                this.Btn_TextAlignDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            }
            else
            {
                this.Btn_TextAlignDefault.BackColor = System.Drawing.Color.White;
                this.Btn_TextAlignDefault.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
                this.Btn_TextAlignDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));

                // Grayed Out Button
                this.Btn_TextJustify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
                this.Btn_TextJustify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
                this.Btn_TextJustify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            }
        }
        private void Btn_Chap_Click(object sender, EventArgs e)
        {
            willSeparateChap = !willSeparateChap;
            if (willSeparateChap)
            {
                this.Btn_ChapBreak.BackColor = System.Drawing.Color.White;
                this.Btn_ChapBreak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
                this.Btn_ChapBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));

                // Grayed Out Button
                this.Btn_ChapComb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
                this.Btn_ChapComb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
                this.Btn_ChapComb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            }
            else
            {
                this.Btn_ChapComb.BackColor = System.Drawing.Color.White;
                this.Btn_ChapComb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
                this.Btn_ChapComb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));

                // Grayed Out Button
                this.Btn_ChapBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
                this.Btn_ChapBreak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
                this.Btn_ChapBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            }
        }

        private void Btn_FormatBack_Click(object sender, EventArgs e)
        {
            Show_Conversion_Page();
        }

        private void Show_Home_Page()
        {
            Success_Page.Visible = false;
            Conversion_Page.Visible = false;
            Loading_Page.Visible = false;
            Format_Page.Visible = false;
            Error_Page.Visible = false;
        }
        private void Show_Conversion_Page()
        {
            Success_Page.Visible = false;
            Conversion_Page.Visible = true;
            Loading_Page.Visible = false;
            Format_Page.Visible = false;
            Error_Page.Visible = false;
        }
        private void Show_Success_Page()
        {
            Success_Page.Visible = true;
            Conversion_Page.Visible = false;
            Loading_Page.Visible = false;
            Format_Page.Visible = false;
            Error_Page.Visible = false;
        }
        private void Show_Format_Page()
        {
            Success_Page.Visible = false;
            Conversion_Page.Visible = false;
            Loading_Page.Visible = false;
            Format_Page.Visible = true;
            Error_Page.Visible = false;
        }
        private void Show_Error_Page()
        {
            Success_Page.Visible = false;
            Conversion_Page.Visible = false;
            Loading_Page.Visible = false;
            Format_Page.Visible = false;
            Error_Page.Visible = true;
        }
        private void Show_Loading_Page()
        {
            Success_Page.Visible = false;
            Conversion_Page.Visible = false;
            Loading_Page.Visible = true;
            Format_Page.Visible = false;
            Error_Page.Visible = false;
        }

    }

}
