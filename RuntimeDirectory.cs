using System.Runtime.InteropServices;

namespace QRCodeLinux;

public static class RuntimeDirectory
{
    public static string GetRuntimeDirectory(string path)
    {
        if (IsLinuxRunTime())
            return GetLinuxDirectory(path);
        if (IsWindowRunTime())
            return GetWindowDirectory(path);
        return path;
    }

    public static bool IsWindowRunTime()
    {
        return System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
    }

    public static bool IsLinuxRunTime()
    {
        return System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
    }

    public static string GetLinuxDirectory(string path)
    {
        string pathTemp = Path.Combine(path);
        return pathTemp.Replace("\\", "/");
    }
    public static string GetWindowDirectory(string path)
    {
        string pathTemp = Path.Combine(path);
        return pathTemp.Replace("/", "\\");
    }
}