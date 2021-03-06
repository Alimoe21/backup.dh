﻿namespace Backup.Gui
{
    partial class ExplorerList
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerList));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.explorerListView = new Backup.Gui.ExplorerListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Hard_Drive.png");
            this.imageList1.Images.SetKeyName(1, "FolderOpen_16x16_72.png");
            this.imageList1.Images.SetKeyName(2, "Hard_Drive.png");
            // 
            // explorerListView
            // 
            resources.ApplyResources(this.explorerListView, "explorerListView");
            this.explorerListView.CheckBoxes = true;
            this.explorerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.explorerListView.FullRowSelect = true;
            this.explorerListView.Name = "explorerListView";
            this.explorerListView.SmallImageList = this.imageList1;
            this.explorerListView.UseCompatibleStateImageBehavior = false;
            this.explorerListView.View = System.Windows.Forms.View.Details;
            this.explorerListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.explorerListView_ColumnClick);
            this.explorerListView.DoubleClick += new System.EventHandler(this.explorerListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "Name";
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "LastWriteTime";
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // ExplorerList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.explorerListView);
            this.Name = "ExplorerList";
            this.ResumeLayout(false);

        }

        #endregion

        private Backup.Gui.ExplorerListView explorerListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
