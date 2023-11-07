using System.Collections.Generic;

namespace UnderstandOOP
{
    public static class OperatingSystems
    {
        public static readonly Dictionary<string, string> Options = new Dictionary<string, string>()
        {
            {"MS_DOS", "MS DOS"},
            {"WINDOWS11", "Windows 11"},
            {"WINDOWS10", "Windows 10"},
            {"WINDOWS8", "Windows 8.1"},
            {"WINDOWS7", "Windows 7"},
            {"UBUNTU", "Ubuntu Linux"},
            {"MAC_OS", "Mac OS"},
            {"FEDORA","Fedora Linux"},
            {"MINT", "Mint Linux"},
            {"SUN_OS", "SunOS"},
        };
    }
}