using System;
using System.Runtime.InteropServices;
using System.Text;

internal class IniFile
{
    private readonly string path;
    public IniFile(string path = null)
    {
        this.path = new System.IO.FileInfo(path).FullName.ToString();
    }

    [DllImport("kernel32", CharSet = CharSet.Auto)]
    private static extern int GetPrivateProfileSection(string section, IntPtr pointer, int size, string path);

    public string[] GetAllDataSection(string section, int size = 255)
    {
        System.IntPtr pointer = Marshal.AllocHGlobal(4096 * sizeof(char));
        string temp = string.Empty;

        int count = GetPrivateProfileSection(section, pointer, size * sizeof(char), path) - 1;
        if (count > 0) temp = Marshal.PtrToStringUni(pointer, count);
        Marshal.FreeHGlobal(pointer);

        return temp.Split('\0');
    }
}