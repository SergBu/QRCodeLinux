using QRCodeLinux;

var qrCode = BarcodeGenerator.CreateQrCode("Hello my dear дружок!");
Console.WriteLine($"qrCode={qrCode}");
Console.ReadKey();
