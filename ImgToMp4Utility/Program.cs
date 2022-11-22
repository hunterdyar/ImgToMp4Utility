using FFMpegCore;
using System.Diagnostics;
using System.Xml.Linq;

namespace ImgToMp4Utility
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string path = Path.Combine(Path.GetTempPath(), "ffmpeg.exe");
            if (!File.Exists(path))
            {
                File.WriteAllBytes(path, ImgToMp4Utility.Properties.Resources.ffmpeg);
            }
            //Process.Start(path);
            Console.WriteLine("ffmpeg extracted to "+Path.GetTempPath());
            //GlobalFFOptions.Configure(options => options.BinaryFolder = System.AppDomain.CurrentDomain.BaseDirectory+"/Resources
            GlobalFFOptions.Configure(options => options.BinaryFolder = Path.GetTempPath());
            Application.Run(new Form1());

        }
    }
}