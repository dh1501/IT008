
namespace WindowExplorer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitMenu = new System.Windows.Forms.Splitter();
            this.splitTreeView = new System.Windows.Forms.Splitter();
            this.splitListView = new System.Windows.Forms.Splitter();
            this.treeView = new System.Windows.Forms.TreeView();
            this.listView = new System.Windows.Forms.ListView();
            this.imglstTreeView = new System.Windows.Forms.ImageList(this.components);
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imglstlarge = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.meuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRename = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.menuList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.tsbtnUp = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsDropView = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmenuLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.tsPath = new System.Windows.Forms.ToolStrip();
            this.tscmbPath = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnGo = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.tsPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMenu
            // 
            this.splitMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitMenu.Location = new System.Drawing.Point(0, 28);
            this.splitMenu.Name = "splitMenu";
            this.splitMenu.Size = new System.Drawing.Size(1232, 319);
            this.splitMenu.TabIndex = 0;
            this.splitMenu.TabStop = false;
            // 
            // splitTreeView
            // 
            this.splitTreeView.Location = new System.Drawing.Point(0, 347);
            this.splitTreeView.Name = "splitTreeView";
            this.splitTreeView.Size = new System.Drawing.Size(65535, 481);
            this.splitTreeView.TabIndex = 2;
            this.splitTreeView.TabStop = false;
            // 
            // splitListView
            // 
            this.splitListView.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitListView.Location = new System.Drawing.Point(-32768, 347);
            this.splitListView.Name = "splitListView";
            this.splitListView.Size = new System.Drawing.Size(65535, 481);
            this.splitListView.TabIndex = 3;
            this.splitListView.TabStop = false;
            // 
            // treeView
            // 
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imglstTreeView;
            this.treeView.Location = new System.Drawing.Point(0, 149);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(416, 679);
            this.treeView.TabIndex = 4;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize,
            this.colDateCreated,
            this.colDateModified});
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.imglstlarge;
            this.listView.Location = new System.Drawing.Point(422, 149);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(810, 679);
            this.listView.SmallImageList = this.imglstlarge;
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView_KeyPress);
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // imglstTreeView
            // 
            this.imglstTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstTreeView.ImageStream")));
            this.imglstTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstTreeView.Images.SetKeyName(0, "computer.png");
            this.imglstTreeView.Images.SetKeyName(1, "doc.png");
            this.imglstTreeView.Images.SetKeyName(2, "disk.png");
            this.imglstTreeView.Images.SetKeyName(3, "floppy.png");
            this.imglstTreeView.Images.SetKeyName(4, "download (1).png");
            this.imglstTreeView.Images.SetKeyName(5, "folder.png");
            this.imglstTreeView.Images.SetKeyName(6, "folder_open.png");
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 200;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSize.Width = 80;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Text = "Date Created";
            this.colDateCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDateCreated.Width = 100;
            // 
            // colDateModified
            // 
            this.colDateModified.Text = "Date Modified";
            this.colDateModified.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDateModified.Width = 100;
            // 
            // imglstlarge
            // 
            this.imglstlarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstlarge.ImageStream")));
            this.imglstlarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstlarge.Images.SetKeyName(0, "doc.png");
            this.imglstlarge.Images.SetKeyName(1, "pdf.png");
            this.imglstlarge.Images.SetKeyName(2, "txt.png");
            this.imglstlarge.Images.SetKeyName(3, "word.png");
            this.imglstlarge.Images.SetKeyName(4, "excel.png");
            this.imglstlarge.Images.SetKeyName(5, "ppt.png");
            this.imglstlarge.Images.SetKeyName(6, "exe.png");
            this.imglstlarge.Images.SetKeyName(7, "image.png");
            this.imglstlarge.Images.SetKeyName(8, "download.png");
            this.imglstlarge.Images.SetKeyName(9, "zip.png");
            this.imglstlarge.Images.SetKeyName(10, "download (2).png");
            this.imglstlarge.Images.SetKeyName(11, "folder.png");
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meuFile,
            this.menuEdit,
            this.viewMenu,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1232, 28);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // meuFile
            // 
            this.meuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRename,
            this.menuDelete,
            this.menuExit});
            this.meuFile.Name = "meuFile";
            this.meuFile.Size = new System.Drawing.Size(46, 24);
            this.meuFile.Text = "&File";
            this.meuFile.Click += new System.EventHandler(this.meuFile_Click);
            // 
            // menuRename
            // 
            this.menuRename.Name = "menuRename";
            this.menuRename.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuRename.Size = new System.Drawing.Size(224, 26);
            this.menuRename.Text = "&Rename";
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuDelete.Size = new System.Drawing.Size(224, 26);
            this.menuDelete.Text = "&Delete";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExit.Size = new System.Drawing.Size(224, 26);
            this.menuExit.Text = "E&xit";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCopy,
            this.menuCut,
            this.menuPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(49, 24);
            this.menuEdit.Text = "&Edit";
            // 
            // menuCopy
            // 
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.RightToLeftAutoMirrorImage = true;
            this.menuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuCopy.Size = new System.Drawing.Size(224, 26);
            this.menuCopy.Text = "&Copy";
            this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
            // 
            // menuCut
            // 
            this.menuCut.Name = "menuCut";
            this.menuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuCut.Size = new System.Drawing.Size(224, 26);
            this.menuCut.Text = "Cu&t";
            this.menuCut.Click += new System.EventHandler(this.menuCut_Click);
            // 
            // menuPaste
            // 
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuPaste.Size = new System.Drawing.Size(224, 26);
            this.menuPaste.Text = "&Paste";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLarge,
            this.menuSmall,
            this.menuList,
            this.menuDetails});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(55, 24);
            this.viewMenu.Text = "&View";
            // 
            // menuLarge
            // 
            this.menuLarge.Name = "menuLarge";
            this.menuLarge.Size = new System.Drawing.Size(224, 26);
            this.menuLarge.Text = "Lar&ge Icons";
            this.menuLarge.Click += new System.EventHandler(this.menuLarge_Click);
            // 
            // menuSmall
            // 
            this.menuSmall.Name = "menuSmall";
            this.menuSmall.Size = new System.Drawing.Size(224, 26);
            this.menuSmall.Text = "S&mall Icons";
            this.menuSmall.Click += new System.EventHandler(this.menuSmall_Click);
            // 
            // menuList
            // 
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(224, 26);
            this.menuList.Text = "&List";
            this.menuList.Click += new System.EventHandler(this.menuList_Click);
            // 
            // menuDetails
            // 
            this.menuDetails.Name = "menuDetails";
            this.menuDetails.Size = new System.Drawing.Size(224, 26);
            this.menuDetails.Text = "&Details";
            this.menuDetails.Click += new System.EventHandler(this.menuDetails_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(224, 26);
            this.menuAbout.Text = "A&bout";
            // 
            // toolbar
            // 
            this.toolbar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toolbar.Dock = System.Windows.Forms.DockStyle.None;
            this.toolbar.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnUp,
            this.tsbtnRefresh,
            this.tsbtnCopy,
            this.tsbtnCut,
            this.tsbtnPaste,
            this.tsbtnDelete,
            this.tsDropView});
            this.toolbar.Location = new System.Drawing.Point(0, 39);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(593, 42);
            this.toolbar.TabIndex = 7;
            this.toolbar.Text = "toolStrip1";
            // 
            // tsbtnUp
            // 
            this.tsbtnUp.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUp.Image")));
            this.tsbtnUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUp.Name = "tsbtnUp";
            this.tsbtnUp.Size = new System.Drawing.Size(67, 39);
            this.tsbtnUp.Text = "Up";
            this.tsbtnUp.Click += new System.EventHandler(this.tsbtnUp_Click);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(97, 39);
            this.tsbtnRefresh.Text = "Refresh";
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // tsbtnCopy
            // 
            this.tsbtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCopy.Image")));
            this.tsbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCopy.Name = "tsbtnCopy";
            this.tsbtnCopy.Size = new System.Drawing.Size(82, 39);
            this.tsbtnCopy.Text = "Copy";
            // 
            // tsbtnCut
            // 
            this.tsbtnCut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCut.Image")));
            this.tsbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCut.Name = "tsbtnCut";
            this.tsbtnCut.Size = new System.Drawing.Size(70, 39);
            this.tsbtnCut.Text = "Cut";
            // 
            // tsbtnPaste
            // 
            this.tsbtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPaste.Image")));
            this.tsbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPaste.Name = "tsbtnPaste";
            this.tsbtnPaste.Size = new System.Drawing.Size(82, 39);
            this.tsbtnPaste.Text = "Paste";
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(92, 39);
            this.tsbtnDelete.Text = "Delete";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // tsDropView
            // 
            this.tsDropView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuLarge,
            this.tsmenuSmall,
            this.tsmenuList,
            this.tsmenuDetails});
            this.tsDropView.Image = ((System.Drawing.Image)(resources.GetObject("tsDropView.Image")));
            this.tsDropView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropView.Name = "tsDropView";
            this.tsDropView.Size = new System.Drawing.Size(90, 39);
            this.tsDropView.Text = "View";
            // 
            // tsmenuLarge
            // 
            this.tsmenuLarge.Name = "tsmenuLarge";
            this.tsmenuLarge.Size = new System.Drawing.Size(224, 26);
            this.tsmenuLarge.Text = "Large Icons";
            this.tsmenuLarge.Click += new System.EventHandler(this.tsmenuLarge_Click);
            // 
            // tsmenuSmall
            // 
            this.tsmenuSmall.Name = "tsmenuSmall";
            this.tsmenuSmall.Size = new System.Drawing.Size(224, 26);
            this.tsmenuSmall.Text = "Small Icons";
            this.tsmenuSmall.Click += new System.EventHandler(this.tsmenuSmall_Click);
            // 
            // tsmenuList
            // 
            this.tsmenuList.Name = "tsmenuList";
            this.tsmenuList.Size = new System.Drawing.Size(224, 26);
            this.tsmenuList.Text = "List";
            this.tsmenuList.Click += new System.EventHandler(this.tsmenuList_Click);
            // 
            // tsmenuDetails
            // 
            this.tsmenuDetails.Name = "tsmenuDetails";
            this.tsmenuDetails.Size = new System.Drawing.Size(224, 26);
            this.tsmenuDetails.Text = "Details";
            this.tsmenuDetails.Click += new System.EventHandler(this.tsmenuDetails_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(32767, 347);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(0, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(32767, 372);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(0, 25);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(32767, 397);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1875, 431);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Location = new System.Drawing.Point(32767, 397);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(0, 25);
            this.toolStrip3.TabIndex = 11;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStrip4
            // 
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip4.Location = new System.Drawing.Point(32767, 422);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(0, 25);
            this.toolStrip4.TabIndex = 12;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStrip5
            // 
            this.toolStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip5.Location = new System.Drawing.Point(32767, 447);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(0, 25);
            this.toolStrip5.TabIndex = 13;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // tsPath
            // 
            this.tsPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tsPath.Dock = System.Windows.Forms.DockStyle.None;
            this.tsPath.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.tsPath.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscmbPath,
            this.tsbtnGo});
            this.tsPath.Location = new System.Drawing.Point(0, 87);
            this.tsPath.Name = "tsPath";
            this.tsPath.Size = new System.Drawing.Size(482, 42);
            this.tsPath.TabIndex = 14;
            this.tsPath.Text = "toolStrip1";
            // 
            // tscmbPath
            // 
            this.tscmbPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.tscmbPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tscmbPath.Name = "tscmbPath";
            this.tscmbPath.Size = new System.Drawing.Size(400, 42);
            this.tscmbPath.Tag = "tscmbPath";
            this.tscmbPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscmbPath_KeyPress);
            // 
            // tsbtnGo
            // 
            this.tsbtnGo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGo.Image")));
            this.tsbtnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGo.Name = "tsbtnGo";
            this.tsbtnGo.Size = new System.Drawing.Size(67, 39);
            this.tsbtnGo.Text = "Go";
            this.tsbtnGo.Click += new System.EventHandler(this.tsbtnGo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 828);
            this.Controls.Add(this.tsPath);
            this.Controls.Add(this.toolStrip5);
            this.Controls.Add(this.toolStrip4);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.splitListView);
            this.Controls.Add(this.splitTreeView);
            this.Controls.Add(this.splitMenu);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Explorer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.tsPath.ResumeLayout(false);
            this.tsPath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitMenu;
        private System.Windows.Forms.Splitter splitTreeView;
        private System.Windows.Forms.Splitter splitListView;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imglstTreeView;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colDateCreated;
        private System.Windows.Forms.ColumnHeader colDateModified;
        private System.Windows.Forms.ImageList imglstlarge;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem meuFile;
        private System.Windows.Forms.ToolStripMenuItem menuRename;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuCut;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem menuLarge;
        private System.Windows.Forms.ToolStripMenuItem menuSmall;
        private System.Windows.Forms.ToolStripMenuItem menuList;
        private System.Windows.Forms.ToolStripMenuItem menuDetails;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton tsbtnUp;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnCopy;
        private System.Windows.Forms.ToolStripButton tsbtnCut;
        private System.Windows.Forms.ToolStripButton tsbtnPaste;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripDropDownButton tsDropView;
        private System.Windows.Forms.ToolStripMenuItem tsmenuLarge;
        private System.Windows.Forms.ToolStripMenuItem tsmenuSmall;
        private System.Windows.Forms.ToolStripMenuItem tsmenuList;
        private System.Windows.Forms.ToolStripMenuItem tsmenuDetails;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStrip tsPath;
        private System.Windows.Forms.ToolStripTextBox tscmbPath;
        private System.Windows.Forms.ToolStripButton tsbtnGo;
    }
}

