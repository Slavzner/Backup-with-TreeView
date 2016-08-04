using System;
using System.IO;
using System.Windows.Forms;

namespace GuiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            ListDirectory(sourceView, folderBrowser.SelectedPath);
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directInfo)
        {
            var directoryNode = new TreeNode(directInfo.Name);
            foreach (var directory in directInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
           // foreach (var file in directInfo.GetFiles())
             //   directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }

        private void sourceView_AfterSelect(object sender, TreeViewEventArgs e)
        {
           // sourceView.Nodes.
        }
    }
}
