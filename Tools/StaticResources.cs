using System;
using System.IO;

namespace Practice4.Tools
{
    static class StaticResources
    {
        private static readonly string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        internal static readonly string ClientDirPath = Path.Combine(AppData, "WalletSimulator");
        internal static readonly string ClientLogDirPath = Path.Combine(ClientDirPath, "Logs");
    }
}
