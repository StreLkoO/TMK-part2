using TMK_plus_plus.Classes;
using TMK_plus_plus.Interfaces;

namespace TMK_plus_plus
{
    internal static class Program
    {
        public static IPipeRepo PipeReader;
        public static List<string> SteelGrades = new()
        {
            "ñò2ñï", "ñò4ñï", "ñò5ñï", "ñò6ñï", "10",
            "20", "35", "45", "10Ã2", "20Õ", "40Õ",
            "30ÕÃÑÀ", "15ÕÌ", "30ÕÌÀ", "12ÕÍ2", "09Ã2Ñ"
        };
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pipes.xml");
            PipeReader = new PipeXmlReader(path);
            Application.Run(new MainForm());
        }
    }
}