namespace Text_File_Builder
{
    partial class MainWindow
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.editorSplitContainer = new System.Windows.Forms.SplitContainer();
            this.titleBox = new System.Windows.Forms.GroupBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.contentBox = new System.Windows.Forms.GroupBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.bottomSplitContainer = new System.Windows.Forms.SplitContainer();
            this.pathBox = new System.Windows.Forms.GroupBox();
            this.pathSplitContainer = new System.Windows.Forms.SplitContainer();
            this.pathText = new System.Windows.Forms.TextBox();
            this.changeDirButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabber = new System.Windows.Forms.TabControl();
            this.createPage = new System.Windows.Forms.TabPage();
            this.logsPage = new System.Windows.Forms.TabPage();
            this.logs = new System.Windows.Forms.ListView();
            this.timeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.editorSplitContainer.Panel1.SuspendLayout();
            this.editorSplitContainer.Panel2.SuspendLayout();
            this.editorSplitContainer.SuspendLayout();
            this.titleBox.SuspendLayout();
            this.contentBox.SuspendLayout();
            this.bottomSplitContainer.Panel1.SuspendLayout();
            this.bottomSplitContainer.Panel2.SuspendLayout();
            this.bottomSplitContainer.SuspendLayout();
            this.pathBox.SuspendLayout();
            this.pathSplitContainer.Panel1.SuspendLayout();
            this.pathSplitContainer.Panel2.SuspendLayout();
            this.pathSplitContainer.SuspendLayout();
            this.tabber.SuspendLayout();
            this.createPage.SuspendLayout();
            this.logsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.editorSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.bottomSplitContainer);
            this.mainSplitContainer.Size = new System.Drawing.Size(786, 418);
            this.mainSplitContainer.SplitterDistance = 368;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // editorSplitContainer
            // 
            this.editorSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.editorSplitContainer.IsSplitterFixed = true;
            this.editorSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.editorSplitContainer.Name = "editorSplitContainer";
            this.editorSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // editorSplitContainer.Panel1
            // 
            this.editorSplitContainer.Panel1.Controls.Add(this.titleBox);
            // 
            // editorSplitContainer.Panel2
            // 
            this.editorSplitContainer.Panel2.Controls.Add(this.contentBox);
            this.editorSplitContainer.Size = new System.Drawing.Size(786, 368);
            this.editorSplitContainer.SplitterDistance = 40;
            this.editorSplitContainer.TabIndex = 0;
            // 
            // titleBox
            // 
            this.titleBox.Controls.Add(this.titleTextBox);
            this.titleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBox.Location = new System.Drawing.Point(0, 0);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(786, 40);
            this.titleBox.TabIndex = 2;
            this.titleBox.TabStop = false;
            this.titleBox.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTextBox.Location = new System.Drawing.Point(3, 16);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(780, 20);
            this.titleTextBox.TabIndex = 0;
            // 
            // contentBox
            // 
            this.contentBox.Controls.Add(this.contentTextBox);
            this.contentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentBox.Location = new System.Drawing.Point(0, 0);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(786, 324);
            this.contentBox.TabIndex = 1;
            this.contentBox.TabStop = false;
            this.contentBox.Text = "Content";
            // 
            // contentTextBox
            // 
            this.contentTextBox.AcceptsReturn = true;
            this.contentTextBox.AcceptsTab = true;
            this.contentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTextBox.Location = new System.Drawing.Point(3, 16);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(780, 305);
            this.contentTextBox.TabIndex = 0;
            // 
            // bottomSplitContainer
            // 
            this.bottomSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.bottomSplitContainer.IsSplitterFixed = true;
            this.bottomSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.bottomSplitContainer.Name = "bottomSplitContainer";
            // 
            // bottomSplitContainer.Panel1
            // 
            this.bottomSplitContainer.Panel1.Controls.Add(this.pathBox);
            // 
            // bottomSplitContainer.Panel2
            // 
            this.bottomSplitContainer.Panel2.Controls.Add(this.saveButton);
            this.bottomSplitContainer.Size = new System.Drawing.Size(786, 46);
            this.bottomSplitContainer.SplitterDistance = 649;
            this.bottomSplitContainer.SplitterWidth = 15;
            this.bottomSplitContainer.TabIndex = 0;
            // 
            // pathBox
            // 
            this.pathBox.Controls.Add(this.pathSplitContainer);
            this.pathBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathBox.Location = new System.Drawing.Point(0, 0);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(649, 46);
            this.pathBox.TabIndex = 3;
            this.pathBox.TabStop = false;
            this.pathBox.Text = "Path";
            // 
            // pathSplitContainer
            // 
            this.pathSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.pathSplitContainer.IsSplitterFixed = true;
            this.pathSplitContainer.Location = new System.Drawing.Point(3, 16);
            this.pathSplitContainer.Name = "pathSplitContainer";
            // 
            // pathSplitContainer.Panel1
            // 
            this.pathSplitContainer.Panel1.Controls.Add(this.pathText);
            this.pathSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            // 
            // pathSplitContainer.Panel2
            // 
            this.pathSplitContainer.Panel2.Controls.Add(this.changeDirButton);
            this.pathSplitContainer.Size = new System.Drawing.Size(643, 27);
            this.pathSplitContainer.SplitterDistance = 561;
            this.pathSplitContainer.TabIndex = 3;
            this.pathSplitContainer.TabStop = false;
            // 
            // pathText
            // 
            this.pathText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathText.Location = new System.Drawing.Point(0, 3);
            this.pathText.Name = "pathText";
            this.pathText.ReadOnly = true;
            this.pathText.Size = new System.Drawing.Size(561, 20);
            this.pathText.TabIndex = 2;
            this.pathText.TabStop = false;
            // 
            // changeDirButton
            // 
            this.changeDirButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeDirButton.Location = new System.Drawing.Point(0, 0);
            this.changeDirButton.Name = "changeDirButton";
            this.changeDirButton.Size = new System.Drawing.Size(78, 27);
            this.changeDirButton.TabIndex = 0;
            this.changeDirButton.Text = "Change";
            this.changeDirButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.SpringGreen;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(0, 0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 46);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Please select the folder where you wish to save your documents.";
            // 
            // tabber
            // 
            this.tabber.Controls.Add(this.createPage);
            this.tabber.Controls.Add(this.logsPage);
            this.tabber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabber.Location = new System.Drawing.Point(0, 0);
            this.tabber.Name = "tabber";
            this.tabber.SelectedIndex = 0;
            this.tabber.Size = new System.Drawing.Size(800, 450);
            this.tabber.TabIndex = 1;
            this.tabber.TabStop = false;
            // 
            // createPage
            // 
            this.createPage.Controls.Add(this.mainSplitContainer);
            this.createPage.Location = new System.Drawing.Point(4, 22);
            this.createPage.Name = "createPage";
            this.createPage.Padding = new System.Windows.Forms.Padding(3);
            this.createPage.Size = new System.Drawing.Size(792, 424);
            this.createPage.TabIndex = 0;
            this.createPage.Text = "Create";
            // 
            // logsPage
            // 
            this.logsPage.Controls.Add(this.logs);
            this.logsPage.Location = new System.Drawing.Point(4, 22);
            this.logsPage.Name = "logsPage";
            this.logsPage.Padding = new System.Windows.Forms.Padding(3);
            this.logsPage.Size = new System.Drawing.Size(792, 424);
            this.logsPage.TabIndex = 1;
            this.logsPage.Text = "Logs";
            this.logsPage.UseVisualStyleBackColor = true;
            // 
            // logs
            // 
            this.logs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.timeColumnHeader,
            this.descriptionColumnHeader});
            this.logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logs.FullRowSelect = true;
            this.logs.Location = new System.Drawing.Point(3, 3);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(786, 418);
            this.logs.TabIndex = 0;
            this.logs.UseCompatibleStateImageBehavior = false;
            this.logs.View = System.Windows.Forms.View.Details;
            // 
            // timeColumnHeader
            // 
            this.timeColumnHeader.Text = "Time";
            this.timeColumnHeader.Width = 130;
            // 
            // descriptionColumnHeader
            // 
            this.descriptionColumnHeader.Text = "Description";
            this.descriptionColumnHeader.Width = 600;
            // 
            // MainWindow
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabber);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Text File Builder";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.editorSplitContainer.Panel1.ResumeLayout(false);
            this.editorSplitContainer.Panel2.ResumeLayout(false);
            this.editorSplitContainer.ResumeLayout(false);
            this.titleBox.ResumeLayout(false);
            this.titleBox.PerformLayout();
            this.contentBox.ResumeLayout(false);
            this.contentBox.PerformLayout();
            this.bottomSplitContainer.Panel1.ResumeLayout(false);
            this.bottomSplitContainer.Panel2.ResumeLayout(false);
            this.bottomSplitContainer.ResumeLayout(false);
            this.pathBox.ResumeLayout(false);
            this.pathSplitContainer.Panel1.ResumeLayout(false);
            this.pathSplitContainer.Panel1.PerformLayout();
            this.pathSplitContainer.Panel2.ResumeLayout(false);
            this.pathSplitContainer.ResumeLayout(false);
            this.tabber.ResumeLayout(false);
            this.createPage.ResumeLayout(false);
            this.logsPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.SplitContainer editorSplitContainer;
        private System.Windows.Forms.Button changeDirButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox contentBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.GroupBox titleBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.SplitContainer bottomSplitContainer;
        private System.Windows.Forms.GroupBox pathBox;
        private System.Windows.Forms.SplitContainer pathSplitContainer;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.TabControl tabber;
        private System.Windows.Forms.TabPage createPage;
        private System.Windows.Forms.TabPage logsPage;
        private System.Windows.Forms.ListView logs;
        private System.Windows.Forms.ColumnHeader timeColumnHeader;
        private System.Windows.Forms.ColumnHeader descriptionColumnHeader;
    }
}

