using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp09
{
    public partial class Form1 : Form
    {
        private System.Collections.Specialized.StringCollection folderCol;
        public Form1()
        {
            InitializeComponent();
            folderCol = new System.Collections.Specialized.StringCollection();  
            CreateHeadersAndFillListView();
            PaintListView(@"C:\");
            folderCol.Add(@"C:\");

        }

        private void PaintListView(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;
                if (root.CompareTo("") == 0) return;

                DirectoryInfo dir = new DirectoryInfo(root);


                DirectoryInfo[] dirs = dir.GetDirectories();

                FileInfo[] files = dir.GetFiles();

                listViewFilesAndFolders.Items.Clear();

                labelCurrentPath.Text = root;

                listViewFilesAndFolders.BeginUpdate();

                foreach (var di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    lvi.ImageIndex = 0;

                    

                    lvi.Tag = di.FullName;

                    lvsi = new ListViewItem.ListViewSubItem();

                    lvsi.Text = "";

                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();

                    lvsi.Text = di.LastAccessTime.ToString();
                   

                    lvi.SubItems.Add(lvsi);

                    listViewFilesAndFolders.Items.Add(lvi);


                }

                foreach (var fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.ImageIndex = 1;



                    lvi.Tag = fi.FullName;

                    lvsi = new ListViewItem.ListViewSubItem();

                    lvsi.Text = fi.Length.ToString();

                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();

                    lvsi.Text = fi.LastAccessTime.ToString();


                    lvi.SubItems.Add(lvsi);

                    listViewFilesAndFolders.Items.Add(lvi);


                }


                listViewFilesAndFolders.EndUpdate();

            }
            catch (Exception err)
            {
                MessageBox.Show("Грешка: " + err.Message);
            }
        
        
        }




        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;

            colHead = new ColumnHeader();

            colHead.Text = "Папки/Файлове";

            colHead.Width = 200;

            listViewFilesAndFolders.Columns.Add(colHead);


            colHead = new ColumnHeader();

            colHead.Text = "Размер";

            colHead.Width = 100;

            listViewFilesAndFolders.Columns.Add(colHead);


            colHead = new ColumnHeader();

            colHead.Text = "Последна модификация";

            colHead.Width = 200;

            listViewFilesAndFolders.Columns.Add(colHead);



        }

        private void listViewFilesAndFolders_ItemActivate(object sender, EventArgs e)
        {
            ListView lw = (ListView)sender;

            string fileName = lw.SelectedItems[0].Tag.ToString();

            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    Process.Start(fileName);
                }
                catch 
                {

                    return;
                }
            }
            else
            {
                PaintListView(fileName);
                folderCol.Add(fileName);
            }
        
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderCol.Count > 1)
            {
                PaintListView(folderCol[folderCol.Count - 2].ToString());

                folderCol.RemoveAt(folderCol.Count - 1);
            }
            else
            {
                PaintListView(folderCol[0].ToString());
            }


        }

        private void radioButtonLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;

            if (rdb.Checked)
                listViewFilesAndFolders.View = View.LargeIcon;
        }

        private void radioButtonSmallICon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;

            if (rdb.Checked)
                listViewFilesAndFolders.View = View.SmallIcon;
        }

        private void radioButtonList_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;

            if (rdb.Checked)
                listViewFilesAndFolders.View = View.List;
        }

        private void radioButtonDetails_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;

            if (rdb.Checked)
                listViewFilesAndFolders.View = View.Details;
        }

        private void radioButtonTile_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;

            if (rdb.Checked)
                listViewFilesAndFolders.View = View.Tile;
        }
    }
}
