using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Diagnostics;

namespace WindowExplorer
{
    public partial class FormMain : Form
    {
        private bool isCopying = false;
        private bool isFolder = false;
        private bool isListView = false;
        private bool isCutting = false;
        private ListViewItem itemPaste;
        private string pathFolder;
        private string pathFile;
        private string currentPath;


        private ClsTreeListView clsTreeListView = new ClsTreeListView();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            clsTreeListView.CreateTreeView(this.treeView);
            tscmbPath.Width = this.Width - 120;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode currentNode = e.Node;
            if (currentNode.Text != "My Computer")
            {
                clsTreeListView.ShowFolderTree(this.treeView, this.listView, currentNode);

                tscmbPath.Text = clsTreeListView.GetFullPath(currentNode.FullPath);
            }
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listView.FocusedItem;

            bool isOK = clsTreeListView.ClickItem(this.listView, item);
            if (isOK)
            {
                if (item.SubItems[1].Text == "Folder")
                {
                    tscmbPath.Text = item.SubItems[4].Text + "\\";
                }
            }
            clsTreeListView.ClickItem(this.listView, item);
        }

        private void listView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ListViewItem item = this.listView.FocusedItem;
                clsTreeListView.ClickItem(this.listView, item);
            }
        }

        private void meuFile_Click(object sender, EventArgs e)
        {

        }

        //Copy click
        private void menuCopy_Click(object sender, EventArgs e)
        {
            isCopying = true;
            if (listView.Focused)
            {
                isListView = true;
                itemPaste = listView.FocusedItem;
                if (itemPaste == null)
                {
                    return;
                }
                if (itemPaste.SubItems[1].Text.Trim() == "Folder")
                {
                    isFolder = true;
                    pathFolder = itemPaste.SubItems[4].Text + "\\";
                }
                else
                {
                    isFolder = false;
                    pathFile = itemPaste.SubItems[4].Text;
                }
            }
            else if (treeView.Focused)
            {
                isListView = false;
                isFolder = true;
            }
            menuPaste.Enabled = true;
            tsbtnPaste.Enabled = true;
        }

        // Cut click
        private void menuCut_Click(object sender, EventArgs e)
        {
            isCutting = true;
            if (listView.Focused)
            {
                isListView = true;
                itemPaste = listView.FocusedItem;
                //itemPaste.ForeColor = Color.LightGray;
                

                if (itemPaste.SubItems[1].Text.Trim() == "Folder")
                {
                    isFolder = true;
                    pathFolder = itemPaste.SubItems[4].Text + "\\";
                }
                else
                {
                    isFolder = false;
                    pathFile = itemPaste.SubItems[4].Text;
                }
            }
            else if (treeView.Focused)
            {
                isListView = false;
                isFolder = true;
            }
            menuPaste.Enabled = true;
            tsbtnPaste.Enabled = true;
        }
        private void tsbtnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if(tscmbPath.Text != "")
                {
                    bool isOK;
                    FileInfo f = new FileInfo(tscmbPath.Text.Trim());
                    if (f.Exists)
                    {
                        System.Diagnostics.Process.Start(tscmbPath.Text.Trim());
                        DirectoryInfo parent = f.Directory;
                        tscmbPath.Text = parent.FullName;
                        return;
                    }
                    else
                    {
                        isOK = clsTreeListView.ShowContent(listView, tscmbPath.Text);
                    }

                    if (isOK)
                    {
                        currentPath = tscmbPath.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tscmbPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                clsTreeListView.ShowContent(this.listView, tscmbPath.Text);
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.Focused)
                {
                    ListViewItem item = new ListViewItem();
                    item = listView.FocusedItem;
                    clsTreeListView.DeleteItem(listView, item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            menuDelete.PerformClick();
        }

        private void tsbtnUp_Click(object sender, EventArgs e)
        {
            try
            {
                string path = currentPath;
                if (path != "")
                {
                    if (path.LastIndexOf(":\\") != path.Length - 2 && path.LastIndexOf("\\") == path.Length - 1)
                    {
                        path = path.Remove(path.Length - 1);
                    }
                    string parentDir = clsTreeListView.GetPathDir(path);
                    tscmbPath.Text = parentDir;
                    currentPath = parentDir;
                    clsTreeListView.ShowContent(listView, parentDir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            if (currentPath != "")
            {
                clsTreeListView.ShowContent(listView, currentPath);
            }
        }

        private void tsmenuLarge_Click(object sender, EventArgs e)
        {
            listView.View = View.LargeIcon;
        }

        private void tsmenuSmall_Click(object sender, EventArgs e)
        {
            listView.View = View.SmallIcon;
        }

        private void tsmenuList_Click(object sender, EventArgs e)
        {
            listView.View = View.List;
        }

        private void tsmenuDetails_Click(object sender, EventArgs e)
        {
            listView.View = View.Details;
        }

        private void menuLarge_Click(object sender, EventArgs e)
        {
            tsmenuLarge.PerformClick();
        }

        private void menuSmall_Click(object sender, EventArgs e)
        {
            tsmenuSmall.PerformClick();
        }

        private void menuList_Click(object sender, EventArgs e)
        {
            tsmenuList.PerformClick();
        }

        private void menuDetails_Click(object sender, EventArgs e)
        {
            tsmenuDetails.PerformClick();
        }
    }
}
