namespace Tyuiu.BerezovskiyAS.Sprint6.Task2.V27
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain_YPV());
        }
    }
}