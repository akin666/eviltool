namespace EvilTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tree = new System.Windows.Forms.TreeView();
            this.fileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.treemenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.new_item = new System.Windows.Forms.ToolStripMenuItem();
            this.containerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.containerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.layerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.fileMenuStrip.SuspendLayout();
            this.treemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.containerMenu.SuspendLayout();
            this.layerMenu.SuspendLayout();
            this.basicMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.tree);
            this.splitContainer1.Panel1.Controls.Add(this.fileMenuStrip);
            this.splitContainer1.Size = new System.Drawing.Size(524, 338);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 3;
            // 
            // tree
            // 
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.Location = new System.Drawing.Point(0, 24);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(200, 314);
            this.tree.TabIndex = 0;
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.helpMenu});
            this.fileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.Size = new System.Drawing.Size(200, 24);
            this.fileMenuStrip.TabIndex = 1;
            this.fileMenuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileMenu,
            this.saveAsFileMenu,
            this.exitFileMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // loadFileMenu
            // 
            this.loadFileMenu.Name = "loadFileMenu";
            this.loadFileMenu.Size = new System.Drawing.Size(152, 22);
            this.loadFileMenu.Text = "Load";
            this.loadFileMenu.Click += new System.EventHandler(this.loadFileMenu_Click);
            // 
            // saveAsFileMenu
            // 
            this.saveAsFileMenu.Name = "saveAsFileMenu";
            this.saveAsFileMenu.Size = new System.Drawing.Size(152, 22);
            this.saveAsFileMenu.Text = "Save as";
            this.saveAsFileMenu.Click += new System.EventHandler(this.saveAsFileMenu_Click);
            // 
            // exitFileMenu
            // 
            this.exitFileMenu.Name = "exitFileMenu";
            this.exitFileMenu.Size = new System.Drawing.Size(152, 22);
            this.exitFileMenu.Text = "Exit";
            this.exitFileMenu.Click += new System.EventHandler(this.exitApplication);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // treemenu
            // 
            this.treemenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_item});
            this.treemenu.Name = "treemenu";
            this.treemenu.Size = new System.Drawing.Size(97, 26);
            this.treemenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // new_item
            // 
            this.new_item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.containerToolStripMenuItem});
            this.new_item.Name = "new_item";
            this.new_item.Size = new System.Drawing.Size(96, 22);
            this.new_item.Text = "new";
            // 
            // containerToolStripMenuItem
            // 
            this.containerToolStripMenuItem.Name = "containerToolStripMenuItem";
            this.containerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.containerToolStripMenuItem.Text = "container";
            this.containerToolStripMenuItem.Click += new System.EventHandler(this.createContainer);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // containerMenu
            // 
            this.containerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.removeToolStripMenuItem1});
            this.containerMenu.Name = "containerMenu";
            this.containerMenu.Size = new System.Drawing.Size(115, 48);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layerToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "new";
            // 
            // layerToolStripMenuItem
            // 
            this.layerToolStripMenuItem.Name = "layerToolStripMenuItem";
            this.layerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.layerToolStripMenuItem.Text = "layer";
            this.layerToolStripMenuItem.Click += new System.EventHandler(this.createLayer);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.removeToolStripMenuItem1.Text = "remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeNode);
            // 
            // layerMenu
            // 
            this.layerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.removeToolStripMenuItem});
            this.layerMenu.Name = "layerMenu";
            this.layerMenu.Size = new System.Drawing.Size(115, 48);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.pointToolStripMenuItem,
            this.polygonToolStripMenuItem});
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem1.Text = "new";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.textToolStripMenuItem.Text = "text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.createText);
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pointToolStripMenuItem.Text = "point";
            this.pointToolStripMenuItem.Click += new System.EventHandler(this.createPoint);
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.polygonToolStripMenuItem.Text = "polygon";
            this.polygonToolStripMenuItem.Click += new System.EventHandler(this.createPolygon);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.removeToolStripMenuItem.Text = "remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeNode);
            // 
            // basicMenu
            // 
            this.basicMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem2});
            this.basicMenu.Name = "basicMenu";
            this.basicMenu.Size = new System.Drawing.Size(115, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.editToolStripMenuItem.Text = "edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editNode);
            // 
            // removeToolStripMenuItem2
            // 
            this.removeToolStripMenuItem2.Name = "removeToolStripMenuItem2";
            this.removeToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.removeToolStripMenuItem2.Text = "remove";
            this.removeToolStripMenuItem2.Click += new System.EventHandler(this.removeNode);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(524, 338);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.fileMenuStrip;
            this.Name = "MainWindow";
            this.Text = "Evil Editor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.fileMenuStrip.ResumeLayout(false);
            this.fileMenuStrip.PerformLayout();
            this.treemenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.containerMenu.ResumeLayout(false);
            this.layerMenu.ResumeLayout(false);
            this.basicMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip treemenu;
        private System.Windows.Forms.ToolStripMenuItem new_item;
        private System.Windows.Forms.ToolStripMenuItem containerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip fileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem loadFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip containerMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip layerMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip basicMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem2;
    }
}

