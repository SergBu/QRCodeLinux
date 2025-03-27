

using SkiaSharp;
using ZXing;
using ZXing.Common;
using ZXing.SkiaSharp;

namespace QRCodeLinux
{
    public static class BarcodeGenerator
    {
        public static string CreateQrCode(string data)
        {
            byte[] imageData;

            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Height = 100,
                    Width = 100,
                    Margin = 0
                }
            };
            using var bitmap = barcodeWriter.Write(data);
            using var stream = new MemoryStream();
            bitmap.Encode(stream, SKEncodedImageFormat.Png, 100);

            imageData = stream.ToArray();

            string outputPath = @"C:\test\outputImageLinux.png";
            ImageService.SaveImage(bitmap, outputPath);

            var str64 = Convert.ToBase64String(imageData);

            return str64;
        }
    }
}
