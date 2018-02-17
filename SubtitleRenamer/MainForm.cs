﻿using System;
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
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
                    listBox1.Items.Add(file);
                }
                if (checkedListBox1.GetItemChecked(1))
                {
                    sortListBoxItems(ref listBox1);
                }
            }
        }

        private void DeleteAllButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void DeleteFileButton1_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
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
                    listBox2.Items.Add(file);
                }
                if (checkedListBox1.GetItemChecked(1))
                {
                    sortListBoxItems(ref listBox2);
                }
            }
        }

        private void DeleteAllButton2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void DeleteFileButton2_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
            }
        }

        private Result getSubtitleFileFromZip(ref string subtitleFileName, ref string subtitleNewFileName)
        {
            try
            {
                using (ZipArchive archive = ZipFile.Open(subtitleFileName, ZipArchiveMode.Read))
                {
                    List<string> zipFileNames = new List<string>();
                    foreach (var entry in archive.Entries)
                    {
                        zipFileNames.Add(entry.FullName);
                    }
                    ZipFilesForm zipFilesForm = new ZipFilesForm(zipFileNames);
                    zipFilesForm.ShowDialog();

                    if (!zipFilesForm.ok)
                    {
                        return Result.Continue;
                    }
                    string selectedFileExtension = Path.GetExtension(zipFilesForm.selectedSubtitleFileName);
                    subtitleFileName = Path.Combine(Path.GetTempPath(),
                        Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + selectedFileExtension);
                    archive.GetEntry(zipFilesForm.selectedSubtitleFileName).ExtractToFile(subtitleFileName);
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

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("동영상 파일이 없습니다");
                return;
            }
            else if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("자막 파일이 없습니다");
                return;
            }
            else if (listBox1.Items.Count != listBox2.Items.Count)
            {
                MessageBox.Show("동영상과 자막 파일 개수는 동일해야 합니다");
                return;
            }

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                DialogResult dr;
                string movieFileName = listBox1.Items[i].ToString();
                string subtitleFileName = listBox2.Items[i].ToString();
                string subtitleNewFileName = Path.Combine(Path.GetDirectoryName(movieFileName),
                    Path.GetFileNameWithoutExtension(movieFileName) + Path.GetExtension(subtitleFileName));

                if (Path.GetExtension(subtitleFileName).ToLower() == ".zip")
                {
                    if (getSubtitleFileFromZip(ref subtitleFileName, ref subtitleNewFileName) == Result.Continue)
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
                startInfo.FileName = Path.GetFileName(AssocQueryString(AssocStr.Executable, listBox1.Items[0].ToString()));
                startInfo.Arguments = string.Join(" ", listBox1.Items.Cast<string>().ToList().Select(x => "\"" + x + "\""));
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show("변환이 완료됐습니다");
            }

            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                listBox1.Items.Add(file);
            if (checkedListBox1.GetItemChecked(1))
            {
                sortListBoxItems(ref listBox1);
            }
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                listBox2.Items.Add(file);
            if (checkedListBox1.GetItemChecked(1))
            {
                sortListBoxItems(ref listBox2);
            }
        }

        private void moveUpListBoxItems(int index, ListBox listBox)
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

        private void moveDownListBoxItems(int index, ListBox listBox)
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
            moveUpListBoxItems(0, listBox1);
        }

        private void MoveUpButton1_Click(object sender, EventArgs e)
        {
            try
            {
                moveUpListBoxItems(listBox1.SelectedIndices[0] - 1, listBox1);
            }
            catch
            {

            }
        }

        private void MoveDownButton1_Click(object sender, EventArgs e)
        {
            try
            {
                moveDownListBoxItems(listBox1.SelectedIndices.Cast<int>().ToList().Last() + 1, listBox1);
            }
            catch
            {

            }
        }

        private void MoveToBottomButton1_Click(object sender, EventArgs e)
        {
            moveDownListBoxItems(listBox1.Items.Count - 1, listBox1);
        }

        private void MoveToTopButton2_Click(object sender, EventArgs e)
        {
            moveUpListBoxItems(0, listBox2);
        }

        private void MoveUpButton2_Click(object sender, EventArgs e)
        {
            try
            {
                moveUpListBoxItems(listBox2.SelectedIndices[0] - 1, listBox2);
            }
            catch
            {

            }
        }

        private void MoveDownButton2_Click(object sender, EventArgs e)
        {
            try
            {
                moveDownListBoxItems(listBox2.SelectedIndices.Cast<int>().ToList().Last() + 1, listBox2);
            }
            catch
            {

            }
        }

        private void MoveToBottomButton2_Click(object sender, EventArgs e)
        {
            moveDownListBoxItems(listBox2.Items.Count - 1, listBox2);
        }

        private void sortListBoxItems(ref ListBox listBox, bool descending = false)
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
            sortListBoxItems(ref listBox1, true);
        }

        private void SortAscendingButton1_Click(object sender, EventArgs e)
        {
            sortListBoxItems(ref listBox1);
        }

        private void SortDescendingButton2_Click(object sender, EventArgs e)
        {
            sortListBoxItems(ref listBox2, true);
        }

        private void SortAscendingButton2_Click(object sender, EventArgs e)
        {
            sortListBoxItems(ref listBox2);
        }

        private void informationMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new HelpForm();
            form2.ShowDialog();
        }
    }
}
