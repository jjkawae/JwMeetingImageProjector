namespace JwMeetingImageProjector;

public static class ImageHelper
{
    public static Image CreateThumbnail(Image image, int w, int h)
    {
        Bitmap canvas = new(w, h);

        using Graphics g = Graphics.FromImage(canvas);
        g.FillRectangle(new SolidBrush(Color.White), 0, 0, w, h);

        float fw = w / (float)image.Width;
        float fh = h / (float)image.Height;

        float scale = Math.Min(fw, fh);
        fw = image.Width * scale;
        fh = image.Height * scale;

        g.DrawImage(image, (w - fw) / 2, (h - fh) / 2, fw, fh);

        return canvas;
    }
}
