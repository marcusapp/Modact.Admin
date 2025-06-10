using System.Diagnostics;
using System.Reflection;

namespace Modact.Admin
{
    public partial class AppInfo
    {
        public static string? AppCode
        {
            get { return "MODA"; }
        }
        public static string? AppName
        {
            get { return "Modact.Admin"; }
        }
        public static string? AppVersionString
        {
            get
            {
                return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion; //product version
                //return public static string AppCoreVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString(); //assembly version 
                //return public static string AppCoreVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion; //file version  
            }
        }

        public static Version ModactMinimalVersion
        {
            get
            {
                return new Version(1, 8, 2408, 100);
            }
        }    
        public static string? ModactMinimalVersionString
        {
            get
            {
                return ModactMinimalVersion.ToString();
            }
        }        

        public static Version? AppVersion { get { return Assembly.GetExecutingAssembly().GetName().Version; } }
        public static string AppPath { get { try { return AppContext.BaseDirectory; } catch { return string.Empty; } } }
        public static int ProcessId { get { return Process.GetCurrentProcess().Id; } }
        public static int ThreadId { get { return Thread.CurrentThread.ManagedThreadId; } }
    }
}

namespace Modact.API.Fun
{
    public partial class AppInfo : ApiClass
    {
        public AppInfo(ApiFunctionAccessory ApiFunctionAccessory) : base(ApiFunctionAccessory) { }

        public string? AppCode()
        {
            return Modact.Admin.AppInfo.AppCode;
        }
        public string? AppName()
        {
            return Modact.Admin.AppInfo.AppName;
        }
        public string? AppVersion()
        {
            return Modact.Admin.AppInfo.AppVersionString;
        }
        public string? ModactMinimalVersion()
        {
            return Modact.Admin.AppInfo.ModactMinimalVersionString;
        }
    }

}