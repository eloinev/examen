using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ar pathpdf = "d:\\test\\test.pdf";
            var pathimg = "d:\\test\\";
            var jpegname = "test";
            ConvertPDFToImage(pathpdf, pathimg, jpegname, ???);
        }

        //Метод конвертации pdf в jpeg.
        public static void ConvertPDFToImage(string pdfInputPath, string imageOutputPath, string imageName, ImageFormat imageFormat)
        {
            FileStream fs = new FileStream(pdfInputPath, FileMode.Open);
            Doc document = new Doc();
            document.Read(fs);

            document.Rendering.DotsPerInch = 72;
            document.Rendering.DrawAnnotations = true;
            document.Rendering.AntiAliasImages = true;
            document.Rect.String = document.CropBox.String;
            document.Rendering.Save(Path.ChangeExtension(Path.Combine(imageOutputPath, imageName), imageFormat.ToString()));
        }
        public static void Draw(PaintEventArgs e)
        {
            // Create a Bitmap object from an image file.
            Bitmap myBitmap = new Bitmap("d:\\test\\test.jpeg");

            // Get the color of a pixel within myBitmap.
            Color pixelColor = myBitmap.GetPixel(50, 50);

            // Fill a rectangle with pixelColor.
            SolidBrush pixelBrush = new SolidBrush(pixelColor);
            e.Graphics.FillRectangle(pixelBrush, 0, 0, 100, 100);

            System.Console.WriteLine(pixelColor);
            System.Console.ReadLine();
        }
    }
}
