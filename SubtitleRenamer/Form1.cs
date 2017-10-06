﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace SubtitleRenamer
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

        private void button8_Click(object sender, EventArgs e)
        {
            moveUpListBoxItems(0, listBox1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                moveUpListBoxItems(listBox1.SelectedIndices[0] - 1, listBox1);
            }
            catch
            {

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                moveDownListBoxItems(listBox1.SelectedIndices.Cast<int>().ToList().Last() + 1, listBox1);
            }
            catch
            {

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            moveDownListBoxItems(listBox1.Items.Count - 1, listBox1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            moveUpListBoxItems(0, listBox2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                moveUpListBoxItems(listBox2.SelectedIndices[0] - 1, listBox2);
            }
            catch
            {

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                moveDownListBoxItems(listBox2.SelectedIndices.Cast<int>().ToList().Last() + 1, listBox2);
            }
            catch
            {

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            moveDownListBoxItems(listBox2.Items.Count - 1, listBox2);
        }
    }
}
