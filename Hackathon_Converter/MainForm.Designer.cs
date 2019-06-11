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
            this.Btn_Control_Panel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RemoveFile = new System.Windows.Forms.Button();
            this.btn_ClearList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_AddOnlyFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileDataGrid = new System.Windows.Forms.DataGridView();
            this.Format_Options = new System.Windows.Forms.GroupBox();
            this.Other = new System.Windows.Forms.GroupBox();
            this.chapSeparate = new System.Windows.Forms.CheckBox();
            this.isJustified = new System.Windows.Forms.CheckBox();
            this.Read_Direction = new System.Windows.Forms.GroupBox();
            this.directL2R = new System.Windows.Forms.RadioButton();
            this.directR2L = new System.Windows.Forms.RadioButton();
            this.Num_Columns = new System.Windows.Forms.GroupBox();
            this.Single_col = new System.Windows.Forms.RadioButton();
            this.Double_Col = new System.Windows.Forms.RadioButton();
            this.Spacing = new System.Windows.Forms.GroupBox();
            this.Single_Space = new System.Windows.Forms.RadioButton();
            this.Double_Space = new System.Windows.Forms.RadioButton();
            this.Btn_Control_Panel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).BeginInit();
            this.Format_Options.SuspendLayout();
            this.Other.SuspendLayout();
            this.Read_Direction.SuspendLayout();
            this.Num_Columns.SuspendLayout();
            this.Spacing.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConvert
            // 
            this.BtnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConvert.Location = new System.Drawing.Point(78, 145);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(363, 91);
            this.BtnConvert.TabIndex = 0;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.OnConvertButtonClick);
            // 
            // btn_AddFiles
            // 
            this.btn_AddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFiles.Location = new System.Drawing.Point(74, 99);
            this.btn_AddFiles.Name = "btn_AddFiles";
            this.btn_AddFiles.Size = new System.Drawing.Size(347, 75);
            this.btn_AddFiles.TabIndex = 1;
            this.btn_AddFiles.Text = "Add Directory";
            this.btn_AddFiles.UseVisualStyleBackColor = true;
            this.btn_AddFiles.Click += new System.EventHandler(this.OnAddFilesButtonClick);
            // 
            // Btn_Control_Panel
            // 
            this.Btn_Control_Panel.Controls.Add(this.groupBox3);
            this.Btn_Control_Panel.Controls.Add(this.groupBox2);
            this.Btn_Control_Panel.Controls.Add(this.groupBox1);
            this.Btn_Control_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Control_Panel.Location = new System.Drawing.Point(0, 693);
            this.Btn_Control_Panel.Name = "Btn_Control_Panel";
            this.Btn_Control_Panel.Size = new System.Drawing.Size(1567, 338);
            this.Btn_Control_Panel.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RemoveFile);
            this.groupBox3.Controls.Add(this.btn_ClearList);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(510, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 338);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remove";
            // 
            // RemoveFile
            // 
            this.RemoveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFile.Location = new System.Drawing.Point(81, 213);
            this.RemoveFile.Name = "RemoveFile";
            this.RemoveFile.Size = new System.Drawing.Size(347, 78);
            this.RemoveFile.TabIndex = 4;
            this.RemoveFile.Text = "Remove File";
            this.RemoveFile.UseVisualStyleBackColor = true;
            this.RemoveFile.Click += new System.EventHandler(this.onRemoveFileButtonClick);
            // 
            // btn_ClearList
            // 
            this.btn_ClearList.AutoSize = true;
            this.btn_ClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearList.Location = new System.Drawing.Point(81, 99);
            this.btn_ClearList.Name = "btn_ClearList";
            this.btn_ClearList.Size = new System.Drawing.Size(347, 75);
            this.btn_ClearList.TabIndex = 2;
            this.btn_ClearList.Text = "Clear List";
            this.btn_ClearList.UseVisualStyleBackColor = true;
            this.btn_ClearList.Click += new System.EventHandler(this.onClearListButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_AddFiles);
            this.groupBox2.Controls.Add(this.btn_AddOnlyFile);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 338);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add";
            // 
            // btn_AddOnlyFile
            // 
            this.btn_AddOnlyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddOnlyFile.Location = new System.Drawing.Point(74, 216);
            this.btn_AddOnlyFile.Name = "btn_AddOnlyFile";
            this.btn_AddOnlyFile.Size = new System.Drawing.Size(347, 75);
            this.btn_AddOnlyFile.TabIndex = 3;
            this.btn_AddOnlyFile.Text = "Add File";
            this.btn_AddOnlyFile.UseVisualStyleBackColor = true;
            this.btn_AddOnlyFile.Click += new System.EventHandler(this.onAddOnlyFileClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnConvert);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1052, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 338);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert";
            // 
            // fileDataGrid
            // 
            this.fileDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileDataGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.fileDataGrid.Location = new System.Drawing.Point(0, 0);
            this.fileDataGrid.Name = "fileDataGrid";
            this.fileDataGrid.RowTemplate.Height = 33;
            this.fileDataGrid.Size = new System.Drawing.Size(1142, 693);
            this.fileDataGrid.TabIndex = 4;
            // 
            // Format_Options
            // 
            this.Format_Options.Controls.Add(this.Other);
            this.Format_Options.Controls.Add(this.Read_Direction);
            this.Format_Options.Controls.Add(this.Num_Columns);
            this.Format_Options.Controls.Add(this.Spacing);
            this.Format_Options.Dock = System.Windows.Forms.DockStyle.Right;
            this.Format_Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Format_Options.Location = new System.Drawing.Point(1148, 0);
            this.Format_Options.Name = "Format_Options";
            this.Format_Options.Size = new System.Drawing.Size(419, 693);
            this.Format_Options.TabIndex = 5;
            this.Format_Options.TabStop = false;
            this.Format_Options.Text = "Format Options";
            // 
            // Other
            // 
            this.Other.Controls.Add(this.chapSeparate);
            this.Other.Controls.Add(this.isJustified);
            this.Other.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Other.Location = new System.Drawing.Point(6, 458);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(402, 229);
            this.Other.TabIndex = 4;
            this.Other.TabStop = false;
            this.Other.Text = "Other";
            // 
            // chapSeparate
            // 
            this.chapSeparate.AutoSize = true;
            this.chapSeparate.Location = new System.Drawing.Point(45, 96);
            this.chapSeparate.Name = "chapSeparate";
            this.chapSeparate.Size = new System.Drawing.Size(274, 35);
            this.chapSeparate.TabIndex = 1;
            this.chapSeparate.Text = "Separate Chapters";
            this.chapSeparate.UseVisualStyleBackColor = true;
            this.chapSeparate.CheckedChanged += new System.EventHandler(this.chapSeparate_CheckedChanged);
            // 
            // isJustified
            // 
            this.isJustified.AutoSize = true;
            this.isJustified.Location = new System.Drawing.Point(45, 45);
            this.isJustified.Name = "isJustified";
            this.isJustified.Size = new System.Drawing.Size(187, 35);
            this.isJustified.TabIndex = 0;
            this.isJustified.Text = "Justify-Text";
            this.isJustified.UseVisualStyleBackColor = true;
            this.isJustified.CheckedChanged += new System.EventHandler(this.isJustified_CheckedChanged);
            // 
            // Read_Direction
            // 
            this.Read_Direction.Controls.Add(this.directL2R);
            this.Read_Direction.Controls.Add(this.directR2L);
            this.Read_Direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read_Direction.Location = new System.Drawing.Point(6, 296);
            this.Read_Direction.Name = "Read_Direction";
            this.Read_Direction.Size = new System.Drawing.Size(403, 148);
            this.Read_Direction.TabIndex = 3;
            this.Read_Direction.TabStop = false;
            this.Read_Direction.Text = "Reading Direction";
            // 
            // directL2R
            // 
            this.directL2R.AutoSize = true;
            this.directL2R.Checked = true;
            this.directL2R.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directL2R.Location = new System.Drawing.Point(45, 47);
            this.directL2R.Name = "directL2R";
            this.directL2R.Size = new System.Drawing.Size(196, 35);
            this.directL2R.TabIndex = 0;
            this.directL2R.TabStop = true;
            this.directL2R.Text = "Left-to-Right";
            this.directL2R.UseVisualStyleBackColor = true;
            this.directL2R.CheckedChanged += new System.EventHandler(this.Direct_L2R_CheckedChanged);
            // 
            // directR2L
            // 
            this.directR2L.AutoSize = true;
            this.directR2L.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directR2L.Location = new System.Drawing.Point(45, 88);
            this.directR2L.Name = "directR2L";
            this.directR2L.Size = new System.Drawing.Size(196, 35);
            this.directR2L.TabIndex = 1;
            this.directR2L.Text = "Right-to-Left";
            this.directR2L.UseVisualStyleBackColor = true;
            this.directR2L.CheckedChanged += new System.EventHandler(this.Direct_R2L_CheckedChanged);
            // 
            // Num_Columns
            // 
            this.Num_Columns.Controls.Add(this.Single_col);
            this.Num_Columns.Controls.Add(this.Double_Col);
            this.Num_Columns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Columns.Location = new System.Drawing.Point(6, 192);
            this.Num_Columns.Name = "Num_Columns";
            this.Num_Columns.Size = new System.Drawing.Size(403, 98);
            this.Num_Columns.TabIndex = 3;
            this.Num_Columns.TabStop = false;
            this.Num_Columns.Text = "# of Columns";
            // 
            // Single_col
            // 
            this.Single_col.AutoSize = true;
            this.Single_col.Checked = true;
            this.Single_col.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Single_col.Location = new System.Drawing.Point(45, 47);
            this.Single_col.Name = "Single_col";
            this.Single_col.Size = new System.Drawing.Size(60, 35);
            this.Single_col.TabIndex = 0;
            this.Single_col.TabStop = true;
            this.Single_col.Text = "1";
            this.Single_col.UseVisualStyleBackColor = true;
            this.Single_col.CheckedChanged += new System.EventHandler(this.Single_col_CheckedChanged);
            // 
            // Double_Col
            // 
            this.Double_Col.AutoSize = true;
            this.Double_Col.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Double_Col.Location = new System.Drawing.Point(187, 47);
            this.Double_Col.Name = "Double_Col";
            this.Double_Col.Size = new System.Drawing.Size(60, 35);
            this.Double_Col.TabIndex = 1;
            this.Double_Col.Text = "2";
            this.Double_Col.UseVisualStyleBackColor = true;
            this.Double_Col.CheckedChanged += new System.EventHandler(this.Double_col_CheckedChanged);
            // 
            // Spacing
            // 
            this.Spacing.Controls.Add(this.Single_Space);
            this.Spacing.Controls.Add(this.Double_Space);
            this.Spacing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spacing.Location = new System.Drawing.Point(6, 88);
            this.Spacing.Name = "Spacing";
            this.Spacing.Size = new System.Drawing.Size(403, 98);
            this.Spacing.TabIndex = 2;
            this.Spacing.TabStop = false;
            this.Spacing.Text = "Spacing";
            // 
            // Single_Space
            // 
            this.Single_Space.AutoSize = true;
            this.Single_Space.Checked = true;
            this.Single_Space.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Single_Space.Location = new System.Drawing.Point(45, 47);
            this.Single_Space.Name = "Single_Space";
            this.Single_Space.Size = new System.Drawing.Size(120, 35);
            this.Single_Space.TabIndex = 0;
            this.Single_Space.TabStop = true;
            this.Single_Space.Text = "Single";
            this.Single_Space.UseVisualStyleBackColor = true;
            this.Single_Space.CheckedChanged += new System.EventHandler(this.Single_space_CheckedChanged);
            // 
            // Double_Space
            // 
            this.Double_Space.AutoSize = true;
            this.Double_Space.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Double_Space.Location = new System.Drawing.Point(187, 47);
            this.Double_Space.Name = "Double_Space";
            this.Double_Space.Size = new System.Drawing.Size(131, 35);
            this.Double_Space.TabIndex = 1;
            this.Double_Space.Text = "Double";
            this.Double_Space.UseVisualStyleBackColor = true;
            this.Double_Space.CheckedChanged += new System.EventHandler(this.Double_space_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 1031);
            this.Controls.Add(this.Format_Options);
            this.Controls.Add(this.fileDataGrid);
            this.Controls.Add(this.Btn_Control_Panel);
            this.Name = "MainForm";
            this.Text = "Hackathon Converter";
            this.Btn_Control_Panel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileDataGrid)).EndInit();
            this.Format_Options.ResumeLayout(false);
            this.Other.ResumeLayout(false);
            this.Other.PerformLayout();
            this.Read_Direction.ResumeLayout(false);
            this.Read_Direction.PerformLayout();
            this.Num_Columns.ResumeLayout(false);
            this.Num_Columns.PerformLayout();
            this.Spacing.ResumeLayout(false);
            this.Spacing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView fileDataGrid;

        private System.Windows.Forms.Panel Btn_Control_Panel;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Button btn_AddFiles;
        private System.Windows.Forms.Button btn_ClearList;
        private System.Windows.Forms.Button btn_AddOnlyFile;
        
        
        private System.Windows.Forms.GroupBox Format_Options;

        private System.Windows.Forms.GroupBox Spacing;
        private System.Windows.Forms.RadioButton Double_Space;
        private System.Windows.Forms.RadioButton Single_Space;
        
        private System.Windows.Forms.GroupBox Read_Direction;
        private System.Windows.Forms.RadioButton directL2R;
        private System.Windows.Forms.RadioButton directR2L;

        private System.Windows.Forms.GroupBox Num_Columns;
        private System.Windows.Forms.RadioButton Single_col;
        private System.Windows.Forms.RadioButton Double_Col;

        private System.Windows.Forms.GroupBox Other;
        private System.Windows.Forms.CheckBox isJustified;
        private System.Windows.Forms.CheckBox chapSeparate;

        private bool isTextJustified = false;
        private bool isSingleSpaced=true;
        private bool hasOneColumn=true;
        private bool isL2RDirection=true;
        private bool willSeparateChap = false;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RemoveFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}