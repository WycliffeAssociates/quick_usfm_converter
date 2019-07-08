using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using USFMToolsSharp;
using USFMToolsSharp.Models;
using USFMToolsSharp.Models.Markers;

namespace USFM_Converter
{
    public partial class MainForm : Form
    {
        private bool isTextJustified = false;
        private bool isSingleSpaced = true;
        private bool hasOneColumn = true;
        private bool isL2RDirection = true;
        private bool willSeparateChap = true;
        private string filePathConversion;

        private HTMLConfig configHTML;

        private Dictionary<double, string> LineSpacingClasses;
        private string[] ColumnClasses;
        private string[] TextDirectionClasses;
        private string[] TextAlignmentClasses;

        private Color whiteColor = Color.White;
        private Color darkBlue = Color.FromArgb(0, 68, 214);
        private Color disableBack = Color.FromArgb(215, 218, 224);
        private Color disableFore = Color.FromArgb(118, 118, 118);

        // Drag Drop
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        public MainForm()
        {
            InitCustomLabelFont();
            InitializeComponent();

            fileDataGrid.ColumnCount = 1;
            fileDataGrid.Columns[0].Name = "File";
            fileDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LineSpacingClasses = new Dictionary<double, string>
            {
                [1] = "single-space",
                [1.5] = "one-half-space",
                [2] = "double-space",
                [2.5] = "two-half-space",
                [3] = "triple-space"
            };
            ColumnClasses = new string[]{ "", "two-column" };
            TextDirectionClasses = new string[] { "", "rtl-direct" };
            TextAlignmentClasses = new string[] { "", "right-align", "center-align", "justified" };

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
            //Implement for dropdown options setConfigObject();


            string saveFileName = (!string.IsNullOrWhiteSpace(FileNameInput.Text) ? FileNameInput.Text.Trim() : "out") + ".html";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = saveFileName,
                Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = false
            };
            
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
                
            }
            else
            { 
                btn_AddFiles.Enabled = false;
                fileDataGrid.Enabled = false;
                Show_Loading_Page();

                // Does not parse through section headers yet
                var parser = new USFMParser(new List<string> { "s5" });

                configHTML = BuildConfig();
                //Configure Settings -- Spacing ? 1, Column# ? 1, TextDirection ? L2R 
                var renderer = new HtmlRenderer(configHTML);

                // Added ULB License and Page Number
                renderer.FrontMatterHTML = GetLicenseInfo();
                renderer.InsertedFooter = GetFooterInfo();

                var usfm = new USFMDocument();

                var progress = fileDataGrid.RowCount;
                var progressStep = 0;

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

                    

                    progressStep++;
                    LoadingBar.Value = (int)(progressStep / (float)progress * 100);
                }

                var html = renderer.Render(usfm);
                var htmlFilename = saveFileDialog.FileName;

                File.WriteAllText(htmlFilename, html);

                var dirname = Path.GetDirectoryName(htmlFilename);
                filePathConversion = dirname;
                var cssFilename = Path.Combine(dirname, "style.css");
                if (!File.Exists(cssFilename))
                {
                    File.Copy("style.css", cssFilename);
                }

                btn_AddFiles.Enabled = true;
                fileDataGrid.Enabled = true;
                LoadingBar.Value = 0;
                ResetValues();
                Show_Success_Page();
            }
        }



        private string GetLicenseInfo()
        {
            // Identifies License within Directory 
            string ULB_License_Doc = "insert_ULB_License.html";
            FileInfo f = new FileInfo(ULB_License_Doc);
            string licenseHTML = "";

            if (File.Exists(ULB_License_Doc))
            {

                licenseHTML = File.ReadAllText(ULB_License_Doc);
            }
            return licenseHTML;
        }
        private string GetFooterInfo()
        {
            // Format --  June 13, 2019 11:42
            string dateFormat = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            string footerHTML = $@"
            <div class=FooterSection>
            <table id='hrdftrtbl' border='0' cellspacing='0' cellpadding='0'>
            <div class=FooterSection>
            <table id='hrdftrtbl' border='0' cellspacing='0' cellpadding='0'>
            <tr><td>
            <div style='mso-element:footer' id=f1>
            <p class=MsoFooter></p>
            {dateFormat}
            <span style=mso-tab-count:1></span>
            <span style='mso-field-code: PAGE '></span><span style='mso-no-proof:yes'></span></span>
            <span style=mso-tab-count:1></span>
            <img alt='Creative Commons License' style='border-width:0' src='https://i.creativecommons.org/l/by-sa/4.0/88x31.png' />
            </p>
            </div>
            </td></tr>
            </table>
            </div> ";
            return footerHTML;
        }

        private void onAddOnlyFileClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "USFM files (*.usfm)|*.usfm|Text files (*.txt)|*.txt",
                Multiselect = true
            };
            
            //Show the FolderBrowserDialog.
            DialogResult result = openFileDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            foreach (var filePath in openFileDialog.FileNames)
            {
                if (filePath.ToLower().EndsWith(".usfm") ||
                    filePath.ToLower().EndsWith(".txt"))
                {
                    fileDataGrid.Rows.Add(new String[] { filePath });
                }
            }
        }

        private void onRemoveFileButtonClick(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection SelectedFiles = fileDataGrid.SelectedCells;
            int numRemove = 0;
            
            foreach(DataGridViewCell SelectFile in SelectedFiles)
            {
                fileDataGrid.Rows.Remove(SelectFile.OwningRow);
            }
            if (fileDataGrid.Rows.GetRowCount(DataGridViewElementStates.None) >= 1)
            {
                numRemove = 1;
            }
            btn_Remove.Text = $"Delete ({numRemove}) Files";
        }

        private void Btn_NewProj_Click(object sender, EventArgs e)
        {
            Show_Home_Page();
            fileDataGrid.Rows.Clear();
        }

        private void Btn_OpenFileLocation_Click(object sender, EventArgs e)
        {
            if (filePathConversion == null)
                Process.Start("explorer.exe");
            else
                Process.Start(filePathConversion);
        }
        private void fileDataGrid_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            DataGridViewElementStates state = e.StateChanged;
            DataGridViewSelectedCellCollection SelectedFiles = fileDataGrid.SelectedCells;
            int numFilesRemove = SelectedFiles.Count;
            if(fileDataGrid.Rows.GetRowCount(DataGridViewElementStates.None) >= 1)
            {
                numFilesRemove = 1;
            }
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
                this.Btn_SingleSpaced.BackColor = whiteColor;
                this.Btn_SingleSpaced.FlatAppearance.BorderColor = darkBlue;
                this.Btn_SingleSpaced.ForeColor = darkBlue;

                // Grayed Out Button
                this.Btn_DoubleSpaced.BackColor = disableBack;
                this.Btn_DoubleSpaced.FlatAppearance.BorderColor = disableFore;
                this.Btn_DoubleSpaced.ForeColor = disableFore;
            }
            else
            {
                this.Btn_DoubleSpaced.BackColor = whiteColor;
                this.Btn_DoubleSpaced.FlatAppearance.BorderColor = darkBlue;
                this.Btn_DoubleSpaced.ForeColor = darkBlue;

                // Grayed Out Button
                this.Btn_SingleSpaced.BackColor = disableBack;
                this.Btn_SingleSpaced.FlatAppearance.BorderColor = disableFore;
                this.Btn_SingleSpaced.ForeColor = disableFore;

            }
        }

        private void Btn_Col_Click(object sender, EventArgs e)
        {
            hasOneColumn = !hasOneColumn;
            if (hasOneColumn)
            {
                this.Btn_OneCol.BackColor = whiteColor;
                this.Btn_OneCol.FlatAppearance.BorderColor = darkBlue;
                this.Btn_OneCol.ForeColor = darkBlue;

                // Grayed Out Button
                this.Btn_TwoCol.BackColor = disableBack;
                this.Btn_TwoCol.FlatAppearance.BorderColor = disableFore;
                this.Btn_TwoCol.ForeColor = disableFore;

            }
            else
            {
                this.Btn_TwoCol.BackColor = whiteColor;
                this.Btn_TwoCol.FlatAppearance.BorderColor = darkBlue;
                this.Btn_TwoCol.ForeColor = darkBlue;

                // Grayed Out Button
                this.Btn_OneCol.BackColor = disableBack;
                this.Btn_OneCol.FlatAppearance.BorderColor = disableFore;
                this.Btn_OneCol.ForeColor = disableFore;

            }
        }

        private void Btn_Direction_Click(object sender, EventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            isL2RDirection = !isL2RDirection;
            if (isL2RDirection)
            {
                this.Btn_LTR.BackColor = whiteColor;
                this.Btn_LTR.FlatAppearance.BorderColor = darkBlue;
                this.Btn_LTR.ForeColor = darkBlue;

                // Grayed Out Button
                this.Btn_RTL.BackColor = disableBack;
                this.Btn_RTL.FlatAppearance.BorderColor = disableFore;
                this.Btn_RTL.ForeColor = disableFore;

                // Switch Alignment
                this.Btn_TextAlignDefault.Text = "   Left Aligned";
                this.Btn_TextAlignDefault.Image = Properties.Resources.Text_Align;
                this.Btn_TextAlignDefault.TextImageRelation = TextImageRelation.ImageBeforeText;

            }
            else
            {
                this.Btn_RTL.BackColor = whiteColor;
                this.Btn_RTL.FlatAppearance.BorderColor = darkBlue;
                this.Btn_RTL.ForeColor = darkBlue;

                // Grayed Out Button
                this.Btn_LTR.BackColor = disableBack;
                this.Btn_LTR.FlatAppearance.BorderColor = disableFore;
                this.Btn_LTR.ForeColor = disableFore;

                // Switch Alignment
                this.Btn_TextAlignDefault.Text = "   Right Aligned";
                this.Btn_TextAlignDefault.Image = Properties.Resources.Text_Align_R;
                this.Btn_TextAlignDefault.TextImageRelation = TextImageRelation.ImageBeforeText;

            }
        }
        private void Btn_TextAlign_Click(object sender, EventArgs e)
        {
            isTextJustified = !isTextJustified;
            if (isTextJustified)
            {
                this.Btn_TextJustify.BackColor = whiteColor;
                this.Btn_TextJustify.FlatAppearance.BorderColor = darkBlue;
                this.Btn_TextJustify.ForeColor = darkBlue;

                // Grayed Out Button
                this.Btn_TextAlignDefault.BackColor = disableBack;
                this.Btn_TextAlignDefault.FlatAppearance.BorderColor = disableFore;
                this.Btn_TextAlignDefault.ForeColor = disableFore;

            }
            else
            {
                this.Btn_TextAlignDefault.BackColor = whiteColor;
                this.Btn_TextAlignDefault.FlatAppearance.BorderColor = darkBlue;
                this.Btn_TextAlignDefault.ForeColor = darkBlue;

                // Grayed Out Button
                this.Btn_TextJustify.BackColor = disableBack;
                this.Btn_TextJustify.FlatAppearance.BorderColor = disableFore;
                this.Btn_TextJustify.ForeColor = disableFore;

            }
        }
        private void Btn_Chap_Click(object sender, EventArgs e)
        {
            willSeparateChap = !willSeparateChap;
            if (willSeparateChap)
            {
                this.Btn_ChapBreak.BackColor = whiteColor;
                this.Btn_ChapBreak.FlatAppearance.BorderColor = darkBlue;
                this.Btn_ChapBreak.ForeColor = darkBlue;

                // Grayed Out Button
                this.Btn_ChapComb.BackColor = disableBack;
                this.Btn_ChapComb.FlatAppearance.BorderColor = disableFore;
                this.Btn_ChapComb.ForeColor = disableFore;
            }
            else
            {
                this.Btn_ChapComb.BackColor = whiteColor;
                this.Btn_ChapComb.FlatAppearance.BorderColor = darkBlue;
                this.Btn_ChapComb.ForeColor = darkBlue;

                // Grayed Out Button
                this.Btn_ChapBreak.BackColor = disableBack;
                this.Btn_ChapBreak.FlatAppearance.BorderColor = disableFore;
                this.Btn_ChapBreak.ForeColor = disableFore;
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
        private void ResetValues()
        {
            FileNameInput.Text = "";

        }        
        private HTMLConfig BuildConfig()
        {
            HTMLConfig config = new HTMLConfig();
            if (!isSingleSpaced)
            {
                config.divClasses.Add(LineSpacingClasses[2.0]);
            }
            if (!hasOneColumn)
            {
                config.divClasses.Add(ColumnClasses[1]);
            }
            if (!isL2RDirection)
            {
                config.divClasses.Add(TextDirectionClasses[1]);
            }
            if (isTextJustified)
            {
                config.divClasses.Add(TextAlignmentClasses[3]);
            }
            config.separateChapters = willSeparateChap;
            return config;
        }
        private void fileDataGrid_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = fileDataGrid.DoDragDrop( fileDataGrid.Rows[rowIndexFromMouseDown], DragDropEffects.Move);
                }
            }
        }

        private void fileDataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = fileDataGrid.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.

                // Figure way to show item dragged
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void fileDataGrid_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void fileDataGrid_DragDrop(object sender, DragEventArgs e)
        {
            // Must be converted to client coordinates.
            Point clientPoint = fileDataGrid.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop = fileDataGrid.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // Remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                fileDataGrid.Rows.RemoveAt(rowIndexFromMouseDown);
                fileDataGrid.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);

            }
        }

    }

}
