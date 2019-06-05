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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnConvert = new System.Windows.Forms.Button();
            this.btn_AddFiles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AddOnlyFile = new System.Windows.Forms.Button();
            this.btn_ClearList = new System.Windows.Forms.Button();
            this.fileDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConvert
            // 
            this.BtnConvert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConvert.Location = new System.Drawing.Point(0, 225);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(1603, 75);
            this.BtnConvert.TabIndex = 0;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.OnConvertButtonClick);
            // 
            // btn_AddFiles
            // 
            this.btn_AddFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddFiles.Location = new System.Drawing.Point(0, 0);
            this.btn_AddFiles.Name = "btn_AddFiles";
            this.btn_AddFiles.Size = new System.Drawing.Size(1603, 75);
            this.btn_AddFiles.TabIndex = 1;
            this.btn_AddFiles.Text = "Add Directory";
            this.btn_AddFiles.UseVisualStyleBackColor = true;
            this.btn_AddFiles.Click += new System.EventHandler(this.OnAddFilesButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_AddOnlyFile);
            this.panel1.Controls.Add(this.btn_ClearList);
            this.panel1.Controls.Add(this.btn_AddFiles);
            this.panel1.Controls.Add(this.BtnConvert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 559);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1603, 300);
            this.panel1.TabIndex = 3;
            // 
            // btn_AddOnlyFile
            // 
            this.btn_AddOnlyFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddOnlyFile.Location = new System.Drawing.Point(0, 150);
            this.btn_AddOnlyFile.Name = "btn_AddOnlyFile";
            this.btn_AddOnlyFile.Size = new System.Drawing.Size(1603, 75);
            this.btn_AddOnlyFile.TabIndex = 3;
            this.btn_AddOnlyFile.Text = "Add File";
            this.btn_AddOnlyFile.UseVisualStyleBackColor = true;
            this.btn_AddOnlyFile.Click += new System.EventHandler(this.onAddOnlyFileClick);
            // 
            // btn_ClearList
            // 
            this.btn_ClearList.AutoSize = true;
            this.btn_ClearList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ClearList.Location = new System.Drawing.Point(0, 75);
            this.btn_ClearList.Name = "btn_ClearList";
            this.btn_ClearList.Size = new System.Drawing.Size(1603, 75);
            this.btn_ClearList.TabIndex = 2;
            this.btn_ClearList.Text = "Clear List";
            this.btn_ClearList.UseVisualStyleBackColor = true;
            this.btn_ClearList.Click += new System.EventHandler(this.onClearListButtonClick);
            // 
            // fileDataGrid
            // 
            this.fileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileDataGrid.Location = new System.Drawing.Point(0, 0);
            this.fileDataGrid.Name = "fileDataGrid";
            this.fileDataGrid.RowTemplate.Height = 33;
            this.fileDataGrid.Size = new System.Drawing.Size(1603, 559);
            this.fileDataGrid.TabIndex = 4;
            this.fileDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onRemoveFile);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 859);
            this.Controls.Add(this.fileDataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Hackathon Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Button btn_AddFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView fileDataGrid;
        private System.Windows.Forms.Button btn_ClearList;
        private System.Windows.Forms.Button btn_AddOnlyFile;
    }
}