using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acadPurgeBind
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.tabPage2.Enabled = false;
        }

        private void MainFormTab_Selecting(object sender, TabControlCancelEventArgs  e)
        {
            e.Cancel = !e.TabPage.Enabled;
        }

        private void SelectFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowser = new FolderBrowserDialog();
            DialogResult res = FolderBrowser.ShowDialog();

            if (res == DialogResult.OK)
            {
                MessageBox.Show ("Folder selected!");
                this.SelectFolderTxtBox.Text = FolderBrowser.SelectedPath.ToString();
                // TODO validate the folder chosen
                // TODO add the list of folders in the folder chosen to a collection


            }
        }
    }
}
