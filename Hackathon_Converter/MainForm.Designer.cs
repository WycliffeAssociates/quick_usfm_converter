using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hackathon_Converter
{
    partial class MainForm
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
        private void InitCustomLabelFont()
        {

            

            //Create your private font collection object.
            PrivateFontCollection customFonts = new PrivateFontCollection();

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
            this.label1 = new System.Windows.Forms.Label();
            this.ProjNameLabel = new System.Windows.Forms.Label();
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
            this.Error_Page = new Hackathon_Converter.ColorGradient();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_RestartProj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Success_Page = new Hackathon_Converter.ColorGradient();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_NewProj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_OpenFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Conversion_Page = new System.Windows.Forms.SplitContainer();
            this.ConversionPanel.SuspendLayout();
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
            this.Error_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Success_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conversion_Page)).BeginInit();
            this.Conversion_Page.Panel1.SuspendLayout();
            this.Conversion_Page.Panel2.SuspendLayout();
            this.Conversion_Page.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConversionPanel
            // 
            this.ConversionPanel.BackColor = System.Drawing.SystemColors.Window;
            this.ConversionPanel.Controls.Add(this.label1);
            this.ConversionPanel.Controls.Add(this.ProjNameLabel);
            this.ConversionPanel.Controls.Add(this.btn_Remove);
            this.ConversionPanel.Controls.Add(this.btn_AddFiles);
            this.ConversionPanel.Controls.Add(this.FileNameInput);
            this.ConversionPanel.Controls.Add(this.fileDataGrid);
            this.ConversionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConversionPanel.Location = new System.Drawing.Point(0, 0);
            this.ConversionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ConversionPanel.Name = "ConversionPanel";
            this.ConversionPanel.Size = new System.Drawing.Size(1085, 528);
            this.ConversionPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Files";
            // 
            // ProjNameLabel
            // 
            this.ProjNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjNameLabel.Location = new System.Drawing.Point(72, 55);
            this.ProjNameLabel.Name = "ProjNameLabel";
            this.ProjNameLabel.Size = new System.Drawing.Size(161, 24);
            this.ProjNameLabel.TabIndex = 8;
            this.ProjNameLabel.Text = " Project Name";
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
            this.btn_Remove.Visible = false;
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
            this.FileNameInput.ForeColor = System.Drawing.SystemColors.ControlDark;
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
            this.ConversionBanner.Size = new System.Drawing.Size(1085, 95);
            this.ConversionBanner.TabIndex = 6;
            // 
            // Btn_Format
            // 
            this.Btn_Format.BackColor = System.Drawing.Color.White;
            this.Btn_Format.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.HomeCapture.Controls.Add(this.Btn_BrowseFiles);
            this.HomeCapture.Controls.Add(this.HomeImg);
            this.HomeCapture.Controls.Add(this.HomeInstruct);
            this.HomeCapture.Location = new System.Drawing.Point(104, 11);
            this.HomeCapture.Margin = new System.Windows.Forms.Padding(2);
            this.HomeCapture.Name = "HomeCapture";
            this.HomeCapture.Size = new System.Drawing.Size(912, 577);
            this.HomeCapture.TabIndex = 3;
            // 
            // Btn_BrowseFiles
            // 
            this.Btn_BrowseFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(211)))));
            this.Btn_BrowseFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.HomeImg.Image = global::Hackathon_Converter.Properties.Resources.undraw_upload_87y9_2x;
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
            this.HomeInstruct.Text = "Drag and drop some USFM files or folders to get started.";
            this.HomeInstruct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Format_Page);
            this.panel1.Controls.Add(this.Error_Page);
            this.panel1.Controls.Add(this.Success_Page);
            this.panel1.Controls.Add(this.Conversion_Page);
            this.panel1.Controls.Add(this.HomeCapture);
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
            this.Format_Page.SplitterDistance = 95;
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
            this.panel2.Size = new System.Drawing.Size(1085, 95);
            this.panel2.TabIndex = 6;
            // 
            // Btn_FormatBack
            // 
            this.Btn_FormatBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(137)))));
            this.Btn_FormatBack.FlatAppearance.BorderSize = 0;
            this.Btn_FormatBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FormatBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FormatBack.ForeColor = System.Drawing.Color.White;
            this.Btn_FormatBack.Image = global::Hackathon_Converter.Properties.Resources.BackArrow;
            this.Btn_FormatBack.Location = new System.Drawing.Point(660, 29);
            this.Btn_FormatBack.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_FormatBack.Name = "Btn_FormatBack";
            this.Btn_FormatBack.Size = new System.Drawing.Size(123, 41);
            this.Btn_FormatBack.TabIndex = 2;
            this.Btn_FormatBack.Text = "Back";
            this.Btn_FormatBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_FormatBack.UseVisualStyleBackColor = false;
            // 
            // Btn_Convert
            // 
            this.Btn_Convert.BackColor = System.Drawing.Color.White;
            this.Btn_Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel3.Size = new System.Drawing.Size(1085, 525);
            this.panel3.TabIndex = 4;
            // 
            // Btn_ChapComb
            // 
            this.Btn_ChapComb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_ChapComb.FlatAppearance.BorderSize = 2;
            this.Btn_ChapComb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ChapComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChapComb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_ChapComb.Location = new System.Drawing.Point(520, 418);
            this.Btn_ChapComb.Name = "Btn_ChapComb";
            this.Btn_ChapComb.Size = new System.Drawing.Size(213, 39);
            this.Btn_ChapComb.TabIndex = 24;
            this.Btn_ChapComb.Text = "Chapter Combine";
            this.Btn_ChapComb.UseVisualStyleBackColor = true;
            // 
            // Btn_ChapBreak
            // 
            this.Btn_ChapBreak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_ChapBreak.FlatAppearance.BorderSize = 2;
            this.Btn_ChapBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ChapBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChapBreak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_ChapBreak.Image = global::Hackathon_Converter.Properties.Resources.Chapter_PageBreak;
            this.Btn_ChapBreak.Location = new System.Drawing.Point(287, 418);
            this.Btn_ChapBreak.Name = "Btn_ChapBreak";
            this.Btn_ChapBreak.Size = new System.Drawing.Size(213, 39);
            this.Btn_ChapBreak.TabIndex = 23;
            this.Btn_ChapBreak.Text = "   Chapter Break";
            this.Btn_ChapBreak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ChapBreak.UseVisualStyleBackColor = true;
            // 
            // Btn_TextJustify
            // 
            this.Btn_TextJustify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_TextJustify.FlatAppearance.BorderSize = 2;
            this.Btn_TextJustify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TextJustify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TextJustify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_TextJustify.Image = global::Hackathon_Converter.Properties.Resources.Test_Justify;
            this.Btn_TextJustify.Location = new System.Drawing.Point(520, 324);
            this.Btn_TextJustify.Name = "Btn_TextJustify";
            this.Btn_TextJustify.Size = new System.Drawing.Size(213, 39);
            this.Btn_TextJustify.TabIndex = 22;
            this.Btn_TextJustify.Text = "   Justified";
            this.Btn_TextJustify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_TextJustify.UseVisualStyleBackColor = true;
            // 
            // Btn_TextAlignDefault
            // 
            this.Btn_TextAlignDefault.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_TextAlignDefault.FlatAppearance.BorderSize = 2;
            this.Btn_TextAlignDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TextAlignDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TextAlignDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_TextAlignDefault.Image = global::Hackathon_Converter.Properties.Resources.Text_Align;
            this.Btn_TextAlignDefault.Location = new System.Drawing.Point(287, 324);
            this.Btn_TextAlignDefault.Name = "Btn_TextAlignDefault";
            this.Btn_TextAlignDefault.Size = new System.Drawing.Size(213, 39);
            this.Btn_TextAlignDefault.TabIndex = 21;
            this.Btn_TextAlignDefault.Text = "   Left Aligned";
            this.Btn_TextAlignDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_TextAlignDefault.UseVisualStyleBackColor = true;
            // 
            // Btn_RTL
            // 
            this.Btn_RTL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_RTL.FlatAppearance.BorderSize = 2;
            this.Btn_RTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RTL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_RTL.Image = global::Hackathon_Converter.Properties.Resources.Right_Left;
            this.Btn_RTL.Location = new System.Drawing.Point(520, 232);
            this.Btn_RTL.Name = "Btn_RTL";
            this.Btn_RTL.Size = new System.Drawing.Size(213, 39);
            this.Btn_RTL.TabIndex = 20;
            this.Btn_RTL.Text = "   Right to Left";
            this.Btn_RTL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_RTL.UseVisualStyleBackColor = true;
            // 
            // Btn_LTR
            // 
            this.Btn_LTR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_LTR.FlatAppearance.BorderSize = 2;
            this.Btn_LTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LTR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_LTR.Image = global::Hackathon_Converter.Properties.Resources.Left_Right;
            this.Btn_LTR.Location = new System.Drawing.Point(287, 232);
            this.Btn_LTR.Name = "Btn_LTR";
            this.Btn_LTR.Size = new System.Drawing.Size(213, 39);
            this.Btn_LTR.TabIndex = 19;
            this.Btn_LTR.Text = "   Left to Right";
            this.Btn_LTR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_LTR.UseVisualStyleBackColor = true;
            // 
            // Btn_TwoCol
            // 
            this.Btn_TwoCol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_TwoCol.FlatAppearance.BorderSize = 2;
            this.Btn_TwoCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TwoCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TwoCol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_TwoCol.Image = global::Hackathon_Converter.Properties.Resources.TwoColumns;
            this.Btn_TwoCol.Location = new System.Drawing.Point(520, 144);
            this.Btn_TwoCol.Name = "Btn_TwoCol";
            this.Btn_TwoCol.Size = new System.Drawing.Size(213, 39);
            this.Btn_TwoCol.TabIndex = 18;
            this.Btn_TwoCol.Text = "   Two Columns";
            this.Btn_TwoCol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_TwoCol.UseVisualStyleBackColor = true;
            // 
            // Btn_OneCol
            // 
            this.Btn_OneCol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_OneCol.FlatAppearance.BorderSize = 2;
            this.Btn_OneCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OneCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OneCol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_OneCol.Image = global::Hackathon_Converter.Properties.Resources.OneColumn;
            this.Btn_OneCol.Location = new System.Drawing.Point(287, 144);
            this.Btn_OneCol.Name = "Btn_OneCol";
            this.Btn_OneCol.Size = new System.Drawing.Size(213, 39);
            this.Btn_OneCol.TabIndex = 17;
            this.Btn_OneCol.Text = "   One Column";
            this.Btn_OneCol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_OneCol.UseVisualStyleBackColor = true;
            // 
            // Btn_DoubleSpaced
            // 
            this.Btn_DoubleSpaced.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_DoubleSpaced.FlatAppearance.BorderSize = 2;
            this.Btn_DoubleSpaced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DoubleSpaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DoubleSpaced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_DoubleSpaced.Image = global::Hackathon_Converter.Properties.Resources.Double_Spaced;
            this.Btn_DoubleSpaced.Location = new System.Drawing.Point(520, 55);
            this.Btn_DoubleSpaced.Name = "Btn_DoubleSpaced";
            this.Btn_DoubleSpaced.Size = new System.Drawing.Size(213, 39);
            this.Btn_DoubleSpaced.TabIndex = 16;
            this.Btn_DoubleSpaced.Text = "   Double Space";
            this.Btn_DoubleSpaced.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_DoubleSpaced.UseVisualStyleBackColor = true;
            // 
            // Btn_SingleSpaced
            // 
            this.Btn_SingleSpaced.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_SingleSpaced.FlatAppearance.BorderSize = 2;
            this.Btn_SingleSpaced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SingleSpaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SingleSpaced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(214)))));
            this.Btn_SingleSpaced.Image = global::Hackathon_Converter.Properties.Resources.Single_Spaced;
            this.Btn_SingleSpaced.Location = new System.Drawing.Point(287, 55);
            this.Btn_SingleSpaced.Name = "Btn_SingleSpaced";
            this.Btn_SingleSpaced.Size = new System.Drawing.Size(213, 39);
            this.Btn_SingleSpaced.TabIndex = 15;
            this.Btn_SingleSpaced.Text = "   Single Space";
            this.Btn_SingleSpaced.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_SingleSpaced.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(273, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "Chapter Break";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Paragraph Style";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(273, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Reading Direction";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Columns";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Line Spacing";
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
            this.pictureBox1.Image = global::Hackathon_Converter.Properties.Resources.Error_Img;
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
            this.Success_Page.Controls.Add(this.pictureBox2);
            this.Success_Page.Controls.Add(this.Btn_NewProj);
            this.Success_Page.Controls.Add(this.label5);
            this.Success_Page.Controls.Add(this.Btn_OpenFile);
            this.Success_Page.Controls.Add(this.label6);
            this.Success_Page.Location = new System.Drawing.Point(6, 0);
            this.Success_Page.Name = "Success_Page";
            this.Success_Page.Size = new System.Drawing.Size(1079, 616);
            this.Success_Page.TabIndex = 5;
            this.Success_Page.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.pictureBox2.Image = global::Hackathon_Converter.Properties.Resources.Success_Check;
            this.pictureBox2.Location = new System.Drawing.Point(500, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_NewProj
            // 
            this.Btn_NewProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(246)))));
            this.Btn_NewProj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(211)))));
            this.Btn_NewProj.FlatAppearance.BorderSize = 3;
            this.Btn_NewProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NewProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NewProj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(211)))));
            this.Btn_NewProj.Location = new System.Drawing.Point(238, 396);
            this.Btn_NewProj.Name = "Btn_NewProj";
            this.Btn_NewProj.Size = new System.Drawing.Size(302, 53);
            this.Btn_NewProj.TabIndex = 4;
            this.Btn_NewProj.Text = "New Project";
            this.Btn_NewProj.UseVisualStyleBackColor = false;
            this.Btn_NewProj.Click += new System.EventHandler(this.Btn_NewProj_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(288, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(538, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Your project was successfully converted.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_OpenFile
            // 
            this.Btn_OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(80)))), ((int)(((byte)(211)))));
            this.Btn_OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OpenFile.ForeColor = System.Drawing.Color.White;
            this.Btn_OpenFile.Location = new System.Drawing.Point(569, 396);
            this.Btn_OpenFile.Name = "Btn_OpenFile";
            this.Btn_OpenFile.Size = new System.Drawing.Size(302, 53);
            this.Btn_OpenFile.TabIndex = 3;
            this.Btn_OpenFile.Text = "Open File Location";
            this.Btn_OpenFile.UseVisualStyleBackColor = false;
            this.Btn_OpenFile.Click += new System.EventHandler(this.Btn_OpenFileLocation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(461, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 46);
            this.label6.TabIndex = 1;
            this.label6.Text = "Success!";
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
            this.Conversion_Page.SplitterDistance = 95;
            this.Conversion_Page.TabIndex = 5;
            this.Conversion_Page.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 615);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = " Matos";
            this.ConversionPanel.ResumeLayout(false);
            this.ConversionPanel.PerformLayout();
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
            this.Error_Page.ResumeLayout(false);
            this.Error_Page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Success_Page.ResumeLayout(false);
            this.Success_Page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Conversion_Page.Panel1.ResumeLayout(false);
            this.Conversion_Page.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Conversion_Page)).EndInit();
            this.Conversion_Page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private bool isTextJustified = false;
        private bool isSingleSpaced=true;
        private bool hasOneColumn=true;
        private bool isL2RDirection=true;
        private bool willSeparateChap = false;
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
        private ColorGradient Success_Page;
        private PictureBox pictureBox2;
        private Button Btn_NewProj;
        private Label label5;
        private Button Btn_OpenFile;
        private Label label6;
        private Button Btn_DoubleSpaced;
        private Button Btn_SingleSpaced;
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
    }
}