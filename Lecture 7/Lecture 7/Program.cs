

namespace Lecture_7
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        //enum Direction { Left = 0b1, Right = 0b10, Top = 0b100, Bottom = 0o23, All = 0b1111 }
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var form = new GameForm();
            Console.WriteLine("hekko!");
            Application.Run(form);
        }
    }
}