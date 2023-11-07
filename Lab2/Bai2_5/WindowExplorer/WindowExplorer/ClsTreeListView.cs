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
    class ClsTreeListView
    {
        public void CreateTreeView(TreeView treeView)
        {
            TreeNode tnMyComputer;
            const int RemovableDisk = 2;
            const int LocalDisk = 3;
            const int NetWorkDisk = 4;
            const int CDDisk = 5;
            //new Tree Node
            tnMyComputer = new TreeNode("My Computer", 0, 0);

            //Delete tree view
            treeView.Nodes.Clear();
            treeView.Nodes.Add(tnMyComputer);

            //Collect node
            TreeNodeCollection nodeCollection = tnMyComputer.Nodes;

            //Colect disk
            ManagementObjectSearcher query = new ManagementObjectSearcher("Select * From Win32_LogicalDisk");
            ManagementObjectCollection queryCollection = query.Get();
            foreach (ManagementObject mo in queryCollection)
            {
                TreeNode diskTreeNode;
                int imageIndex, selectIndex;

                switch (int.Parse(mo["DriveType"].ToString()))
                {
                    case RemovableDisk:
                        imageIndex = 1;
                        selectIndex = 1;
                        break;
                    case LocalDisk:
                        imageIndex = 2;
                        selectIndex = 2;
                        break;
                    case CDDisk:
                        imageIndex = 3;
                        selectIndex = 3;
                        break;
                    case NetWorkDisk:
                        imageIndex = 4;
                        selectIndex = 4;
                        break;
                    default:
                        imageIndex = 5;
                        selectIndex = 6;
                        break;
                }
                //Create tree node for each disk
                diskTreeNode = new TreeNode(mo["Name"].ToString() + "\\", imageIndex, selectIndex);

                nodeCollection.Add(diskTreeNode);
            }
        }

        public bool ShowFolderTree(TreeView treeView, ListView listView, TreeNode currentNode)
        {
            if (currentNode.Text != "My Computer")
            {
                try
                {
                    //Check path
                    if (Directory.Exists(GetFullPath(currentNode.FullPath)) == false)
                    {
                        MessageBox.Show("Disk or folder not exists");
                    }
                    else
                    {
                        string[] strDirectories = Directory.GetDirectories(GetFullPath(currentNode.FullPath));
                        //Collect infomation of folder
                        foreach (string stringDir in strDirectories)
                        {
                            string strName = GetName(stringDir);
                            TreeNode nodeDir;
                            nodeDir = new TreeNode(strName, 5, 6);
                            currentNode.Nodes.Add(nodeDir);
                        }
                        ShowContent(listView, currentNode);
                    }
                    return true;
                }
                catch (IOException)
                {
                    MessageBox.Show("Disk or folder not exists");
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You don't have access rights");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return false;
        }

        public string GetFullPath(string strPath)
        {
            return strPath.Replace("My Computer\\", "").Replace("\\\\", "\\");
        }

        public string GetName(string strPath)
        {
            string[] strSplit = strPath.Split('\\');
            int MaxIndex = strSplit.Length;
            return strSplit[MaxIndex - 1];
        }

        public bool ShowContent(ListView listView, string strPath)
        {
            try
            {
                if (!strPath.EndsWith("\\"))
                {
                    strPath += "\\";
                }
                ListViewItem item;
                DirectoryInfo directory = new DirectoryInfo(strPath);
                if (!directory.Exists)
                {
                    MessageBox.Show("Folder is not exist");
                    return false;
                }

                listView.Items.Clear();
                foreach(DirectoryInfo folder in directory.GetDirectories())
                {
                    item = GetLVItems(folder);
                    listView.Items.Add(item);
                }
                foreach(FileInfo file in directory.GetFiles())
                {
                    item = GetLVItems(file);
                    listView.Items.Add(item);
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return false;
        }
        public void ShowContent(ListView listView, TreeNode currentNode)
        {
            try
            {
                //Delete item ListView
                listView.Items.Clear();
                ListViewItem item;
                DirectoryInfo directory = GetPathDir(currentNode);

                //Folder information
                foreach(DirectoryInfo folder in directory.GetDirectories())
                {
                    item = GetLVItems(folder);
                    listView.Items.Add(item);
                }

                //File infomation
                foreach(FileInfo file in directory.GetFiles())
                {
                    item = GetLVItems(file);
                    listView.Items.Add(item);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public ListViewItem GetLVItems(DirectoryInfo folder)
        {
            string[] item = new string[5];
            item[0] = folder.Name;
            item[1] = "Folder";
            item[2] = folder.CreationTime.ToString();
            item[3] = folder.LastWriteTime.ToString();
            item[4] = folder.FullName;

            ListViewItem LVItem = new ListViewItem(item);
            LVItem.ImageIndex = 13;
            return LVItem;
        }

        public ListViewItem GetLVItems(FileInfo file)
        {
            long size = 0;
            string[] s = { file.Name, file.Extension.ToUpper(), size + "KB", file.LastWriteTime.ToString(), file.FullName, file.Directory.FullName };
            string[] item = new string[5];
            item[0] = file.Name;
            item[1] = (file.Length/1024).ToString()+" KB";
            item[2] = file.CreationTime.ToString();
            item[3] = file.LastWriteTime.ToString();
            item[4] = file.FullName;

            ListViewItem LVitem = new ListViewItem(item);
            LVitem.ImageIndex = GetImageIndex(file);
            return LVitem;
        }

        public DirectoryInfo GetPathDir(TreeNode currentNode)
        {
            string[] strList = currentNode.FullPath.Split('\\');
            string strPath = strList.GetValue(1).ToString();
            for (int i = 2; i < strList.Length; i++)
            {
                strPath += strList.GetValue(i) + "\\";
            }
            return new DirectoryInfo(strPath);
        }

        public string GetPathDir(string path)
        {
            string[] strList = path.Split('\\');
            string strPath = strList.GetValue(1).ToString();
            for (int i = 2; i < strList.Length; i++)
            {
                strPath += strList.GetValue(i) + "\\";
            }
            return strPath;
        }

        public int GetImageIndex(FileInfo file)
        {
            switch (file.Extension.ToUpper())
            {
                case ".TXT":
                case ".DIZ":
                case ".LOG":
                    return 0;

                case ".PDF":
                    return 1;

                case ".HTML.":
                case ".HTM":
                    return 2;

                case ".DOC":
                case ".DOCX":
                    return 3;

                case ".XLS":
                case ".XLSX":
                    return 4;

                case ".PPT":
                case ".PPTX":
                    return 5;

                case ".EXE":
                    return 6;

                case ".JPG":
                case ".PNG":
                case ".GIF":
                    return 7;

                case ".MP3":
                case ".WAV":
                case ".WMV":
                case ".ASF":
                case ".MPEG":
                case ".AVI":
                    return 8;

                case ".ZIP":
                case ".RAR":
                    return 9;

                case ".SWF":
                case ".FLV":
                case ".FLA":
                    return 10;

                default:
                    return 11;
            }
        }

        public bool ClickItem(ListView listView, ListViewItem LVItem)
        {
            try
            {
                string path = LVItem.SubItems[4].Text;
                FileInfo fi = new FileInfo(path);
                if (fi.Exists)
                {
                    Process.Start(path);
                }
                else
                {
                    ListViewItem item;
                    DirectoryInfo directory = new DirectoryInfo(path + "\\");
                    if (!directory.Exists)
                    {
                        MessageBox.Show("File or folder not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    //Delete list view
                    listView.Items.Clear();

                    //Folder infor
                    foreach (DirectoryInfo folder in directory.GetDirectories())
                    {
                        item = GetLVItems(folder);
                        listView.Items.Add(item);
                    }

                    //File info
                    foreach (FileInfo file in directory.GetFiles())
                    {
                        item = GetLVItems(file);
                        listView.Items.Add(item);
                    }

                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return false;
        }

        public void DeleteItem(ListView listView, ListViewItem LVitem)
        {
            try
            {
                string path = LVitem.SubItems[4].Text;
                if (LVitem.SubItems[1].Text == "Folder")
                {
                    DirectoryInfo directory = new DirectoryInfo(path + "\\");
                    if (!directory.Exists)
                    {
                        MessageBox.Show("Not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Do you want delete this folder?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dialog == DialogResult.Yes)
                        {
                            directory.Delete(true);
                        }
                        else return;
                       
                    }
                }
                else
                {
                    FileInfo file = new FileInfo(path);
                    if (!file.Exists)
                    {
                        MessageBox.Show("Not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Do you want delete this file?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dialog == DialogResult.Yes)
                        {
                            file.Delete();
                        }
                        else return;

                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }

}
