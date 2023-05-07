namespace RegoReader_v1._0
{
    partial class RegistrationReaderForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ButtonBinSearch = new System.Windows.Forms.Button();
            this.ButtonLinSearch = new System.Windows.Forms.Button();
            this.GrpBoxFileOptions = new System.Windows.Forms.GroupBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.GrpBoxEntryOptions = new System.Windows.Forms.GroupBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxEntry = new System.Windows.Forms.TextBox();
            this.TextBoxErrorMes = new System.Windows.Forms.TextBox();
            this.ButtonTag = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ListBoxRego = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.GrpBoxFileOptions.SuspendLayout();
            this.GrpBoxEntryOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ButtonBinSearch);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonLinSearch);
            this.splitContainer1.Panel1.Controls.Add(this.GrpBoxFileOptions);
            this.splitContainer1.Panel1.Controls.Add(this.GrpBoxEntryOptions);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.TextBoxEntry);
            this.splitContainer1.Panel1.Click += new System.EventHandler(this.splitContainer1_Panel2_Click);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TextBoxErrorMes);
            this.splitContainer1.Panel2.Controls.Add(this.ButtonTag);
            this.splitContainer1.Panel2.Controls.Add(this.ButtonReset);
            this.splitContainer1.Panel2.Controls.Add(this.ListBoxRego);
            this.splitContainer1.Panel2.Click += new System.EventHandler(this.splitContainer1_Panel2_Click);
            this.splitContainer1.Size = new System.Drawing.Size(487, 626);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // ButtonBinSearch
            // 
            this.ButtonBinSearch.Location = new System.Drawing.Point(357, 50);
            this.ButtonBinSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonBinSearch.Name = "ButtonBinSearch";
            this.ButtonBinSearch.Size = new System.Drawing.Size(112, 28);
            this.ButtonBinSearch.TabIndex = 12;
            this.ButtonBinSearch.Text = "Binary Search";
            this.ButtonBinSearch.UseVisualStyleBackColor = true;
            this.ButtonBinSearch.Click += new System.EventHandler(this.ButtonBinSearch_Click);
            this.ButtonBinSearch.MouseHover += new System.EventHandler(this.ButtonBinSearch_MouseHover);
            // 
            // ButtonLinSearch
            // 
            this.ButtonLinSearch.Location = new System.Drawing.Point(357, 15);
            this.ButtonLinSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonLinSearch.Name = "ButtonLinSearch";
            this.ButtonLinSearch.Size = new System.Drawing.Size(112, 28);
            this.ButtonLinSearch.TabIndex = 11;
            this.ButtonLinSearch.Text = "Linear Search";
            this.ButtonLinSearch.UseVisualStyleBackColor = true;
            this.ButtonLinSearch.Click += new System.EventHandler(this.ButtonLinSearch_Click);
            this.ButtonLinSearch.MouseHover += new System.EventHandler(this.ButtonLinSearch_MouseHover);
            // 
            // GrpBoxFileOptions
            // 
            this.GrpBoxFileOptions.Controls.Add(this.ButtonExit);
            this.GrpBoxFileOptions.Controls.Add(this.ButtonSave);
            this.GrpBoxFileOptions.Controls.Add(this.ButtonOpen);
            this.GrpBoxFileOptions.Location = new System.Drawing.Point(16, 130);
            this.GrpBoxFileOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpBoxFileOptions.Name = "GrpBoxFileOptions";
            this.GrpBoxFileOptions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpBoxFileOptions.Size = new System.Drawing.Size(333, 60);
            this.GrpBoxFileOptions.TabIndex = 1;
            this.GrpBoxFileOptions.TabStop = false;
            this.GrpBoxFileOptions.Text = "File Options";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(221, 20);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(104, 28);
            this.ButtonExit.TabIndex = 5;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            this.ButtonExit.MouseHover += new System.EventHandler(this.ButtonExit_MouseHover);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(116, 20);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(100, 28);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            this.ButtonSave.MouseHover += new System.EventHandler(this.ButtonSave_MouseHover);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(12, 20);
            this.ButtonOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(100, 28);
            this.ButtonOpen.TabIndex = 3;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            this.ButtonOpen.MouseHover += new System.EventHandler(this.ButtonOpen_MouseHover);
            // 
            // GrpBoxEntryOptions
            // 
            this.GrpBoxEntryOptions.Controls.Add(this.ButtonAdd);
            this.GrpBoxEntryOptions.Controls.Add(this.ButtonDelete);
            this.GrpBoxEntryOptions.Controls.Add(this.ButtonEdit);
            this.GrpBoxEntryOptions.Location = new System.Drawing.Point(16, 64);
            this.GrpBoxEntryOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpBoxEntryOptions.Name = "GrpBoxEntryOptions";
            this.GrpBoxEntryOptions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpBoxEntryOptions.Size = new System.Drawing.Size(333, 60);
            this.GrpBoxEntryOptions.TabIndex = 10;
            this.GrpBoxEntryOptions.TabStop = false;
            this.GrpBoxEntryOptions.Text = "Entry Options";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(12, 20);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(100, 28);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            this.ButtonAdd.MouseHover += new System.EventHandler(this.ButtonAdd_MouseHover);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(221, 20);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(100, 28);
            this.ButtonDelete.TabIndex = 1;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            this.ButtonDelete.MouseHover += new System.EventHandler(this.ButtonDelete_MouseHover);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(116, 20);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(100, 28);
            this.ButtonEdit.TabIndex = 0;
            this.ButtonEdit.Text = "Update";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            this.ButtonEdit.MouseHover += new System.EventHandler(this.ButtonEdit_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registration Entry";
            // 
            // TextBoxEntry
            // 
            this.TextBoxEntry.Location = new System.Drawing.Point(28, 34);
            this.TextBoxEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxEntry.Name = "TextBoxEntry";
            this.TextBoxEntry.Size = new System.Drawing.Size(308, 22);
            this.TextBoxEntry.TabIndex = 1;
            this.TextBoxEntry.MouseHover += new System.EventHandler(this.TextBoxEntry_MouseHover);
            // 
            // TextBoxErrorMes
            // 
            this.TextBoxErrorMes.Location = new System.Drawing.Point(16, 379);
            this.TextBoxErrorMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxErrorMes.Name = "TextBoxErrorMes";
            this.TextBoxErrorMes.ReadOnly = true;
            this.TextBoxErrorMes.Size = new System.Drawing.Size(452, 22);
            this.TextBoxErrorMes.TabIndex = 6;
            // 
            // ButtonTag
            // 
            this.ButtonTag.Location = new System.Drawing.Point(357, 12);
            this.ButtonTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonTag.Name = "ButtonTag";
            this.ButtonTag.Size = new System.Drawing.Size(100, 28);
            this.ButtonTag.TabIndex = 5;
            this.ButtonTag.Text = "Tag";
            this.ButtonTag.UseVisualStyleBackColor = true;
            this.ButtonTag.Click += new System.EventHandler(this.ButtonTag_Click);
            this.ButtonTag.MouseHover += new System.EventHandler(this.ButtonTag_MouseHover);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(357, 341);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(100, 28);
            this.ButtonReset.TabIndex = 1;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            this.ButtonReset.MouseHover += new System.EventHandler(this.ButtonReset_MouseHover);
            // 
            // ListBoxRego
            // 
            this.ListBoxRego.FormattingEnabled = true;
            this.ListBoxRego.ItemHeight = 16;
            this.ListBoxRego.Location = new System.Drawing.Point(16, 12);
            this.ListBoxRego.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListBoxRego.Name = "ListBoxRego";
            this.ListBoxRego.Size = new System.Drawing.Size(320, 356);
            this.ListBoxRego.Sorted = true;
            this.ListBoxRego.TabIndex = 0;
            this.ListBoxRego.Click += new System.EventHandler(this.ListBoxRego_Click);
            this.ListBoxRego.DoubleClick += new System.EventHandler(this.ListBoxRego_DoubleClick);
            this.ListBoxRego.MouseHover += new System.EventHandler(this.ListBoxRego_MouseHover);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "fileDirectory";
            this.openFileDialog1.Title = "Browse Text Files";
            // 
            // RegistrationReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 626);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistrationReaderForm";
            this.Text = "Registration Reader";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.GrpBoxFileOptions.ResumeLayout(false);
            this.GrpBoxEntryOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox GrpBoxFileOptions;
        private System.Windows.Forms.Button ButtonTag;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.GroupBox GrpBoxEntryOptions;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxEntry;
        private System.Windows.Forms.ListBox ListBoxRego;
        private System.Windows.Forms.Button ButtonBinSearch;
        private System.Windows.Forms.Button ButtonLinSearch;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TextBoxErrorMes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

