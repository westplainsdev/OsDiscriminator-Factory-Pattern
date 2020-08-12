using System.Collections.Generic;

namespace UnderstandOOP
{
    public static class Options
    {
        public static readonly Dictionary<string, string> OperatingSystem = new Dictionary<string, string>()
        {
            {"MS_DOS", "MS DOS"},
            {"WIDOWS10", "Windows 10"},
            {"WIDOWS8", "Windows 8.1"},
            {"WIDOWS7", "Windows 7"},
            {"UBUNTU", "Ubuntu Linux"},
            {"MAC_OS", "Mac OS"},
            {"FEDORA","Fedora Linux"},
            {"MINT", "Mint Linux"},
            {"SUN_OS", "SunOS"},
        };
    }
}