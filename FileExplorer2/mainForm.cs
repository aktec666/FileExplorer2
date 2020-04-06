using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FileExplorer2
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            PopulateFileTreeView();
        }

        public void GetDirectories(DirectoryInfo[] subDirs, TreeNode node)
        {
            TreeNode tempNode;
            DirectoryInfo[] subSubDirs;

            foreach (var subDir in subDirs)
            {
                tempNode = new TreeNode(subDir.Name, 0, 0);
                tempNode.Tag = subDir;
                subSubDirs = subDir.GetDirectories();
                if(subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, tempNode);
                }
                node.Nodes.Add(tempNode);
            }
        }

        public void PopulateFileTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../..");
         

            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;

                GetDirectories(info.GetDirectories(), rootNode);
                fileTreeView.Nodes.Add(rootNode);
            }

        }



        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void fileTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            fileListView.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)selectedNode.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item;

            foreach(var dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
              
                subItems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item, "Папка"),
                        new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString())
                    };

                item.SubItems.AddRange(subItems);
                fileListView.Items.Add(item);
            }

            foreach (var file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                item.Tag = file.FullName;

                subItems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item, "Файл"),
                        new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString())
                    };
                item.SubItems.AddRange(subItems);
                fileListView.Items.Add(item);
            }
        }


        private void fileListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = fileListView.SelectedItems[0];
            if (item.Tag != null)
            {
                Process.Start(item.Tag.ToString());
            }
        }
    }
}
