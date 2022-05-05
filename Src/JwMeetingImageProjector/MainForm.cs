global using System;
global using System.Collections.Generic;
global using System.ComponentModel;
global using System.Data;
global using System.Drawing;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using System.Windows.Forms;

namespace JwMeetingImageProjector
{
    public partial class MainForm : Form
    {
        private List<FileInfo> ImageFiles { get; set; } = new();
        private ImageForm? PcMonitorForm { get; set; }
        private ImageForm? TvMonitorForm { get; set; }

        public MainForm()
        {
            InitializeComponent();
            ImageListView.LargeImageList = ViewedImageList;
            ViewedImageList.ImageSize = new Size(200, 200);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            PcMonitorForm?.Dispose();
            TvMonitorForm?.Dispose();
            PcMonitorForm = TvMonitorForm = null;

            var screens = Screen.AllScreens.Select(s => s.DeviceName.Replace("\\\\.\\", string.Empty)).ToArray();
            PcMonitorComboBox.Items.AddRange(screens);
            TvMonitorComboBox.Items.AddRange(screens);
            if (PcMonitorComboBox.Items.Count > 0)
                PcMonitorComboBox.SelectedIndex = 0;
            if (TvMonitorComboBox.Items.Count > 0)
                TvMonitorComboBox.SelectedIndex = TvMonitorComboBox.Items.Count - 1;
            if (TvMonitorComboBox.Items.Count < 2)
                TvMonitorComboBox.Enabled = false;

            ShowButton.Enabled = HideButton.Enabled = PreviewButton.Enabled = NextButton.Enabled = false;

            ClearImageList();
        }

        private void ClearImageList()
        {
            PcMonitorForm?.Hide();
            TvMonitorForm?.Hide();
            ImageListView.Items.Clear();
            ViewedImageList.Images.Clear();
            ImageFiles.Clear();
        }

        private async void SelectImageFolderButton_Click(object sender, EventArgs e)
        {
            var r = ImageFolderBrowserDialog.ShowDialog(this);
            if (r == DialogResult.OK)
                await ExecuteAsync(async () => await SetImagesAsync());
        }

        private async Task SetImagesAsync()
        {
            ClearImageList();

            var dirInfo = new DirectoryInfo(ImageFolderBrowserDialog.SelectedPath);
            ImageFiles = dirInfo.EnumerateFiles("*.png")
                .Union(dirInfo.EnumerateFiles("*.jpg"))
                .Union(dirInfo.EnumerateFiles("*.jpeg"))
                .Union(dirInfo.EnumerateFiles("*.bmp"))
                .OrderBy(o => o.Name)
                .ToList();

            int i = 0;
            foreach (var imageFile in ImageFiles)
            {
                using var original = Image.FromFile(imageFile.FullName);
                using var thumbnail = ImageHelper.CreateThumbnail(original, 256, 256);
                ViewedImageList.Images.Add(thumbnail);
                ImageListView.Items.Add(imageFile.Name, i++);
            }

            if (ImageListView.Items.Count > 0)
            {
                ImageListView.Items[0].Selected = true;
                ShowButton.Enabled = HideButton.Enabled = PreviewButton.Enabled = NextButton.Enabled = true;
            }
            await Task.CompletedTask;
        }

        private async void ImageListView_DoubleClick(object sender, EventArgs e)
        {
            if (ImageListView.Items.Count < 1 || ImageListView.SelectedItems.Count < 1)
                return;

            await ExecuteAsync(async () => await ShowImageAsync());
        }

        private async void ShowButton_Click(object sender, EventArgs e)
        {
            if (ImageListView.Items.Count < 1)
                return;
            if (ImageListView.Items.Count > 0 && ImageListView.SelectedItems.Count < 1)
                ImageListView.Items[0].Selected = true;

            await ExecuteAsync(async () => await ShowImageAsync());
        }

        private async Task ShowImageAsync()
        {
            var imagePath = ImageFiles[ImageListView.SelectedItems[0].Index].FullName;
            if (!File.Exists(imagePath))
                throw new ApplicationException("Image does not exists!");

            PcMonitorForm ??= new ImageForm(PcMonitorComboBox.SelectedItem.ToString() ?? throw new NullReferenceException(), false);
            PcMonitorForm.SetImage(imagePath);
            PcMonitorForm.Show();

            TvMonitorForm ??= TvMonitorComboBox.SelectedIndex == PcMonitorComboBox.SelectedIndex ? null
                : new ImageForm(TvMonitorComboBox.SelectedItem.ToString() ?? throw new NullReferenceException(), true);
            TvMonitorForm?.SetImage(imagePath);
            TvMonitorForm?.Show();

            await Task.CompletedTask;
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            PcMonitorForm?.Hide();
            TvMonitorForm?.Hide();
        }

        private async void PreviewButton_Click(object sender, EventArgs e)
        {
            if (PcMonitorForm is null || !PcMonitorForm.Visible)
                return;
            if (ImageListView.SelectedItems.Count < 1 || ImageListView.SelectedItems[0].Index == 0)
                return;

            ImageListView.Items[ImageListView.SelectedItems[0].Index - 1].Selected = true;
            await ExecuteAsync(async () => await ShowImageAsync());
        }

        private async void NextButton_Click(object sender, EventArgs e)
        {
            if (PcMonitorForm is null || !PcMonitorForm.Visible)
                return;
            if (ImageListView.SelectedItems.Count < 1 || ImageListView.SelectedItems[0].Index == ImageListView.Items.Count - 1)
                return;

            ImageListView.Items[ImageListView.SelectedItems[0].Index + 1].Selected = true;
            await ExecuteAsync(async () => await ShowImageAsync());
        }

        private async Task ExecuteAsync(Func<Task> action)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                await action();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}