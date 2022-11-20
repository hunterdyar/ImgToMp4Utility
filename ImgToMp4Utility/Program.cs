using FFMpegCore;

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
            GlobalFFOptions.Configure(options => options.BinaryFolder = System.AppDomain.CurrentDomain.BaseDirectory+"/Resources/");
            Application.Run(new Form1());
        }
    }
}