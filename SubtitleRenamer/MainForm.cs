using System;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

using static SubtitleRenamer.NativeMethods;

namespace SubtitleRenamer
{
    public partial class MainForm : Form
    {
        enum Result
        {
            Continue,
            Return,
            Ok
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddFileButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "모든 파일|*.*";
            openFileDialog1.Title = "동영상 파일을 선택하세요";
            openFileDialog1.Multiselect = true;

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    MovieListBox.Items.Add(file);
                }
                if (checkedListBox1.GetItemChecked(1))
                {
                    SortListBoxItems(ref MovieListBox);
                }
            }
        }

        private void DeleteAllButton1_Click(object sender, EventArgs e)
        {
            MovieListBox.Items.Clear();
        }

        private void DeleteFileButton1_Click(object sender, EventArgs e)
        {
            for (int i = MovieListBox.SelectedIndices.Count - 1; i >= 0; i--)
            {
                MovieListBox.Items.RemoveAt(MovieListBox.SelectedIndices[i]);
            }
        }

        private void AddFileButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "모든 파일|*.*";
            openFileDialog1.Title = "자막 파일을 선택하세요";
            openFileDialog1.Multiselect = true;

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    SubtitleListBox.Items.Add(file);
                }
                if (checkedListBox1.GetItemChecked(1))
                {
                    SortListBoxItems(ref SubtitleListBox);
                }
            }
        }

        private void DeleteAllButton2_Click(object sender, EventArgs e)
        {
            SubtitleListBox.Items.Clear();
        }

        private void DeleteFileButton2_Click(object sender, EventArgs e)
        {
            for (int i = SubtitleListBox.SelectedIndices.Count - 1; i >= 0; i--)
            {
                SubtitleListBox.Items.RemoveAt(SubtitleListBox.SelectedIndices[i]);
            }
        }

        private Result GetSubtitleFileFromZip(ref string subtitleFileName, ref string subtitleNewFileName)
        {
            try
            {
                using (ZipArchive archive = ZipFile.Open(subtitleFileName, ZipArchiveMode.Read))
                {
                    List<string> zipFileNames = new List<string>();
                    string selectedSubtitleFileName;
                    foreach (var entry in archive.Entries)
                    {
                        zipFileNames.Add(entry.FullName);
                    }

                    if (zipFileNames.Count() != 1)
                    {
                        ZipFilesForm zipFilesForm = new ZipFilesForm(zipFileNames);
                        zipFilesForm.ShowDialog();

                        if (!zipFilesForm.ok)
                        {
                            return Result.Continue;
                        }

                        selectedSubtitleFileName = zipFilesForm.selectedSubtitleFileName;
                    }
                    else
                    {
                        selectedSubtitleFileName = zipFileNames[0];
                    }

                    string selectedFileExtension = Path.GetExtension(selectedSubtitleFileName);
                    subtitleFileName = Path.Combine(Path.GetTempPath(),
                        Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + selectedFileExtension);
                    archive.GetEntry(selectedSubtitleFileName).ExtractToFile(subtitleFileName);
                    subtitleNewFileName = Path.Combine(Path.GetDirectoryName(subtitleNewFileName),
                        Path.GetFileNameWithoutExtension(subtitleNewFileName) + selectedFileExtension);
                }
            }
            catch
            {
                MessageBox.Show("Zip 파일 형식이 잘못됐습니다");
                return Result.Continue;
            }
            return Result.Ok;
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> deletedSubtitles = new Dictionary<string, string>();

            if (MovieListBox.Items.Count == 0)
            {
                MessageBox.Show("동영상 파일이 없습니다");
                return;
            }
            else if (SubtitleListBox.Items.Count == 0)
            {
                MessageBox.Show("자막 파일이 없습니다");
                return;
            }
            else if (MovieListBox.Items.Count != SubtitleListBox.Items.Count)
            {
                MessageBox.Show("동영상과 자막 파일 개수는 동일해야 합니다");
                return;
            }

            for (int i = 0; i < MovieListBox.Items.Count; i++)
            {
                DialogResult dr;
                string movieFileName = MovieListBox.Items[i].ToString();
                string subtitleFileName = SubtitleListBox.Items[i].ToString();
                string subtitleNewFileName = Path.Combine(Path.GetDirectoryName(movieFileName),
                    Path.GetFileNameWithoutExtension(movieFileName) + Path.GetExtension(subtitleFileName));

                if (Path.GetExtension(subtitleFileName).ToLower() == ".zip")
                {
                    if (GetSubtitleFileFromZip(ref subtitleFileName, ref subtitleNewFileName) == Result.Continue)
                    {
                        continue;
                    }
                }

                if (subtitleFileName == subtitleNewFileName)
                {
                    continue;
                }
                if (File.Exists(subtitleNewFileName))
                {
                    dr = MessageBox.Show(string.Format("자막 파일 {0}이 이미 존재합니다. 덮어 쓸까요?",
                        Path.GetFileName(subtitleNewFileName)), "", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Cancel)
                    {
                        MessageBox.Show("변환을 취소했습니다");
                        return;
                    }
                    else if (dr == DialogResult.No)
                    {
                        continue;
                    }
                    deletedSubtitles.Add(subtitleNewFileName, Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
                    File.Copy(subtitleNewFileName, deletedSubtitles[subtitleNewFileName], true);
                }
                if (deletedSubtitles.ContainsKey(subtitleFileName))
                {
                    subtitleFileName = deletedSubtitles[subtitleFileName];
                }
                File.Copy(subtitleFileName, subtitleNewFileName, true);
                File.Delete(subtitleFileName);
            }

            if (checkedListBox1.GetItemChecked(0))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Path.GetFileName(AssocQueryString(AssocStr.Executable, MovieListBox.Items[0].ToString()));
                startInfo.Arguments = string.Join(" ", MovieListBox.Items.Cast<string>().ToList().Select(x => "\"" + x + "\""));
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show("변환이 완료됐습니다");
            }

            MovieListBox.Items.Clear();
            SubtitleListBox.Items.Clear();
        }

        private void MovieListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void MovieListBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                MovieListBox.Items.Add(file);
            if (checkedListBox1.GetItemChecked(1))
            {
                SortListBoxItems(ref MovieListBox);
            }
        }

        private void SubtitleListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void SubtitleListBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                SubtitleListBox.Items.Add(file);
            if (checkedListBox1.GetItemChecked(1))
            {
                SortListBoxItems(ref SubtitleListBox);
            }
        }

        private void MoveUpListBoxItems(int index, ListBox listBox)
        {
            if (index < 0 || listBox.SelectedItems.Count < 1 || listBox.SelectedIndices[0] < 1)
            {
                return;
            }

            List<string> moveList = listBox.SelectedItems.Cast<string>().ToList();

            for (int i = listBox.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndices[i]);
            }

            for (int i = moveList.Count - 1; i >= 0; i--)
            {
                listBox.Items.Insert(index, moveList[i]);
                listBox.SelectedIndices.Add(index);
            }
        }

        private void MoveDownListBoxItems(int index, ListBox listBox)
        {
            if (index > listBox.Items.Count - 1 || listBox.SelectedItems.Count < 1
                || listBox.SelectedIndices.Cast<int>().ToList().Last() > listBox.Items.Count - 1)
            {
                return;
            }

            List<string> moveList = listBox.SelectedItems.Cast<string>().ToList();
            moveList.Reverse();

            for (int i = 0; i < moveList.Count; i++)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndices[0]);
            }

            for (int i = 0; i < moveList.Count; i++)
            {
                listBox.Items.Insert(index - moveList.Count + 1, moveList[i]);
                listBox.SelectedIndices.Add(index - moveList.Count + 1);
            }
        }

        private void MoveToTopButton1_Click(object sender, EventArgs e)
        {
            MoveUpListBoxItems(0, MovieListBox);
        }

        private void MoveUpButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MoveUpListBoxItems(MovieListBox.SelectedIndices[0] - 1, MovieListBox);
            }
            catch
            {

            }
        }

        private void MoveDownButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MoveDownListBoxItems(MovieListBox.SelectedIndices.Cast<int>().ToList().Last() + 1, MovieListBox);
            }
            catch
            {

            }
        }

        private void MoveToBottomButton1_Click(object sender, EventArgs e)
        {
            MoveDownListBoxItems(MovieListBox.Items.Count - 1, MovieListBox);
        }

        private void MoveToTopButton2_Click(object sender, EventArgs e)
        {
            MoveUpListBoxItems(0, SubtitleListBox);
        }

        private void MoveUpButton2_Click(object sender, EventArgs e)
        {
            try
            {
                MoveUpListBoxItems(SubtitleListBox.SelectedIndices[0] - 1, SubtitleListBox);
            }
            catch
            {

            }
        }

        private void MoveDownButton2_Click(object sender, EventArgs e)
        {
            try
            {
                MoveDownListBoxItems(SubtitleListBox.SelectedIndices.Cast<int>().ToList().Last() + 1, SubtitleListBox);
            }
            catch
            {

            }
        }

        private void MoveToBottomButton2_Click(object sender, EventArgs e)
        {
            MoveDownListBoxItems(SubtitleListBox.Items.Count - 1, SubtitleListBox);
        }

        private void SortListBoxItems(ref ListBox listBox, bool descending = false)
        {
            var listItems = listBox.Items.Cast<string>().ToList();
            listBox.Items.Clear();
            if (descending)
            {
                listBox.Items.AddRange(listItems.OrderByDescending(x => x).ToArray());
            }
            else
            {
                listBox.Items.AddRange(listItems.OrderBy(x => x).ToArray());
            }
        }

        private void SortDescendingButton1_Click(object sender, EventArgs e)
        {
            SortListBoxItems(ref MovieListBox, true);
        }

        private void SortAscendingButton1_Click(object sender, EventArgs e)
        {
            SortListBoxItems(ref MovieListBox);
        }

        private void SortDescendingButton2_Click(object sender, EventArgs e)
        {
            SortListBoxItems(ref SubtitleListBox, true);
        }

        private void SortAscendingButton2_Click(object sender, EventArgs e)
        {
            SortListBoxItems(ref SubtitleListBox);
        }

        private void InformationMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new HelpForm();
            form2.ShowDialog();
        }
    }
}
