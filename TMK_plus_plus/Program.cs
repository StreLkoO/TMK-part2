using TMK_plus_plus.Classes;
using TMK_plus_plus.Interfaces;

namespace TMK_plus_plus
{
    internal static class Program
    {
        public static IPipeRepo PipeReader;
        public static List<string> SteelGrades = new()
        {
            "��2��", "��4��", "��5��", "��6��", "10",
            "20", "35", "45", "10�2", "20�", "40�",
            "30����", "15��", "30���", "12��2", "09�2�"
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