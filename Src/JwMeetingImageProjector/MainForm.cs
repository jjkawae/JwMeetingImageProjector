global using System;
global using System.Collections.Generic;
global using System.ComponentModel;
global using System.Data;
global using System.Drawing;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using System.Windows.Forms;

namespace JwMeetingImageProjector;

public partial class MainForm : Form
{
    private List<FileInfo> ImageFileInfos { get; set; } = new();
    private ImageForm? PcMonitorForm { get; set; }
    private ImageForm? TvMonitorForm { get; set; }

    public MainForm()
    {
        InitializeComponent();

        ImageListView.LargeImageList = ViewedImageList;
        ViewedImageList.ImageSize = new Size(200, 200);

        OpenImageDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
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
        ImageFileInfos.Clear();
    }

    private async void SelectImageFolderButton_Click(object sender, EventArgs e)
    {
        if (OpenImageDialog.ShowDialog(this) != DialogResult.OK)
            return;

        OpenImageDialog.InitialDirectory = Path.GetDirectoryName(OpenImageDialog.FileName);
        ClearImageList();
        ImageFileInfos.AddRange(OpenImageDialog.FileNames.Select(s => new FileInfo(s)).OrderBy(o => o.Name));

        int i = 0;
        foreach (var imageFileInfo in ImageFileInfos)
        {
            using var original = Image.FromFile(imageFileInfo.FullName);
            using var thumbnail = ImageHelper.CreateThumbnail(original, 256, 256);
            ViewedImageList.Images.Add(thumbnail);
            ImageListView.Items.Add(imageFileInfo.Name, i++);
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
        var imagePath = ImageFileInfos[ImageListView.SelectedItems[0].Index].FullName;
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
