namespace JwMeetingImageProjector
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.TvMonitorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectImageFolderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PcMonitorComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.ImageListView = new System.Windows.Forms.ListView();
            this.ViewedImageList = new System.Windows.Forms.ImageList(this.components);
            this.OpenImageDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ImageListView);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 736);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ShowButton, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.ResetButton, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.TvMonitorComboBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SelectImageFolderButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PcMonitorComboBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.HideButton, 0, 12);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(239, 736);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ShowButton
            // 
            this.ShowButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowButton.Location = new System.Drawing.Point(3, 357);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(233, 60);
            this.ShowButton.TabIndex = 3;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetButton.Location = new System.Drawing.Point(3, 673);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(233, 60);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // TvMonitorComboBox
            // 
            this.TvMonitorComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvMonitorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TvMonitorComboBox.FormattingEnabled = true;
            this.TvMonitorComboBox.Location = new System.Drawing.Point(3, 127);
            this.TvMonitorComboBox.Name = "TvMonitorComboBox";
            this.TvMonitorComboBox.Size = new System.Drawing.Size(233, 38);
            this.TvMonitorComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select TV Monitor";
            // 
            // SelectImageFolderButton
            // 
            this.SelectImageFolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectImageFolderButton.Location = new System.Drawing.Point(3, 231);
            this.SelectImageFolderButton.Name = "SelectImageFolderButton";
            this.SelectImageFolderButton.Size = new System.Drawing.Size(233, 60);
            this.SelectImageFolderButton.TabIndex = 2;
            this.SelectImageFolderButton.Text = "Select Image...";
            this.SelectImageFolderButton.UseVisualStyleBackColor = true;
            this.SelectImageFolderButton.Click += new System.EventHandler(this.SelectImageFolderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select PC Monitor";
            // 
            // PcMonitorComboBox
            // 
            this.PcMonitorComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PcMonitorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PcMonitorComboBox.FormattingEnabled = true;
            this.PcMonitorComboBox.Location = new System.Drawing.Point(3, 33);
            this.PcMonitorComboBox.Name = "PcMonitorComboBox";
            this.PcMonitorComboBox.Size = new System.Drawing.Size(233, 38);
            this.PcMonitorComboBox.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.PreviewButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.NextButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 433);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(233, 66);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // PreviewButton
            // 
            this.PreviewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewButton.Location = new System.Drawing.Point(3, 3);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(110, 60);
            this.PreviewButton.TabIndex = 1;
            this.PreviewButton.Text = "Preview";
            this.PreviewButton.UseVisualStyleBackColor = true;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextButton.Location = new System.Drawing.Point(119, 3);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(111, 60);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // HideButton
            // 
            this.HideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HideButton.Location = new System.Drawing.Point(3, 515);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(233, 60);
            this.HideButton.TabIndex = 5;
            this.HideButton.Text = "Hide";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // ImageListView
            // 
            this.ImageListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageListView.Location = new System.Drawing.Point(0, 0);
            this.ImageListView.MultiSelect = false;
            this.ImageListView.Name = "ImageListView";
            this.ImageListView.Size = new System.Drawing.Size(757, 736);
            this.ImageListView.TabIndex = 0;
            this.ImageListView.UseCompatibleStateImageBehavior = false;
            this.ImageListView.DoubleClick += new System.EventHandler(this.ImageListView_DoubleClick);
            // 
            // ViewedImageList
            // 
            this.ViewedImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ViewedImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ViewedImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // OpenImageDialog
            // 
            this.OpenImageDialog.Filter = "Image (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            this.OpenImageDialog.Multiselect = true;
            this.OpenImageDialog.Title = "Select Images";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 736);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "JW Meeting Image Projector";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox TvMonitorComboBox;
        private Label label1;
        private Button SelectImageFolderButton;
        private ListView ImageListView;
        private ImageList ViewedImageList;
        private Label label3;
        private ComboBox PcMonitorComboBox;
        private Button ResetButton;
        private Button ShowButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Button HideButton;
        private Button PreviewButton;
        private Button NextButton;
        private OpenFileDialog OpenImageDialog;
    }
}