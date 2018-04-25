namespace SubtitleRenamer
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.AddFileButton1 = new System.Windows.Forms.Button();
            this.DeleteAllButton1 = new System.Windows.Forms.Button();
            this.DeleteFileButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.MoveToTopButton1 = new System.Windows.Forms.Button();
            this.MoveUpButton1 = new System.Windows.Forms.Button();
            this.MoveDownButton1 = new System.Windows.Forms.Button();
            this.MoveToBottomButton1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.SortDescendingButton1 = new System.Windows.Forms.Button();
            this.SortAscendingButton1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.AddFileButton2 = new System.Windows.Forms.Button();
            this.DeleteAllButton2 = new System.Windows.Forms.Button();
            this.DeleteFileButton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.SubtitleListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.MoveToTopButton2 = new System.Windows.Forms.Button();
            this.MoveUpButton2 = new System.Windows.Forms.Button();
            this.MoveDownButton2 = new System.Windows.Forms.Button();
            this.MoveToBottomButton2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.SortDescendingButton2 = new System.Windows.Forms.Button();
            this.SortAscendingButton2 = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InformationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProcessButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1174, 689);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(581, 545);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.AddFileButton1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.DeleteAllButton1, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.DeleteFileButton1, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 473);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(575, 69);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // AddFileButton1
            // 
            this.AddFileButton1.AutoSize = true;
            this.AddFileButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddFileButton1.Location = new System.Drawing.Point(95, 3);
            this.AddFileButton1.Name = "AddFileButton1";
            this.AddFileButton1.Size = new System.Drawing.Size(124, 63);
            this.AddFileButton1.TabIndex = 0;
            this.AddFileButton1.Text = "파일 추가";
            this.AddFileButton1.UseVisualStyleBackColor = true;
            this.AddFileButton1.Click += new System.EventHandler(this.AddFileButton1_Click);
            // 
            // DeleteAllButton1
            // 
            this.DeleteAllButton1.AutoSize = true;
            this.DeleteAllButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteAllButton1.Location = new System.Drawing.Point(225, 3);
            this.DeleteAllButton1.Name = "DeleteAllButton1";
            this.DeleteAllButton1.Size = new System.Drawing.Size(124, 63);
            this.DeleteAllButton1.TabIndex = 1;
            this.DeleteAllButton1.Text = "전체 삭제";
            this.DeleteAllButton1.UseVisualStyleBackColor = true;
            this.DeleteAllButton1.Click += new System.EventHandler(this.DeleteAllButton1_Click);
            // 
            // DeleteFileButton1
            // 
            this.DeleteFileButton1.AutoSize = true;
            this.DeleteFileButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteFileButton1.Location = new System.Drawing.Point(355, 3);
            this.DeleteFileButton1.Name = "DeleteFileButton1";
            this.DeleteFileButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeleteFileButton1.Size = new System.Drawing.Size(124, 63);
            this.DeleteFileButton1.TabIndex = 2;
            this.DeleteFileButton1.Text = "삭제";
            this.DeleteFileButton1.UseVisualStyleBackColor = true;
            this.DeleteFileButton1.Click += new System.EventHandler(this.DeleteFileButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "동영상";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Controls.Add(this.MovieListBox, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(575, 414);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // MovieListBox
            // 
            this.MovieListBox.AllowDrop = true;
            this.MovieListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.HorizontalScrollbar = true;
            this.MovieListBox.ItemHeight = 24;
            this.MovieListBox.Location = new System.Drawing.Point(67, 20);
            this.MovieListBox.Margin = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.MovieListBox.Size = new System.Drawing.Size(440, 394);
            this.MovieListBox.TabIndex = 3;
            this.MovieListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.MovieListBox_DragDrop);
            this.MovieListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.MovieListBox_DragEnter);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.MoveToTopButton1, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.MoveUpButton1, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.MoveDownButton1, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.MoveToBottomButton1, 0, 5);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(520, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 8;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(52, 408);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // MoveToTopButton1
            // 
            this.MoveToTopButton1.AutoSize = true;
            this.MoveToTopButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveToTopButton1.Image = ((System.Drawing.Image)(resources.GetObject("MoveToTopButton1.Image")));
            this.MoveToTopButton1.Location = new System.Drawing.Point(3, 105);
            this.MoveToTopButton1.Name = "MoveToTopButton1";
            this.MoveToTopButton1.Size = new System.Drawing.Size(46, 45);
            this.MoveToTopButton1.TabIndex = 5;
            this.MoveToTopButton1.UseVisualStyleBackColor = true;
            this.MoveToTopButton1.Click += new System.EventHandler(this.MoveToTopButton1_Click);
            // 
            // MoveUpButton1
            // 
            this.MoveUpButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveUpButton1.Image = ((System.Drawing.Image)(resources.GetObject("MoveUpButton1.Image")));
            this.MoveUpButton1.Location = new System.Drawing.Point(3, 156);
            this.MoveUpButton1.Name = "MoveUpButton1";
            this.MoveUpButton1.Size = new System.Drawing.Size(46, 45);
            this.MoveUpButton1.TabIndex = 6;
            this.MoveUpButton1.UseVisualStyleBackColor = true;
            this.MoveUpButton1.Click += new System.EventHandler(this.MoveUpButton1_Click);
            // 
            // MoveDownButton1
            // 
            this.MoveDownButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("MoveDownButton1.Image")));
            this.MoveDownButton1.Location = new System.Drawing.Point(3, 207);
            this.MoveDownButton1.Name = "MoveDownButton1";
            this.MoveDownButton1.Size = new System.Drawing.Size(46, 45);
            this.MoveDownButton1.TabIndex = 7;
            this.MoveDownButton1.UseVisualStyleBackColor = true;
            this.MoveDownButton1.Click += new System.EventHandler(this.MoveDownButton1_Click);
            // 
            // MoveToBottomButton1
            // 
            this.MoveToBottomButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveToBottomButton1.Image = ((System.Drawing.Image)(resources.GetObject("MoveToBottomButton1.Image")));
            this.MoveToBottomButton1.Location = new System.Drawing.Point(3, 258);
            this.MoveToBottomButton1.Name = "MoveToBottomButton1";
            this.MoveToBottomButton1.Size = new System.Drawing.Size(46, 45);
            this.MoveToBottomButton1.TabIndex = 8;
            this.MoveToBottomButton1.UseVisualStyleBackColor = true;
            this.MoveToBottomButton1.Click += new System.EventHandler(this.MoveToBottomButton1_Click);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.SortDescendingButton1, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.SortAscendingButton1, 0, 4);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 8;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(51, 408);
            this.tableLayoutPanel10.TabIndex = 5;
            // 
            // SortDescendingButton1
            // 
            this.SortDescendingButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.SortDescendingButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortDescendingButton1.Image = ((System.Drawing.Image)(resources.GetObject("SortDescendingButton1.Image")));
            this.SortDescendingButton1.Location = new System.Drawing.Point(3, 156);
            this.SortDescendingButton1.Name = "SortDescendingButton1";
            this.SortDescendingButton1.Size = new System.Drawing.Size(45, 45);
            this.SortDescendingButton1.TabIndex = 0;
            this.SortDescendingButton1.UseVisualStyleBackColor = true;
            this.SortDescendingButton1.Click += new System.EventHandler(this.SortDescendingButton1_Click);
            // 
            // SortAscendingButton1
            // 
            this.SortAscendingButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortAscendingButton1.Image = ((System.Drawing.Image)(resources.GetObject("SortAscendingButton1.Image")));
            this.SortAscendingButton1.Location = new System.Drawing.Point(3, 207);
            this.SortAscendingButton1.Name = "SortAscendingButton1";
            this.SortAscendingButton1.Size = new System.Drawing.Size(45, 45);
            this.SortAscendingButton1.TabIndex = 1;
            this.SortAscendingButton1.UseVisualStyleBackColor = true;
            this.SortAscendingButton1.Click += new System.EventHandler(this.SortAscendingButton1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(590, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(581, 545);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.AddFileButton2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.DeleteAllButton2, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.DeleteFileButton2, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 473);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(575, 69);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // AddFileButton2
            // 
            this.AddFileButton2.AutoSize = true;
            this.AddFileButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddFileButton2.Location = new System.Drawing.Point(95, 3);
            this.AddFileButton2.Name = "AddFileButton2";
            this.AddFileButton2.Size = new System.Drawing.Size(124, 63);
            this.AddFileButton2.TabIndex = 0;
            this.AddFileButton2.Text = "파일 추가";
            this.AddFileButton2.UseVisualStyleBackColor = true;
            this.AddFileButton2.Click += new System.EventHandler(this.AddFileButton2_Click);
            // 
            // DeleteAllButton2
            // 
            this.DeleteAllButton2.AutoSize = true;
            this.DeleteAllButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteAllButton2.Location = new System.Drawing.Point(225, 3);
            this.DeleteAllButton2.Name = "DeleteAllButton2";
            this.DeleteAllButton2.Size = new System.Drawing.Size(124, 63);
            this.DeleteAllButton2.TabIndex = 1;
            this.DeleteAllButton2.Text = "전체 삭제";
            this.DeleteAllButton2.UseVisualStyleBackColor = true;
            this.DeleteAllButton2.Click += new System.EventHandler(this.DeleteAllButton2_Click);
            // 
            // DeleteFileButton2
            // 
            this.DeleteFileButton2.AutoSize = true;
            this.DeleteFileButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteFileButton2.Location = new System.Drawing.Point(355, 3);
            this.DeleteFileButton2.Name = "DeleteFileButton2";
            this.DeleteFileButton2.Size = new System.Drawing.Size(124, 63);
            this.DeleteFileButton2.TabIndex = 2;
            this.DeleteFileButton2.Text = "  삭제  ";
            this.DeleteFileButton2.UseVisualStyleBackColor = true;
            this.DeleteFileButton2.Click += new System.EventHandler(this.DeleteFileButton2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(0, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "자막";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.Controls.Add(this.SubtitleListBox, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(575, 414);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // SubtitleListBox
            // 
            this.SubtitleListBox.AllowDrop = true;
            this.SubtitleListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubtitleListBox.FormattingEnabled = true;
            this.SubtitleListBox.HorizontalScrollbar = true;
            this.SubtitleListBox.ItemHeight = 24;
            this.SubtitleListBox.Location = new System.Drawing.Point(67, 20);
            this.SubtitleListBox.Margin = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.SubtitleListBox.Name = "SubtitleListBox";
            this.SubtitleListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.SubtitleListBox.Size = new System.Drawing.Size(440, 394);
            this.SubtitleListBox.TabIndex = 3;
            this.SubtitleListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.SubtitleListBox_DragDrop);
            this.SubtitleListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.SubtitleListBox_DragEnter);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.MoveToTopButton2, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.MoveUpButton2, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.MoveDownButton2, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.MoveToBottomButton2, 0, 5);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(520, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 8;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(52, 408);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // MoveToTopButton2
            // 
            this.MoveToTopButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveToTopButton2.Image = ((System.Drawing.Image)(resources.GetObject("MoveToTopButton2.Image")));
            this.MoveToTopButton2.Location = new System.Drawing.Point(3, 105);
            this.MoveToTopButton2.Name = "MoveToTopButton2";
            this.MoveToTopButton2.Size = new System.Drawing.Size(46, 45);
            this.MoveToTopButton2.TabIndex = 0;
            this.MoveToTopButton2.UseVisualStyleBackColor = true;
            this.MoveToTopButton2.Click += new System.EventHandler(this.MoveToTopButton2_Click);
            // 
            // MoveUpButton2
            // 
            this.MoveUpButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveUpButton2.Image = ((System.Drawing.Image)(resources.GetObject("MoveUpButton2.Image")));
            this.MoveUpButton2.Location = new System.Drawing.Point(3, 156);
            this.MoveUpButton2.Name = "MoveUpButton2";
            this.MoveUpButton2.Size = new System.Drawing.Size(46, 45);
            this.MoveUpButton2.TabIndex = 1;
            this.MoveUpButton2.UseVisualStyleBackColor = true;
            this.MoveUpButton2.Click += new System.EventHandler(this.MoveUpButton2_Click);
            // 
            // MoveDownButton2
            // 
            this.MoveDownButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("MoveDownButton2.Image")));
            this.MoveDownButton2.Location = new System.Drawing.Point(3, 207);
            this.MoveDownButton2.Name = "MoveDownButton2";
            this.MoveDownButton2.Size = new System.Drawing.Size(46, 45);
            this.MoveDownButton2.TabIndex = 2;
            this.MoveDownButton2.UseVisualStyleBackColor = true;
            this.MoveDownButton2.Click += new System.EventHandler(this.MoveDownButton2_Click);
            // 
            // MoveToBottomButton2
            // 
            this.MoveToBottomButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveToBottomButton2.Image = ((System.Drawing.Image)(resources.GetObject("MoveToBottomButton2.Image")));
            this.MoveToBottomButton2.Location = new System.Drawing.Point(3, 258);
            this.MoveToBottomButton2.Name = "MoveToBottomButton2";
            this.MoveToBottomButton2.Size = new System.Drawing.Size(46, 45);
            this.MoveToBottomButton2.TabIndex = 3;
            this.MoveToBottomButton2.UseVisualStyleBackColor = true;
            this.MoveToBottomButton2.Click += new System.EventHandler(this.MoveToBottomButton2_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Controls.Add(this.SortDescendingButton2, 0, 3);
            this.tableLayoutPanel11.Controls.Add(this.SortAscendingButton2, 0, 4);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 8;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(51, 408);
            this.tableLayoutPanel11.TabIndex = 5;
            // 
            // SortDescendingButton2
            // 
            this.SortDescendingButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortDescendingButton2.Image = ((System.Drawing.Image)(resources.GetObject("SortDescendingButton2.Image")));
            this.SortDescendingButton2.Location = new System.Drawing.Point(3, 156);
            this.SortDescendingButton2.Name = "SortDescendingButton2";
            this.SortDescendingButton2.Size = new System.Drawing.Size(45, 45);
            this.SortDescendingButton2.TabIndex = 0;
            this.SortDescendingButton2.UseVisualStyleBackColor = true;
            this.SortDescendingButton2.Click += new System.EventHandler(this.SortDescendingButton2_Click);
            // 
            // SortAscendingButton2
            // 
            this.SortAscendingButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortAscendingButton2.Image = ((System.Drawing.Image)(resources.GetObject("SortAscendingButton2.Image")));
            this.SortAscendingButton2.Location = new System.Drawing.Point(3, 207);
            this.SortAscendingButton2.Name = "SortAscendingButton2";
            this.SortAscendingButton2.Size = new System.Drawing.Size(45, 45);
            this.SortAscendingButton2.TabIndex = 1;
            this.SortAscendingButton2.UseVisualStyleBackColor = true;
            this.SortAscendingButton2.Click += new System.EventHandler(this.SortAscendingButton2_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(787, 581);
            this.ProcessButton.Margin = new System.Windows.Forms.Padding(200, 30, 200, 30);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(187, 78);
            this.ProcessButton.TabIndex = 3;
            this.ProcessButton.Text = "변환";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "변환 후 동영상 열기",
            "자동 정렬"});
            this.checkedListBox1.Location = new System.Drawing.Point(50, 571);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(487, 98);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.CheckOnClick = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InformationMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(99, 36);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // InformationMenuItem
            // 
            this.InformationMenuItem.Name = "InformationMenuItem";
            this.InformationMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.InformationMenuItem.Size = new System.Drawing.Size(202, 38);
            this.InformationMenuItem.Text = "정보";
            this.InformationMenuItem.Click += new System.EventHandler(this.InformationMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Subtitle Renamer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button AddFileButton1;
        private System.Windows.Forms.Button DeleteAllButton1;
        private System.Windows.Forms.Button DeleteFileButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button AddFileButton2;
        private System.Windows.Forms.Button DeleteAllButton2;
        private System.Windows.Forms.Button DeleteFileButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button MoveToTopButton1;
        private System.Windows.Forms.Button MoveUpButton1;
        private System.Windows.Forms.Button MoveDownButton1;
        private System.Windows.Forms.Button MoveToBottomButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ListBox SubtitleListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button MoveToTopButton2;
        private System.Windows.Forms.Button MoveUpButton2;
        private System.Windows.Forms.Button MoveDownButton2;
        private System.Windows.Forms.Button MoveToBottomButton2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button SortDescendingButton1;
        private System.Windows.Forms.Button SortAscendingButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button SortDescendingButton2;
        private System.Windows.Forms.Button SortAscendingButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InformationMenuItem;
    }
}

