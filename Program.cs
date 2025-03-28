using QRCodeLinux;

var qrCode = BarcodeGenerator.CreateQrCode("Hello my dear friend!");
Console.WriteLine($"qrCode={qrCode}");
Console.ReadKey();
