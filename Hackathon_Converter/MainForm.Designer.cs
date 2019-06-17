using System.Drawing.Text;
using System.Runtime.InteropServices;

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
            this.USFMApp = new System.Windows.Forms.SplitContainer();
            this.Btn_Convert = new System.Windows.Forms.Button();
            this.LogoTitle = new System.Windows.Forms.Label();
            this.LogoImg = new System.Windows.Forms.PictureBox();
            this.ConversionPage = new System.Windows.Forms.Panel();
            this.Confirmation_Page = new Hackathon_Converter.ColorGradient();
            this.LabelCheck = new System.Windows.Forms.Label();
            this.Btn_NewProj = new System.Windows.Forms.Button();
            this.LabelDesc = new System.Windows.Forms.Label();
            this.Btn_OpenFileLocation = new System.Windows.Forms.Button();
            this.LabelSuccess = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_AddFiles = new System.Windows.Forms.Button();
            this.HTMLtag = new System.Windows.Forms.Label();
            this.FileNameInput = new System.Windows.Forms.TextBox();
            this.fileDataGrid = new System.Windows.Forms.DataGridView();
            this.HomeCapture = new System.Windows.Forms.Panel();
            this.Btn_BrowseFiles = new System.Windows.Forms.Button();
            this.HomeImg = new System.Windows.Forms.PictureBox();
            this.HomeInstruct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.USFMApp)).BeginInit();
            this.USFMApp.Panel1.SuspendLayout();
            this.USFMApp.Panel2.SuspendLayout();
            this.USFMApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).BeginInit();
            this.ConversionPage.SuspendLayout();
            this.Confirmation_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).BeginInit();
            this.HomeCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // USFMApp
            // 
            this.USFMApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USFMApp.Location = new System.Drawing.Point(0, 0);
            this.USFMApp.Margin = new System.Windows.Forms.Padding(2);
            this.USFMApp.MinimumSize = new System.Drawing.Size(500, 604);
            this.USFMApp.Name = "USFMApp";
            this.USFMApp.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // USFMApp.Panel1
            // 
            this.USFMApp.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.USFMApp.Panel1.Controls.Add(this.Btn_Convert);
            this.USFMApp.Panel1.Controls.Add(this.LogoTitle);
            this.USFMApp.Panel1.Controls.Add(this.LogoImg);
            // 
            // USFMApp.Panel2
            // 
            this.USFMApp.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.USFMApp.Panel2.Controls.Add(this.ConversionPage);
            this.USFMApp.Panel2.Controls.Add(this.HomeCapture);
            this.USFMApp.Size = new System.Drawing.Size(1077, 615);
            this.USFMApp.SplitterDistance = 71;
            this.USFMApp.SplitterWidth = 2;
            this.USFMApp.TabIndex = 0;
            // 
            // Btn_Convert
            // 
            this.Btn_Convert.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Convert.Enabled = false;
            this.Btn_Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Convert.ForeColor = System.Drawing.Color.White;
            this.Btn_Convert.Location = new System.Drawing.Point(774, 20);
            this.Btn_Convert.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Convert.Name = "Btn_Convert";
            this.Btn_Convert.Size = new System.Drawing.Size(207, 40);
            this.Btn_Convert.TabIndex = 2;
            this.Btn_Convert.Text = "Convert";
            this.Btn_Convert.UseVisualStyleBackColor = false;
            this.Btn_Convert.Click += new System.EventHandler(this.OnConvertButtonClick);
            // 
            // LogoTitle
            // 
            this.LogoTitle.AutoSize = true;
            this.LogoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoTitle.Location = new System.Drawing.Point(154, 20);
            this.LogoTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogoTitle.Name = "LogoTitle";
            this.LogoTitle.Size = new System.Drawing.Size(93, 31);
            this.LogoTitle.TabIndex = 1;
            this.LogoTitle.Text = "Matos";
            // 
            // LogoImg
            // 
            this.LogoImg.Image = global::Hackathon_Converter.Properties.Resources.Hackathon_Logo_2x;
            this.LogoImg.Location = new System.Drawing.Point(106, 14);
            this.LogoImg.Margin = new System.Windows.Forms.Padding(2);
            this.LogoImg.Name = "LogoImg";
            this.LogoImg.Size = new System.Drawing.Size(44, 46);
            this.LogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImg.TabIndex = 0;
            this.LogoImg.TabStop = false;
            // 
            // ConversionPage
            // 
            this.ConversionPage.BackColor = System.Drawing.SystemColors.Window;
            this.ConversionPage.Controls.Add(this.Confirmation_Page);
            this.ConversionPage.Controls.Add(this.btn_Remove);
            this.ConversionPage.Controls.Add(this.btn_AddFiles);
            this.ConversionPage.Controls.Add(this.HTMLtag);
            this.ConversionPage.Controls.Add(this.FileNameInput);
            this.ConversionPage.Controls.Add(this.fileDataGrid);
            this.ConversionPage.Location = new System.Drawing.Point(0, 2);
            this.ConversionPage.Margin = new System.Windows.Forms.Padding(2);
            this.ConversionPage.Name = "ConversionPage";
            this.ConversionPage.Size = new System.Drawing.Size(1079, 548);
            this.ConversionPage.TabIndex = 4;
            this.ConversionPage.Visible = false;
            // 
            // Confirmation_Page
            // 
            this.Confirmation_Page.ColorBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(174)))), ((int)(((byte)(234)))));
            this.Confirmation_Page.ColorTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(245)))), ((int)(((byte)(152)))));
            this.Confirmation_Page.Controls.Add(this.LabelCheck);
            this.Confirmation_Page.Controls.Add(this.Btn_NewProj);
            this.Confirmation_Page.Controls.Add(this.LabelDesc);
            this.Confirmation_Page.Controls.Add(this.Btn_OpenFileLocation);
            this.Confirmation_Page.Controls.Add(this.LabelSuccess);
            this.Confirmation_Page.Location = new System.Drawing.Point(0, 1);
            this.Confirmation_Page.Name = "Confirmation_Page";
            this.Confirmation_Page.Size = new System.Drawing.Size(1091, 561);
            this.Confirmation_Page.TabIndex = 5;
            this.Confirmation_Page.Visible = false;
            // 
            // LabelCheck
            // 
            this.LabelCheck.AutoSize = true;
            this.LabelCheck.BackColor = System.Drawing.Color.Transparent;
            this.LabelCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCheck.ForeColor = System.Drawing.Color.White;
            this.LabelCheck.Location = new System.Drawing.Point(462, 63);
            this.LabelCheck.Name = "LabelCheck";
            this.LabelCheck.Size = new System.Drawing.Size(157, 153);
            this.LabelCheck.TabIndex = 2;
            this.LabelCheck.Text = "✔";
            // 
            // Btn_NewProj
            // 
            this.Btn_NewProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            this.Btn_NewProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NewProj.ForeColor = System.Drawing.Color.White;
            this.Btn_NewProj.Location = new System.Drawing.Point(390, 432);
            this.Btn_NewProj.Name = "Btn_NewProj";
            this.Btn_NewProj.Size = new System.Drawing.Size(302, 53);
            this.Btn_NewProj.TabIndex = 4;
            this.Btn_NewProj.Text = "New Project";
            this.Btn_NewProj.UseVisualStyleBackColor = false;
            this.Btn_NewProj.Click += new System.EventHandler(this.Btn_NewProj_Click);
            // 
            // LabelDesc
            // 
            this.LabelDesc.BackColor = System.Drawing.Color.Transparent;
            this.LabelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDesc.ForeColor = System.Drawing.Color.White;
            this.LabelDesc.Location = new System.Drawing.Point(346, 277);
            this.LabelDesc.Name = "LabelDesc";
            this.LabelDesc.Size = new System.Drawing.Size(413, 85);
            this.LabelDesc.TabIndex = 0;
            this.LabelDesc.Text = "Your project was successfully converted to HTML.";
            this.LabelDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_OpenFileLocation
            // 
            this.Btn_OpenFileLocation.BackColor = System.Drawing.Color.White;
            this.Btn_OpenFileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OpenFileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(174)))), ((int)(((byte)(234)))));
            this.Btn_OpenFileLocation.Location = new System.Drawing.Point(390, 363);
            this.Btn_OpenFileLocation.Name = "Btn_OpenFileLocation";
            this.Btn_OpenFileLocation.Size = new System.Drawing.Size(302, 53);
            this.Btn_OpenFileLocation.TabIndex = 3;
            this.Btn_OpenFileLocation.Text = "Open File Location";
            this.Btn_OpenFileLocation.UseVisualStyleBackColor = false;
            this.Btn_OpenFileLocation.Click += new System.EventHandler(this.Btn_OpenFileLocation_Click);
            // 
            // LabelSuccess
            // 
            this.LabelSuccess.AutoSize = true;
            this.LabelSuccess.BackColor = System.Drawing.Color.Transparent;
            this.LabelSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSuccess.ForeColor = System.Drawing.Color.White;
            this.LabelSuccess.Location = new System.Drawing.Point(464, 216);
            this.LabelSuccess.Name = "LabelSuccess";
            this.LabelSuccess.Size = new System.Drawing.Size(155, 39);
            this.LabelSuccess.TabIndex = 1;
            this.LabelSuccess.Text = "Success!";
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.White;
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(464, 480);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(139, 34);
            this.btn_Remove.TabIndex = 4;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.onRemoveFileButtonClick);
            // 
            // btn_AddFiles
            // 
            this.btn_AddFiles.BackColor = System.Drawing.Color.White;
            this.btn_AddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(174)))), ((int)(((byte)(234)))));
            this.btn_AddFiles.Location = new System.Drawing.Point(436, 412);
            this.btn_AddFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddFiles.Name = "btn_AddFiles";
            this.btn_AddFiles.Size = new System.Drawing.Size(204, 41);
            this.btn_AddFiles.TabIndex = 3;
            this.btn_AddFiles.Text = "+ Add UFSM Files";
            this.btn_AddFiles.UseVisualStyleBackColor = false;
            this.btn_AddFiles.Click += new System.EventHandler(this.onAddOnlyFileClick);
            // 
            // HTMLtag
            // 
            this.HTMLtag.BackColor = System.Drawing.Color.White;
            this.HTMLtag.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTMLtag.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HTMLtag.Location = new System.Drawing.Point(812, 43);
            this.HTMLtag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HTMLtag.Name = "HTMLtag";
            this.HTMLtag.Size = new System.Drawing.Size(112, 35);
            this.HTMLtag.TabIndex = 2;
            this.HTMLtag.Text = "HTML";
            // 
            // FileNameInput
            // 
            this.FileNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameInput.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FileNameInput.Location = new System.Drawing.Point(189, 43);
            this.FileNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.FileNameInput.Name = "FileNameInput";
            this.FileNameInput.Size = new System.Drawing.Size(619, 38);
            this.FileNameInput.TabIndex = 1;
            this.FileNameInput.Text = "    Name your Project...";
            this.FileNameInput.WordWrap = false;
            // 
            // fileDataGrid
            // 
            this.fileDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.fileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.fileDataGrid.Location = new System.Drawing.Point(145, 85);
            this.fileDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.fileDataGrid.Name = "fileDataGrid";
            this.fileDataGrid.RowTemplate.Height = 33;
            this.fileDataGrid.Size = new System.Drawing.Size(779, 314);
            this.fileDataGrid.TabIndex = 0;
            // 
            // HomeCapture
            // 
            this.HomeCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeCapture.Controls.Add(this.Btn_BrowseFiles);
            this.HomeCapture.Controls.Add(this.HomeImg);
            this.HomeCapture.Controls.Add(this.HomeInstruct);
            this.HomeCapture.Location = new System.Drawing.Point(231, 19);
            this.HomeCapture.Margin = new System.Windows.Forms.Padding(2);
            this.HomeCapture.Name = "HomeCapture";
            this.HomeCapture.Size = new System.Drawing.Size(623, 473);
            this.HomeCapture.TabIndex = 3;
            // 
            // Btn_BrowseFiles
            // 
            this.Btn_BrowseFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(174)))), ((int)(((byte)(234)))));
            this.Btn_BrowseFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BrowseFiles.ForeColor = System.Drawing.Color.White;
            this.Btn_BrowseFiles.Location = new System.Drawing.Point(156, 404);
            this.Btn_BrowseFiles.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_BrowseFiles.Name = "Btn_BrowseFiles";
            this.Btn_BrowseFiles.Size = new System.Drawing.Size(312, 44);
            this.Btn_BrowseFiles.TabIndex = 2;
            this.Btn_BrowseFiles.Text = "Browse Files";
            this.Btn_BrowseFiles.UseVisualStyleBackColor = false;
            this.Btn_BrowseFiles.Click += new System.EventHandler(this.OnAddFilesButtonClick);
            // 
            // HomeImg
            // 
            this.HomeImg.Image = global::Hackathon_Converter.Properties.Resources.undraw_upload_87y9_2x;
            this.HomeImg.Location = new System.Drawing.Point(134, 8);
            this.HomeImg.Margin = new System.Windows.Forms.Padding(2);
            this.HomeImg.Name = "HomeImg";
            this.HomeImg.Size = new System.Drawing.Size(366, 253);
            this.HomeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeImg.TabIndex = 0;
            this.HomeImg.TabStop = false;
            // 
            // HomeInstruct
            // 
            this.HomeInstruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeInstruct.Location = new System.Drawing.Point(24, 269);
            this.HomeInstruct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HomeInstruct.Name = "HomeInstruct";
            this.HomeInstruct.Size = new System.Drawing.Size(573, 93);
            this.HomeInstruct.TabIndex = 1;
            this.HomeInstruct.Text = "Drag and drop some USFM files or folders to get started.";
            this.HomeInstruct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 615);
            this.Controls.Add(this.USFMApp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Hackathon Converter";
            this.USFMApp.Panel1.ResumeLayout(false);
            this.USFMApp.Panel1.PerformLayout();
            this.USFMApp.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.USFMApp)).EndInit();
            this.USFMApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).EndInit();
            this.ConversionPage.ResumeLayout(false);
            this.ConversionPage.PerformLayout();
            this.Confirmation_Page.ResumeLayout(false);
            this.Confirmation_Page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).EndInit();
            this.HomeCapture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private bool isTextJustified = false;
        private bool isSingleSpaced=true;
        private bool hasOneColumn=true;
        private bool isL2RDirection=true;
        private bool willSeparateChap = false;
        private System.Windows.Forms.SplitContainer USFMApp;
        private System.Windows.Forms.PictureBox LogoImg;
        private System.Windows.Forms.Label LogoTitle;
        private System.Windows.Forms.Button Btn_Convert;
        private System.Windows.Forms.PictureBox HomeImg;
        private System.Windows.Forms.Button Btn_BrowseFiles;
        private System.Windows.Forms.Label HomeInstruct;
        private System.Windows.Forms.Panel HomeCapture;
        private System.Windows.Forms.Panel ConversionPage;
        private System.Windows.Forms.DataGridView fileDataGrid;
        private System.Windows.Forms.Label HTMLtag;
        private System.Windows.Forms.TextBox FileNameInput;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_AddFiles;
        private ColorGradient Confirmation_Page;
        private System.Windows.Forms.Label LabelCheck;
        private System.Windows.Forms.Button Btn_NewProj;
        private System.Windows.Forms.Label LabelDesc;
        private System.Windows.Forms.Button Btn_OpenFileLocation;
        private System.Windows.Forms.Label LabelSuccess;
    }
}