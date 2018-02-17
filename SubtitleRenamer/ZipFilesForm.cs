using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubtitleRenamer
{
    public partial class ZipFilesForm : Form
    {
        private List<string> zipFiles;
        public string selectedSubtitleFileName;
        public bool ok;

        public ZipFilesForm(List<string> zipFiles)
        {
            InitializeComponent();
            this.zipFiles = zipFiles;
        }

        private void ZipFilesForm_Load(object sender, EventArgs e)
        {
            ZipListBox.Items.AddRange(zipFiles.ToArray());
        }

        private void SubtitleSelected()
        {
            if (ZipListBox.Items.Count == 0)
            {
                MessageBox.Show("자막 파일을 선택하세요");
                return;
            }

            selectedSubtitleFileName = ZipListBox.SelectedItem.ToString();
            ok = true;
            this.Close();
        }

        private void ZipListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SubtitleSelected();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SubtitleSelected();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ok = false;
            this.Close();
        }
    }
}
