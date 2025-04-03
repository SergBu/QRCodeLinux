

using SkiaSharp;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.SkiaSharp;

namespace QRCodeLinux
{
    public static class BarcodeGenerator
    {
        public static string CreateQrCode(string data)
        {
            QRCodeWriter qrEncode = new QRCodeWriter();
            Dictionary<EncodeHintType, object> hints = new Dictionary<EncodeHintType, object>();
            hints.Add(EncodeHintType.CHARACTER_SET, "utf-8");
            BitMatrix qrMatrix = qrEncode.encode(data, BarcodeFormat.QR_CODE, 100, 100, hints);
            var qrWriter = new BarcodeWriter();
            using var bitmap = qrWriter.Write(qrMatrix);
            using var stream = new MemoryStream();
            bitmap.Encode(stream, SKEncodedImageFormat.Png, 100);

            var imageData = stream.ToArray();

            var outputPath = RuntimeDirectory.GetRuntimeDirectory("outputImageLinux2.png");
            ImageService.SaveImage(bitmap, outputPath);

            var str64 = Convert.ToBase64String(imageData);

            return str64;
        }
    }
}
