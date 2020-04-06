namespace FileExplorer2
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.fileTreeView = new System.Windows.Forms.TreeView();
            this.fileListView = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.fileTreeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.fileListView);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 228;
            this.splitContainer.TabIndex = 0;
            this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder");
            this.imageList.Images.SetKeyName(1, "document");
            // 
            // fileTreeView
            // 
            this.fileTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileTreeView.ImageIndex = 0;
            this.fileTreeView.ImageList = this.imageList;
            this.fileTreeView.Location = new System.Drawing.Point(0, 0);
            this.fileTreeView.Name = "fileTreeView";
            this.fileTreeView.SelectedImageIndex = 0;
            this.fileTreeView.Size = new System.Drawing.Size(228, 450);
            this.fileTreeView.TabIndex = 0;
            this.fileTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.fileTreeView_NodeMouseClick);
            // 
            // fileListView
            // 
            this.fileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Type,
            this.LastModified});
            this.fileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListView.HideSelection = false;
            this.fileListView.Location = new System.Drawing.Point(0, 0);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(568, 450);
            this.fileListView.SmallImageList = this.imageList;
            this.fileListView.TabIndex = 0;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            this.fileListView.View = System.Windows.Forms.View.Details;
            this.fileListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileListView_MouseDoubleClick);
            // 
            // FileName
            // 
            this.FileName.Text = "Имя";
            this.FileName.Width = 170;
            // 
            // Type
            // 
            this.Type.Text = "Тип";
            this.Type.Width = 95;
            // 
            // LastModified
            // 
            this.LastModified.Text = "Дата изменения";
            this.LastModified.Width = 119;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "mainForm";
            this.Text = "File Explorer";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView fileTreeView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader LastModified;
    }
}

