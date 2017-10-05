using System;
using System.Windows.Forms;
using System.IO;

namespace SubtitleRename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "모든 파일|*.*";
            openFileDialog1.Title = "동영상 파일을 선택하세요";
            openFileDialog1.Multiselect = true;

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    listBox1.Items.Add(file);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0 ; i--)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "모든 파일|*.*";
            openFileDialog1.Title = "자막 파일을 선택하세요";
            openFileDialog1.Multiselect = true;

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    listBox2.Items.Add(file);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("동영상 파일이 없습니다");
                return;
            }
            else if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("자막 파일이 없습니다");
            }
            else if (listBox1.Items.Count != listBox2.Items.Count)
            {
                MessageBox.Show("동영상과 자막 파일 개수는 동일해야 합니다");
                return;
            }

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                DialogResult dr;
                String movieFileName = listBox1.Items[i].ToString();
                String subtitleFileName = listBox2.Items[i].ToString();
                String subtitleNewFileName = Path.Combine(Path.GetDirectoryName(movieFileName),
                    Path.GetFileNameWithoutExtension(movieFileName) + "." + Path.GetExtension(subtitleFileName));
                if (File.Exists(subtitleNewFileName))
                {
                    dr = MessageBox.Show(String.Format("자막 파일 {0}이 이미 존재합니다. 덮어 쓸까요?", Path.GetFileName(subtitleNewFileName)), "", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Cancel)
                    {

                        MessageBox.Show("변환을 취소했습니다");
                        return;
                    }
                    else if (dr == DialogResult.No)
                    {
                        continue;
                    }
                }
                File.Copy(subtitleFileName, subtitleNewFileName, true);
                File.Delete(subtitleFileName);
            }

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            MessageBox.Show("변환이 완료됐습니다");
        }
    }
}
