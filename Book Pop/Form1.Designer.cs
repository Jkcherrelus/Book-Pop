namespace Book_Pop
{
    partial class Form1
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

        //---------Field--------//
        private System.Windows.Forms.Button _acceptButton;
        private System.Windows.Forms.Label _iniWebPage;
        private System.Windows.Forms.Button _addXpath;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allNodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xpathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canceledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xpathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._newNode = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._job1 = new System.Windows.Forms.TabPage();
            this._job2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.controllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controllerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookRemainingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCompletion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this._job1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controllerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controllerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNodeToolStripMenuItem,
            this.openToolStripMenuItem,
            this.addPathToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newNodeToolStripMenuItem
            // 
            this.newNodeToolStripMenuItem.Name = "newNodeToolStripMenuItem";
            this.newNodeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.newNodeToolStripMenuItem.Text = "New Node";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // addPathToolStripMenuItem
            // 
            this.addPathToolStripMenuItem.Name = "addPathToolStripMenuItem";
            this.addPathToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addPathToolStripMenuItem.Text = "Add Path";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allNodesToolStripMenuItem,
            this.xpathsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // allNodesToolStripMenuItem
            // 
            this.allNodesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.xpathToolStripMenuItem,
            this.runningToolStripMenuItem,
            this.canceledToolStripMenuItem,
            this.completedToolStripMenuItem});
            this.allNodesToolStripMenuItem.Name = "allNodesToolStripMenuItem";
            this.allNodesToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.allNodesToolStripMenuItem.Text = "Nodes";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // xpathToolStripMenuItem
            // 
            this.xpathToolStripMenuItem.Name = "xpathToolStripMenuItem";
            this.xpathToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.xpathToolStripMenuItem.Text = "Xpath";
            // 
            // runningToolStripMenuItem
            // 
            this.runningToolStripMenuItem.Name = "runningToolStripMenuItem";
            this.runningToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.runningToolStripMenuItem.Text = "Running";
            // 
            // canceledToolStripMenuItem
            // 
            this.canceledToolStripMenuItem.Name = "canceledToolStripMenuItem";
            this.canceledToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.canceledToolStripMenuItem.Text = "Canceled";
            // 
            // completedToolStripMenuItem
            // 
            this.completedToolStripMenuItem.Name = "completedToolStripMenuItem";
            this.completedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.completedToolStripMenuItem.Text = "Completed";
            // 
            // xpathsToolStripMenuItem
            // 
            this.xpathsToolStripMenuItem.Name = "xpathsToolStripMenuItem";
            this.xpathsToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.xpathsToolStripMenuItem.Text = "Xpaths";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._newNode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(707, 476);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 1;
            // 
            // _newNode
            // 
            this._newNode.Location = new System.Drawing.Point(3, 3);
            this._newNode.Name = "_newNode";
            this._newNode.Size = new System.Drawing.Size(138, 39);
            this._newNode.TabIndex = 0;
            this._newNode.Text = "New Job";
            this._newNode.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this._job1);
            this.tabControl1.Controls.Add(this._job2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // _job1
            // 
            this._job1.Controls.Add(this.dataGridView1);
            this._job1.Location = new System.Drawing.Point(4, 22);
            this._job1.Name = "_job1";
            this._job1.Padding = new System.Windows.Forms.Padding(3);
            this._job1.Size = new System.Drawing.Size(589, 447);
            this._job1.TabIndex = 0;
            this._job1.Text = "Job 1";
            this._job1.UseVisualStyleBackColor = true;
            // 
            // _job2
            // 
            this._job2.Location = new System.Drawing.Point(4, 22);
            this._job2.Name = "_job2";
            this._job2.Padding = new System.Windows.Forms.Padding(3);
            this._job2.Size = new System.Drawing.Size(589, 447);
            this._job2.TabIndex = 1;
            this._job2.Text = "Job 2";
            this._job2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.BookWebsite,
            this.BookRemainingTime,
            this.BookCompletion});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 441);
            this.dataGridView1.TabIndex = 0;
            // 
            // controllerBindingSource
            // 
            this.controllerBindingSource.DataSource = typeof(Book_Pop.Controller);
            // 
            // controllerBindingSource1
            // 
            this.controllerBindingSource1.DataSource = typeof(Book_Pop.Controller);
            // 
            // BookName
            // 
            this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookName.HeaderText = "Name";
            this.BookName.Name = "BookName";
            // 
            // BookWebsite
            // 
            this.BookWebsite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookWebsite.HeaderText = "Website";
            this.BookWebsite.Name = "BookWebsite";
            // 
            // BookRemainingTime
            // 
            this.BookRemainingTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookRemainingTime.HeaderText = "Remaining Time";
            this.BookRemainingTime.Name = "BookRemainingTime";
            // 
            // BookCompletion
            // 
            this.BookCompletion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookCompletion.HeaderText = "Complete";
            this.BookCompletion.Name = "BookCompletion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 500);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Book Pop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this._job1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controllerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controllerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        //--------------Main Window Form---------------------//
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allNodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xpathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canceledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xpathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button _newNode;
        private System.Windows.Forms.ToolStripMenuItem addPathToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage _job1;
        private System.Windows.Forms.TabPage _job2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource controllerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookWebsite;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookRemainingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCompletion;
        private System.Windows.Forms.BindingSource controllerBindingSource1;
    }
}

