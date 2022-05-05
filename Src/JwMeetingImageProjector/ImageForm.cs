namespace JwMeetingImageProjector;

public partial class ImageForm : Form
{
    private string ScreenName { get; }
    private bool IsTvMonitor { get; }
    private Image CurrentImage { get; set; } = null!;

    public ImageForm(string screenName, bool isTvMonitor)
    {
        InitializeComponent();
        ScreenName = screenName;
        IsTvMonitor = isTvMonitor;
        Text = IsTvMonitor ? "Image - Kingdom Hall" : "Image - Zoom";
    }

    public void SetImage(string imagePath)
    {
        CurrentImage?.Dispose();
        CurrentImage = Image.FromFile(imagePath);
        ImagePictureBox.Image = CurrentImage;

        FormBorderStyle = FormBorderStyle.None;
        var screen = Screen.AllScreens.FirstOrDefault(f => f.DeviceName.Contains(ScreenName)) ?? throw new NullReferenceException();

        if (IsTvMonitor)
        {
            Width = screen.Bounds.Width;
            Height = screen.Bounds.Height;
            Location = screen.Bounds.Location;
        }
        else
        {
            var workingAreaSize = screen.WorkingArea.Size;
            var maxFormSize = new Size((int)(workingAreaSize.Width / 1.5), (int)(workingAreaSize.Height / 1.5));

            var ratio = Math.Min((float)maxFormSize.Width / CurrentImage.Width, (float)maxFormSize.Height / CurrentImage.Height);
            Width = (int)(CurrentImage.Width * ratio);
            Height = (int)(CurrentImage.Height * ratio);

            Left = (workingAreaSize.Width / 2) < Width
                ? workingAreaSize.Width - Width - 50
                : workingAreaSize.Width / 2;
            Top = workingAreaSize.Height - Height - 50;
        }
    }
}
