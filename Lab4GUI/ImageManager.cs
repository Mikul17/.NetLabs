using System.Drawing.Imaging;

namespace Lab4GUI;

public class ImageManager
{
    public Bitmap Negative(Bitmap img)
    {
        Bitmap processed = img;

        for (int w = 0; w < processed.Width; w++)
        {
            for (int h = 0; h < processed.Height; h++)
            {
                Color originalColor = processed.GetPixel(w, h);
                Color negatedColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                processed.SetPixel(w, h, negatedColor);
            }
        }

        return processed;
    }

    public Bitmap Mirror(Bitmap img)
    {
        Bitmap processed = img;

        for (int w = 0; w < processed.Width / 2; w++)
        {
            for (int h = 0; h < processed.Height; h++)
            {
                Color left = processed.GetPixel(w, h);
                Color right = processed.GetPixel(processed.Width - w - 1, h);
                processed.SetPixel(w, h, right);
                processed.SetPixel(processed.Width - w - 1, h, left);
            }
        }

        return processed;
    }

    public Bitmap GrayScale(Bitmap img)
    {
        Bitmap processed = img;

        for (int w = 0; w < processed.Width; w++)
        {
            for (int h = 0; h < processed.Height; h++)
            {
                Color originalColor = processed.GetPixel(w, h);
                int avrg = (originalColor.R + originalColor.G + originalColor.B) / 3;
                Color grayScaleColor = Color.FromArgb(avrg, avrg, avrg);
                processed.SetPixel(w, h, grayScaleColor);
            }
        }

        return processed;
    }
    
    public Bitmap RedToBlue(Bitmap img)
    {
        Bitmap processed = img;

        for (int w = 0; w < processed.Width; w++)
        {
            for (int h = 0; h < processed.Height; h++)
            {
                Color originalColor = processed.GetPixel(w, h);
                Color newColor;
                if (originalColor.B < originalColor.R/1.5  && originalColor.G < originalColor.R/1.5 )
                {
                    newColor = Color.FromArgb(originalColor.A,0,originalColor.G, originalColor.B);
                }
                else
                {
                     newColor = Color.FromArgb(originalColor.A, originalColor.R, originalColor.G, originalColor.B);
                }
                processed.SetPixel(w, h, newColor);
            }
        }
        return processed;
    }
}