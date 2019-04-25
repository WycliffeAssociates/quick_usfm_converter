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
            this.fileDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConvert
            // 
            this.BtnConvert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConvert.Location = new System.Drawing.Point(0, 87);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(800, 70);
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
            this.btn_AddFiles.Size = new System.Drawing.Size(800, 70);
            this.btn_AddFiles.TabIndex = 1;
            this.btn_AddFiles.Text = "Add Directory";
            this.btn_AddFiles.UseVisualStyleBackColor = true;
            this.btn_AddFiles.Click += new System.EventHandler(this.OnAddFilesButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_AddFiles);
            this.panel1.Controls.Add(this.BtnConvert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 157);
            this.panel1.TabIndex = 3;
            // 
            // fileDataGrid
            // 
            this.fileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileDataGrid.Location = new System.Drawing.Point(0, 0);
            this.fileDataGrid.Name = "fileDataGrid";
            this.fileDataGrid.RowTemplate.Height = 33;
            this.fileDataGrid.Size = new System.Drawing.Size(800, 293);
            this.fileDataGrid.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fileDataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Hackathon Converter";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Button btn_AddFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView fileDataGrid;
    }
}

