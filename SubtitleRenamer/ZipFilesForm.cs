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
            zipListBox.Items.AddRange(zipFiles.ToArray());
        }

        private void subtitleSelected()
        {
            if (zipListBox.Items.Count == 0)
            {
                MessageBox.Show("자막 파일을 선택하세요");
                return;
            }

            selectedSubtitleFileName = zipListBox.SelectedItem.ToString();
            ok = true;
            this.Close();
        }

        private void zipListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            subtitleSelected();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subtitleSelected();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ok = false;
            this.Close();
        }
    }
}
