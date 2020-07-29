using System.Collections.Generic;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using USFMToolsSharp.Models;

namespace USFM_Converter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        PrivateFontCollection customFonts = new PrivateFontCollection();
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
        private void InitCustomLabelFont()
        {

            

            //Create your private font collection object.
            

            //Select your font from the resources.
            //My font here is "Muli_ExtraBold.ttf"
            int fontLength = Properties.Resources.Muli_ExtraBold.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.Muli_ExtraBold;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            System.Runtime.InteropServices.Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            customFonts.AddMemoryFont(data, fontLength);


            // Muli_Light.ttf
            fontLength = Properties.Resources.Muli_Light.Length;
            fontdata = Properties.Resources.Muli_Light;
            data = Marshal.AllocCoTaskMem(fontLength);
            System.Runtime.InteropServices.Marshal.Copy(fontdata, 0, data, fontLength);
            customFonts.AddMemoryFont(data, fontLength);



            // Muli_Regular.ttf
            fontLength = Properties.Resources.Muli_Regular.Length;
            fontdata = Properties.Resources.Muli_Regular;
            data = Marshal.AllocCoTaskMem(fontLength);
            System.Runtime.InteropServices.Marshal.Copy(fontdata, 0, data, fontLength);
            customFonts.AddMemoryFont(data, fontLength);

            // Lato_Regular.ttf
            fontLength = Properties.Resources.Lato_Regular.Length;
            fontdata = Properties.Resources.Lato_Regular;
            data = Marshal.AllocCoTaskMem(fontLength);
            System.Runtime.InteropServices.Marshal.Copy(fontdata, 0, data, fontLength);
            customFonts.AddMemoryFont(data, fontLength);

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConversionPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ProjNameLabel = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_AddFiles = new System.Windows.Forms.Button();
            this.FileNameInput = new System.Windows.Forms.TextBox();
            this.fileDataGrid = new System.Windows.Forms.DataGridView();
            this.ConversionBanner = new System.Windows.Forms.Panel();
            this.Btn_Format = new System.Windows.Forms.Button();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.HomeCapture = new System.Windows.Forms.Panel();
            this.Btn_BrowseFiles = new System.Windows.Forms.Button();
            this.HomeImg = new System.Windows.Forms.PictureBox();
            this.HomeInstruct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Format_Page = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_FormatBack = new System.Windows.Forms.Button();
            this.Btn_Convert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_FontLarge = new System.Windows.Forms.Button();
            this.Btn_FontMed = new System.Windows.Forms.Button();
            this.Btn_FontSmall = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Btn_SeparateVerse = new System.Windows.Forms.Button();
            this.Btn_VerseDefault = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Btn_TextAlignRight = new System.Windows.Forms.Button();
            this.Btn_ChapComb = new System.Windows.Forms.Button();
            this.Btn_ChapBreak = new System.Windows.Forms.Button();
            this.Btn_TextJustify = new System.Windows.Forms.Button();
            this.Btn_TextAlignDefault = new System.Windows.Forms.Button();
            this.Btn_RTL = new System.Windows.Forms.Button();
            this.Btn_LTR = new System.Windows.Forms.Button();
            this.Btn_TwoCol = new System.Windows.Forms.Button();
            this.Btn_OneCol = new System.Windows.Forms.Button();
            this.Btn_DoubleSpaced = new System.Windows.Forms.Button();
            this.Btn_SingleSpaced = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Loading_Page = new System.Windows.Forms.Panel();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.Conversion_Page = new System.Windows.Forms.SplitContainer();
            this.Error_Page = new USFM_Converter.ColorGradient();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_RestartProj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Success_Page = new USFM_Converter.ColorGradient();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ConversionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).BeginInit();
            this.ConversionBanner.SuspendLayout();
            this.HomeCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeImg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Format_Page)).BeginInit();
            this.Format_Page.Panel1.SuspendLayout();
            this.Format_Page.Panel2.SuspendLayout();
            this.Format_Page.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Loading_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Conversion_Page)).BeginInit();
            this.Conversion_Page.Panel1.SuspendLayout();
            this.Conversion_Page.Panel2.SuspendLayout();
            this.Conversion_Page.SuspendLayout();
            this.Error_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Success_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ConversionPanel
            // 
            this.ConversionPanel.BackColor = System.Drawing.SystemColors.Window;
            this.ConversionPanel.Controls.Add(this.pictureBox4);
            this.ConversionPanel.Controls.Add(this.ProjNameLabel);
            this.ConversionPanel.Controls.Add(this.pictureBox5);
            this.ConversionPanel.Controls.Add(this.label1);
            this.ConversionPanel.Controls.Add(this.btn_Remove);
            this.ConversionPanel.Controls.Add(this.btn_AddFiles);
            this.ConversionPanel.Controls.Add(this.FileNameInput);
            this.ConversionPanel.Controls.Add(this.fileDataGrid);
            this.ConversionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConversionPanel.Location = new System.Drawing.Point(0, 0);
            this.ConversionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ConversionPanel.Name = "ConversionPanel";
            this.ConversionPanel.Size = new System.Drawing.Size(1085, 532);
            this.ConversionPanel.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::USFM_Converter.Properties.Resources.Group_70;
            this.pictureBox4.Location = new System.Drawing.Point(54, 53);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // ProjNameLabel
            // 
            this.ProjNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjNameLabel.Location = new System.Drawing.Point(84, 58);
            this.ProjNameLabel.Name = "ProjNameLabel";
            this.ProjNameLabel.Size = new System.Drawing.Size(161, 24);
            this.ProjNameLabel.TabIndex = 8;
            this.ProjNameLabel.Text = " Project Name";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::USFM_Converter.Properties.Resources.Group_69;
            this.pictureBox5.Location = new System.Drawing.Point(54, 143);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Files";
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.White;
            this.btn_Remove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(137)))));
            this.btn_Remove.Location = new System.Drawing.Point(748, 90);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(196, 34);
            this.btn_Remove.TabIndex = 4;
            this.btn_Remove.Text = "Delete";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.onRemoveFileButtonClick);
            // 
            // btn_AddFiles
            // 
            this.btn_AddFiles.BackColor = System.Drawing.Color.White;
            this.btn_AddFiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(137)))));
            this.btn_AddFiles.FlatAppearance.BorderSize = 2;
            this.btn_AddFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(137)))));
            this.btn_AddFiles.Location = new System.Drawing.Point(488, 88);
            this.btn_AddFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddFiles.Name = "btn_AddFiles";
            this.btn_AddFiles.Size = new System.Drawing.Size(181, 38);
            this.btn_AddFiles.TabIndex = 3;
            this.btn_AddFiles.Text = "+ Add Files";
            this.btn_AddFiles.UseVisualStyleBackColor = false;
            this.btn_AddFiles.Click += new System.EventHandler(this.onAddOnlyFileClick);
            // 
            // FileNameInput
            // 
            this.FileNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameInput.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FileNameInput.Location = new System.Drawing.Point(54, 91);
            this.FileNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.FileNameInput.Name = "FileNameInput";
            this.FileNameInput.Size = new System.Drawing.Size(408, 29);
            this.FileNameInput.TabIndex = 1;
            this.FileNameInput.WordWrap = false;
            // 
            // fileDataGrid
            // 
            this.fileDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.fileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.fileDataGrid.Location = new System.Drawing.Point(54, 182);
            this.fileDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.fileDataGrid.Name = "fileDataGrid";
            this.fileDataGrid.RowTemplate.Height = 33;
            this.fileDataGrid.Size = new System.Drawing.Size(904, 314);
            this.fileDataGrid.TabIndex = 0;
            this.fileDataGrid.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.fileDataGrid_CellStateChanged);
            // 
            // ConversionBanner
            // 
            this.ConversionBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(137)))));
            this.ConversionBanner.Controls.Add(this.Btn_Format);
            this.ConversionBanner.Controls.Add(this.ProjectLabel);
            this.ConversionBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConversionBanner.Location = new System.Drawing.Point(0, 0);
            this.ConversionBanner.Name = "ConversionBanner";
            this.ConversionBanner.Size = new System.Drawing.Size(1085, 91);
            this.ConversionBanner.TabIndex = 6;
            // 
            // Btn_Format
            // 
            this.Btn_Format.BackColor = System.Drawing.Color.White;
            this.Btn_Format.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Format.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(137)))));
            this.Btn_Format.Location = new System.Drawing.Point(796, 29);
            this.Btn_Format.Name = "Btn_Format";
            this.Btn_Format.Size = new System.Drawing.Size(235, 42);
            this.Btn_Format.TabIndex = 1;
            this.Btn_Format.Text = "Next: Format";
            this.Btn_Format.UseVisualStyleBackColor = false;
            this.Btn_Format.Click += new System.EventHandler(this.Btn_Format_Click);
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLabel.ForeColor = System.Drawing.Color.White;
            this.ProjectLabel.Location = new System.Drawing.Point(68, 29);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(245, 54);
            this.ProjectLabel.TabIndex = 0;
            this.ProjectLabel.Text = "Project";
            // 
            // HomeCapture
            // 
            this.HomeCapture.AllowDrop = true;
            this.HomeCapture.Controls.Add(this.Btn_BrowseFiles);
            this.HomeCapture.Controls.Add(this.HomeImg);
            this.HomeCapture.Controls.Add(this.HomeInstruct);
            this.HomeCapture.Location = new System.Drawing.Point(104, 11);
            this.HomeCapture.Margin = new System.Windows.Forms.Padding(2);
            this.HomeCapture.Name = "HomeCapture";
            this.HomeCapture.Size = new System.Drawing.Size(912, 577);
            this.HomeCapture.TabIndex = 3;
            this.HomeCapture.DragDrop += new System.Windows.Forms.DragEventHandler(this.HomeCapture_DragDrop);
            this.HomeCapture.DragEnter += new System.Windows.Forms.DragEventHandler(this.HomeCapture_DragEnter);
            // 
            // Btn_BrowseFiles
            // 
            this.Btn_BrowseFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(211)))));
            this.Btn_BrowseFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BrowseFiles.ForeColor = System.Drawing.Color.White;
            this.Btn_BrowseFiles.Location = new System.Drawing.Point(277, 495);
            this.Btn_BrowseFiles.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_BrowseFiles.Name = "Btn_BrowseFiles";
            this.Btn_BrowseFiles.Size = new System.Drawing.Size(296, 57);
            this.Btn_BrowseFiles.TabIndex = 2;
            this.Btn_BrowseFiles.Text = "Browse Files";
            this.Btn_BrowseFiles.UseVisualStyleBackColor = false;
            this.Btn_BrowseFiles.Click += new System.EventHandler(this.OnAddFilesButtonClick);
            // 
            // HomeImg
            // 
            this.HomeImg.Image = ((System.Drawing.Image)(resources.GetObject("HomeImg.Image")));
            this.HomeImg.Location = new System.Drawing.Point(159, 18);
            this.HomeImg.Margin = new System.Windows.Forms.Padding(2);
            this.HomeImg.Name = "HomeImg";
            this.HomeImg.Size = new System.Drawing.Size(520, 389);
            this.HomeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeImg.TabIndex = 0;
            this.HomeImg.TabStop = false;
            // 
            // HomeInstruct
            // 
            this.HomeInstruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeInstruct.Location = new System.Drawing.Point(135, 409);
            this.HomeInstruct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HomeInstruct.Name = "HomeInstruct";
            this.HomeInstruct.Size = new System.Drawing.Size(573, 93);
            this.HomeInstruct.TabIndex = 1;
            this.HomeInstruct.Text = "Drag and drop a USFM folder to get started.";
            this.HomeInstruct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Error_Page);
            this.panel1.Controls.Add(this.Format_Page);
            this.panel1.Controls.Add(this.HomeCapture);
            this.panel1.Controls.Add(this.Loading_Page);
            this.panel1.Controls.Add(this.Conversion_Page);
            this.panel1.Controls.Add(this.Success_Page);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 616);
            this.panel1.TabIndex = 5;
            // 
            // Format_Page
            // 
            this.Format_Page.Location = new System.Drawing.Point(0, 0);
            this.Format_Page.Name = "Format_Page";
            this.Format_Page.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Format_Page.Panel1
            // 
            this.Format_Page.Panel1.Controls.Add(this.panel2);
            // 
            // Format_Page.Panel2
            // 
            this.Format_Page.Panel2.Controls.Add(this.panel3);
            this.Format_Page.Size = new System.Drawing.Size(1085, 624);
            this.Format_Page.SplitterDistance = 91;
            this.Format_Page.TabIndex = 6;
            this.Format_Page.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(137)))));
            this.panel2.Controls.Add(this.Btn_FormatBack);
            this.panel2.Controls.Add(this.Btn_Convert);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 91);
            this.panel2.TabIndex = 6;
            // 
            // Btn_FormatBack
            // 
            this.Btn_FormatBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(137)))));
            this.Btn_FormatBack.FlatAppearance.BorderSize = 0;
            this.Btn_FormatBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FormatBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FormatBack.ForeColor = System.Drawing.Color.White;
            this.Btn_FormatBack.Image = ((System.Drawing.Image)(resources.GetObject("Btn_FormatBack.Image")));
            this.Btn_FormatBack.Location = new System.Drawing.Point(660, 29);
            this.Btn_FormatBack.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_FormatBack.Name = "Btn_FormatBack";
            this.Btn_FormatBack.Size = new System.Drawing.Size(123, 41);
            this.Btn_FormatBack.TabIndex = 2;
            this.Btn_FormatBack.Text = "Back";
            this.Btn_FormatBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_FormatBack.UseVisualStyleBackColor = false;
            this.Btn_FormatBack.Click += new System.EventHandler(this.Btn_FormatBack_Click);
            // 
            // Btn_Convert
            // 
            this.Btn_Convert.BackColor = System.Drawing.Color.White;
            this.Btn_Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Convert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(137)))));
            this.Btn_Convert.Location = new System.Drawing.Point(796, 29);
            this.Btn_Convert.Name = "Btn_Convert";
            this.Btn_Convert.Size = new System.Drawing.Size(235, 42);
            this.Btn_Convert.TabIndex = 1;
            this.Btn_Convert.Text = "Convert";
            this.Btn_Convert.UseVisualStyleBackColor = false;
            this.Btn_Convert.Click += new System.EventHandler(this.OnConvertButtonClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Format Options";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.Btn_FontLarge);
            this.panel3.Controls.Add(this.Btn_FontMed);
            this.panel3.Controls.Add(this.Btn_FontSmall);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.Btn_SeparateVerse);
            this.panel3.Controls.Add(this.Btn_VerseDefault);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.Btn_TextAlignRight);
            this.panel3.Controls.Add(this.Btn_ChapComb);
            this.panel3.Controls.Add(this.Btn_ChapBreak);
            this.panel3.Controls.Add(this.Btn_TextJustify);
            this.panel3.Controls.Add(this.Btn_TextAlignDefault);
            this.panel3.Controls.Add(this.Btn_RTL);
            this.panel3.Controls.Add(this.Btn_LTR);
            this.panel3.Controls.Add(this.Btn_TwoCol);
            this.panel3.Controls.Add(this.Btn_OneCol);
            this.panel3.Controls.Add(this.Btn_DoubleSpaced);
            this.panel3.Controls.Add(this.Btn_SingleSpaced);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1085, 529);
            this.panel3.TabIndex = 4;
            // 
            // Btn_FontLarge
            // 
            this.Btn_FontLarge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.Btn_FontLarge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_FontLarge.FlatAppearance.BorderSize = 2;
            this.Btn_FontLarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FontLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FontLarge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_FontLarge.Location = new System.Drawing.Point(629, 366);
            this.Btn_FontLarge.Name = "Btn_FontLarge";
            this.Btn_FontLarge.Size = new System.Drawing.Size(151, 51);
            this.Btn_FontLarge.TabIndex = 32;
            this.Btn_FontLarge.Text = "Large";
            this.Btn_FontLarge.UseVisualStyleBackColor = false;
            this.Btn_FontLarge.Click += new System.EventHandler(this.Btn_FontLarge_Click);
            // 
            // Btn_FontMed
            // 
            this.Btn_FontMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.Btn_FontMed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_FontMed.FlatAppearance.BorderSize = 2;
            this.Btn_FontMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FontMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FontMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_FontMed.Location = new System.Drawing.Point(480, 366);
            this.Btn_FontMed.Name = "Btn_FontMed";
            this.Btn_FontMed.Size = new System.Drawing.Size(154, 51);
            this.Btn_FontMed.TabIndex = 31;
            this.Btn_FontMed.Text = "Medium";
            this.Btn_FontMed.UseVisualStyleBackColor = false;
            this.Btn_FontMed.Click += new System.EventHandler(this.Btn_FontMed_Click);
            // 
            // Btn_FontSmall
            // 
            this.Btn_FontSmall.BackColor = System.Drawing.Color.White;
            this.Btn_FontSmall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_FontSmall.FlatAppearance.BorderSize = 2;
            this.Btn_FontSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FontSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FontSmall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_FontSmall.Location = new System.Drawing.Point(327, 366);
            this.Btn_FontSmall.Name = "Btn_FontSmall";
            this.Btn_FontSmall.Size = new System.Drawing.Size(153, 51);
            this.Btn_FontSmall.TabIndex = 30;
            this.Btn_FontSmall.Text = "Small";
            this.Btn_FontSmall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_FontSmall.UseVisualStyleBackColor = false;
            this.Btn_FontSmall.Click += new System.EventHandler(this.Btn_FontSmall_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(473, 330);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 24);
            this.label15.TabIndex = 29;
            this.label15.Text = "Font Size";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_SeparateVerse
            // 
            this.Btn_SeparateVerse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.Btn_SeparateVerse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_SeparateVerse.FlatAppearance.BorderSize = 2;
            this.Btn_SeparateVerse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SeparateVerse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SeparateVerse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_SeparateVerse.Location = new System.Drawing.Point(807, 237);
            this.Btn_SeparateVerse.Name = "Btn_SeparateVerse";
            this.Btn_SeparateVerse.Size = new System.Drawing.Size(213, 39);
            this.Btn_SeparateVerse.TabIndex = 28;
            this.Btn_SeparateVerse.Text = "Separate Verse";
            this.Btn_SeparateVerse.UseVisualStyleBackColor = false;
            this.Btn_SeparateVerse.Click += new System.EventHandler(this.Btn_VerseDefault_Click);
            // 
            // Btn_VerseDefault
            // 
            this.Btn_VerseDefault.BackColor = System.Drawing.Color.White;
            this.Btn_VerseDefault.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_VerseDefault.FlatAppearance.BorderSize = 2;
            this.Btn_VerseDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_VerseDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VerseDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_VerseDefault.Location = new System.Drawing.Point(598, 237);
            this.Btn_VerseDefault.Name = "Btn_VerseDefault";
            this.Btn_VerseDefault.Size = new System.Drawing.Size(213, 39);
            this.Btn_VerseDefault.TabIndex = 27;
            this.Btn_VerseDefault.Text = "Default";
            this.Btn_VerseDefault.UseVisualStyleBackColor = false;
            this.Btn_VerseDefault.Click += new System.EventHandler(this.Btn_VerseDefault_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(572, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 24);
            this.label14.TabIndex = 26;
            this.label14.Text = "Verse Break";
            // 
            // Btn_TextAlignRight
            // 
            this.Btn_TextAlignRight.BackColor = System.Drawing.Color.White;
            this.Btn_TextAlignRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_TextAlignRight.FlatAppearance.BorderSize = 2;
            this.Btn_TextAlignRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TextAlignRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TextAlignRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_TextAlignRight.Image = global::USFM_Converter.Properties.Resources.Text_Align_R;
            this.Btn_TextAlignRight.Location = new System.Drawing.Point(598, 53);
            this.Btn_TextAlignRight.Name = "Btn_TextAlignRight";
            this.Btn_TextAlignRight.Size = new System.Drawing.Size(213, 39);
            this.Btn_TextAlignRight.TabIndex = 25;
            this.Btn_TextAlignRight.Text = "   Left Aligned";
            this.Btn_TextAlignRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_TextAlignRight.UseVisualStyleBackColor = false;
            this.Btn_TextAlignRight.Visible = false;
            // 
            // Btn_ChapComb
            // 
            this.Btn_ChapComb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.Btn_ChapComb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_ChapComb.FlatAppearance.BorderSize = 2;
            this.Btn_ChapComb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ChapComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChapComb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_ChapComb.Location = new System.Drawing.Point(807, 144);
            this.Btn_ChapComb.Name = "Btn_ChapComb";
            this.Btn_ChapComb.Size = new System.Drawing.Size(213, 39);
            this.Btn_ChapComb.TabIndex = 24;
            this.Btn_ChapComb.Text = "Chapter Combine";
            this.Btn_ChapComb.UseVisualStyleBackColor = false;
            this.Btn_ChapComb.Click += new System.EventHandler(this.Btn_Chap_Click);
            // 
            // Btn_ChapBreak
            // 
            this.Btn_ChapBreak.BackColor = System.Drawing.Color.White;
            this.Btn_ChapBreak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_ChapBreak.FlatAppearance.BorderSize = 2;
            this.Btn_ChapBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ChapBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChapBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_ChapBreak.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ChapBreak.Image")));
            this.Btn_ChapBreak.Location = new System.Drawing.Point(598, 144);
            this.Btn_ChapBreak.Name = "Btn_ChapBreak";
            this.Btn_ChapBreak.Size = new System.Drawing.Size(213, 39);
            this.Btn_ChapBreak.TabIndex = 23;
            this.Btn_ChapBreak.Text = "   Chapter Break";
            this.Btn_ChapBreak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ChapBreak.UseVisualStyleBackColor = false;
            this.Btn_ChapBreak.Click += new System.EventHandler(this.Btn_Chap_Click);
            // 
            // Btn_TextJustify
            // 
            this.Btn_TextJustify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.Btn_TextJustify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_TextJustify.FlatAppearance.BorderSize = 2;
            this.Btn_TextJustify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TextJustify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TextJustify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_TextJustify.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TextJustify.Image")));
            this.Btn_TextJustify.Location = new System.Drawing.Point(805, 53);
            this.Btn_TextJustify.Name = "Btn_TextJustify";
            this.Btn_TextJustify.Size = new System.Drawing.Size(213, 39);
            this.Btn_TextJustify.TabIndex = 22;
            this.Btn_TextJustify.Text = "   Justified";
            this.Btn_TextJustify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_TextJustify.UseVisualStyleBackColor = false;
            this.Btn_TextJustify.Click += new System.EventHandler(this.Btn_TextAlign_Click);
            // 
            // Btn_TextAlignDefault
            // 
            this.Btn_TextAlignDefault.BackColor = System.Drawing.Color.White;
            this.Btn_TextAlignDefault.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_TextAlignDefault.FlatAppearance.BorderSize = 2;
            this.Btn_TextAlignDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TextAlignDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TextAlignDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_TextAlignDefault.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TextAlignDefault.Image")));
            this.Btn_TextAlignDefault.Location = new System.Drawing.Point(598, 53);
            this.Btn_TextAlignDefault.Name = "Btn_TextAlignDefault";
            this.Btn_TextAlignDefault.Size = new System.Drawing.Size(213, 39);
            this.Btn_TextAlignDefault.TabIndex = 21;
            this.Btn_TextAlignDefault.Text = "   Left Aligned";
            this.Btn_TextAlignDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_TextAlignDefault.UseVisualStyleBackColor = false;
            this.Btn_TextAlignDefault.Click += new System.EventHandler(this.Btn_TextAlign_Click);
            // 
            // Btn_RTL
            // 
            this.Btn_RTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.Btn_RTL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_RTL.FlatAppearance.BorderSize = 2;
            this.Btn_RTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RTL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_RTL.Image = ((System.Drawing.Image)(resources.GetObject("Btn_RTL.Image")));
            this.Btn_RTL.Location = new System.Drawing.Point(310, 235);
            this.Btn_RTL.Name = "Btn_RTL";
            this.Btn_RTL.Size = new System.Drawing.Size(213, 39);
            this.Btn_RTL.TabIndex = 20;
            this.Btn_RTL.Text = "   Right to Left";
            this.Btn_RTL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_RTL.UseVisualStyleBackColor = false;
            this.Btn_RTL.Click += new System.EventHandler(this.Btn_Direction_Click);
            // 
            // Btn_LTR
            // 
            this.Btn_LTR.BackColor = System.Drawing.Color.White;
            this.Btn_LTR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_LTR.FlatAppearance.BorderSize = 2;
            this.Btn_LTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LTR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_LTR.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LTR.Image")));
            this.Btn_LTR.Location = new System.Drawing.Point(103, 235);
            this.Btn_LTR.Name = "Btn_LTR";
            this.Btn_LTR.Size = new System.Drawing.Size(213, 39);
            this.Btn_LTR.TabIndex = 19;
            this.Btn_LTR.Text = "   Left to Right";
            this.Btn_LTR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_LTR.UseVisualStyleBackColor = false;
            this.Btn_LTR.Click += new System.EventHandler(this.Btn_Direction_Click);
            // 
            // Btn_TwoCol
            // 
            this.Btn_TwoCol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.Btn_TwoCol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_TwoCol.FlatAppearance.BorderSize = 2;
            this.Btn_TwoCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TwoCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TwoCol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_TwoCol.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TwoCol.Image")));
            this.Btn_TwoCol.Location = new System.Drawing.Point(310, 144);
            this.Btn_TwoCol.Name = "Btn_TwoCol";
            this.Btn_TwoCol.Size = new System.Drawing.Size(213, 39);
            this.Btn_TwoCol.TabIndex = 18;
            this.Btn_TwoCol.Text = "   Two Columns";
            this.Btn_TwoCol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_TwoCol.UseVisualStyleBackColor = false;
            this.Btn_TwoCol.Click += new System.EventHandler(this.Btn_Col_Click);
            // 
            // Btn_OneCol
            // 
            this.Btn_OneCol.BackColor = System.Drawing.Color.White;
            this.Btn_OneCol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_OneCol.FlatAppearance.BorderSize = 2;
            this.Btn_OneCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OneCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OneCol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_OneCol.Image = ((System.Drawing.Image)(resources.GetObject("Btn_OneCol.Image")));
            this.Btn_OneCol.Location = new System.Drawing.Point(103, 144);
            this.Btn_OneCol.Name = "Btn_OneCol";
            this.Btn_OneCol.Size = new System.Drawing.Size(213, 39);
            this.Btn_OneCol.TabIndex = 17;
            this.Btn_OneCol.Text = "   One Column";
            this.Btn_OneCol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_OneCol.UseVisualStyleBackColor = false;
            this.Btn_OneCol.Click += new System.EventHandler(this.Btn_Col_Click);
            // 
            // Btn_DoubleSpaced
            // 
            this.Btn_DoubleSpaced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.Btn_DoubleSpaced.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_DoubleSpaced.FlatAppearance.BorderSize = 2;
            this.Btn_DoubleSpaced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DoubleSpaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DoubleSpaced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.Btn_DoubleSpaced.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DoubleSpaced.Image")));
            this.Btn_DoubleSpaced.Location = new System.Drawing.Point(310, 53);
            this.Btn_DoubleSpaced.Name = "Btn_DoubleSpaced";
            this.Btn_DoubleSpaced.Size = new System.Drawing.Size(213, 39);
            this.Btn_DoubleSpaced.TabIndex = 16;
            this.Btn_DoubleSpaced.Text = "   Double Space";
            this.Btn_DoubleSpaced.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_DoubleSpaced.UseVisualStyleBackColor = false;
            this.Btn_DoubleSpaced.Click += new System.EventHandler(this.Btn_Spaced_Click);
            // 
            // Btn_SingleSpaced
            // 
            this.Btn_SingleSpaced.BackColor = System.Drawing.Color.White;
            this.Btn_SingleSpaced.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_SingleSpaced.FlatAppearance.BorderSize = 2;
            this.Btn_SingleSpaced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SingleSpaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SingleSpaced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_SingleSpaced.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SingleSpaced.Image")));
            this.Btn_SingleSpaced.Location = new System.Drawing.Point(103, 53);
            this.Btn_SingleSpaced.Name = "Btn_SingleSpaced";
            this.Btn_SingleSpaced.Size = new System.Drawing.Size(213, 39);
            this.Btn_SingleSpaced.TabIndex = 15;
            this.Btn_SingleSpaced.Text = "   Single Space";
            this.Btn_SingleSpaced.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_SingleSpaced.UseVisualStyleBackColor = false;
            this.Btn_SingleSpaced.Click += new System.EventHandler(this.Btn_Spaced_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(572, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "Chapter Break";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(572, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Text Alignment";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Text Direction";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Columns";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Line Spacing";
            // 
            // Loading_Page
            // 
            this.Loading_Page.BackgroundImage = global::USFM_Converter.Properties.Resources.Mask_Group_11;
            this.Loading_Page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Loading_Page.Controls.Add(this.LoadingBar);
            this.Loading_Page.Location = new System.Drawing.Point(0, 0);
            this.Loading_Page.Name = "Loading_Page";
            this.Loading_Page.Size = new System.Drawing.Size(1085, 621);
            this.Loading_Page.TabIndex = 6;
            this.Loading_Page.Visible = false;
            // 
            // LoadingBar
            // 
            this.LoadingBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(211)))));
            this.LoadingBar.Location = new System.Drawing.Point(335, 325);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(377, 16);
            this.LoadingBar.TabIndex = 3;
            // 
            // Conversion_Page
            // 
            this.Conversion_Page.Location = new System.Drawing.Point(0, 0);
            this.Conversion_Page.Name = "Conversion_Page";
            this.Conversion_Page.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Conversion_Page.Panel1
            // 
            this.Conversion_Page.Panel1.Controls.Add(this.ConversionBanner);
            // 
            // Conversion_Page.Panel2
            // 
            this.Conversion_Page.Panel2.Controls.Add(this.ConversionPanel);
            this.Conversion_Page.Size = new System.Drawing.Size(1085, 627);
            this.Conversion_Page.SplitterDistance = 91;
            this.Conversion_Page.TabIndex = 5;
            this.Conversion_Page.Visible = false;
            // 
            // Error_Page
            // 
            this.Error_Page.ColorBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.Error_Page.ColorTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.Error_Page.Controls.Add(this.pictureBox1);
            this.Error_Page.Controls.Add(this.Btn_RestartProj);
            this.Error_Page.Controls.Add(this.label9);
            this.Error_Page.Controls.Add(this.label10);
            this.Error_Page.Location = new System.Drawing.Point(-6, 0);
            this.Error_Page.Name = "Error_Page";
            this.Error_Page.Size = new System.Drawing.Size(1093, 624);
            this.Error_Page.TabIndex = 6;
            this.Error_Page.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(500, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_RestartProj
            // 
            this.Btn_RestartProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(211)))));
            this.Btn_RestartProj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(211)))));
            this.Btn_RestartProj.FlatAppearance.BorderSize = 3;
            this.Btn_RestartProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RestartProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RestartProj.ForeColor = System.Drawing.Color.White;
            this.Btn_RestartProj.Location = new System.Drawing.Point(410, 423);
            this.Btn_RestartProj.Name = "Btn_RestartProj";
            this.Btn_RestartProj.Size = new System.Drawing.Size(302, 53);
            this.Btn_RestartProj.TabIndex = 4;
            this.Btn_RestartProj.Text = "New Project";
            this.Btn_RestartProj.UseVisualStyleBackColor = false;
            this.Btn_RestartProj.Click += new System.EventHandler(this.Btn_NewProj_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label9.Location = new System.Drawing.Point(288, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(538, 56);
            this.label9.TabIndex = 0;
            this.label9.Text = "Project conversion failed. Please try again or contact IT Support for help.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label10.Location = new System.Drawing.Point(486, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 46);
            this.label10.TabIndex = 1;
            this.label10.Text = "Uh-oh...";
            // 
            // Success_Page
            // 
            this.Success_Page.ColorBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.Success_Page.ColorTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.Success_Page.Controls.Add(this.pictureBox3);
            this.Success_Page.Controls.Add(this.button1);
            this.Success_Page.Controls.Add(this.label11);
            this.Success_Page.Controls.Add(this.button2);
            this.Success_Page.Controls.Add(this.label13);
            this.Success_Page.Location = new System.Drawing.Point(0, 0);
            this.Success_Page.Name = "Success_Page";
            this.Success_Page.Size = new System.Drawing.Size(1087, 624);
            this.Success_Page.TabIndex = 6;
            this.Success_Page.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(500, 174);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 108);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(211)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(211)))));
            this.button1.Location = new System.Drawing.Point(238, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "New Project";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Btn_NewProj_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label11.Location = new System.Drawing.Point(288, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(538, 45);
            this.label11.TabIndex = 0;
            this.label11.Text = "Your project was successfully converted.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(211)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(569, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Open File Location";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Btn_OpenFileLocation_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label13.Location = new System.Drawing.Point(461, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 46);
            this.label13.TabIndex = 1;
            this.label13.Text = "Success!";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(440, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "USFM File Converter";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 46);
            this.label5.TabIndex = 1;
            this.label5.Text = "Matos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(510, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 626);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "USFM Converter";
            this.ConversionPanel.ResumeLayout(false);
            this.ConversionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).EndInit();
            this.ConversionBanner.ResumeLayout(false);
            this.HomeCapture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Format_Page.Panel1.ResumeLayout(false);
            this.Format_Page.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Format_Page)).EndInit();
            this.Format_Page.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.Loading_Page.ResumeLayout(false);
            this.Conversion_Page.Panel1.ResumeLayout(false);
            this.Conversion_Page.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Conversion_Page)).EndInit();
            this.Conversion_Page.ResumeLayout(false);
            this.Error_Page.ResumeLayout(false);
            this.Error_Page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Success_Page.ResumeLayout(false);
            this.Success_Page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        

        private System.Windows.Forms.PictureBox HomeImg;
        private System.Windows.Forms.Button Btn_BrowseFiles;
        private System.Windows.Forms.Label HomeInstruct;
        private System.Windows.Forms.Panel HomeCapture;
        private System.Windows.Forms.Panel ConversionPanel;
        private System.Windows.Forms.DataGridView fileDataGrid;
        private System.Windows.Forms.TextBox FileNameInput;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_AddFiles;
        private Panel ConversionBanner;
        private Button Btn_Format;
        private Label ProjectLabel;
        private Panel panel1;
        private Label label1;
        private Label ProjNameLabel;
        private SplitContainer Format_Page;
        private Panel panel2;
        private Button Btn_Convert;
        private Label label2;
        private Panel panel3;
        private Label label12;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label3;
        private SplitContainer Conversion_Page;
        private Button Btn_ChapComb;
        private Button Btn_ChapBreak;
        private Button Btn_TextJustify;
        private Button Btn_TextAlignDefault;
        private Button Btn_RTL;
        private Button Btn_LTR;
        private Button Btn_TwoCol;
        private Button Btn_OneCol;
        private ColorGradient Error_Page;
        private Button Btn_RestartProj;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private Button Btn_FormatBack;
        private ColorGradient Success_Page;
        private PictureBox pictureBox3;
        private Button button1;
        private Label label11;
        private Button button2;
        private Label label13;
        private Panel Loading_Page;
        private PictureBox pictureBox2;
        private ProgressBar LoadingBar;
        private Label label6;
        private Label label5;
        private Button Btn_TextAlignRight;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;

        
        private Button Btn_DoubleSpaced;
        private Button Btn_SingleSpaced;
        private Button Btn_FontLarge;
        private Button Btn_FontMed;
        private Button Btn_FontSmall;
        private Label label15;
        private Button Btn_SeparateVerse;
        private Button Btn_VerseDefault;
        private Label label14;
    }
}