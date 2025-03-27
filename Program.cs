using QRCodeLinux;

var qrCode = BarcodeGenerator.CreateQrCode("test");
Console.WriteLine($"qrCode={qrCode}");
Console.ReadKey();
