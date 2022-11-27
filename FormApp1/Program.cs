namespace FormApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var log =string.Empty;
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(new Form1());
            }
           catch (OwnExepction ex)
            {
                log = ex.Message;
            }
            catch(Exception ex)
            {
                log = ex.Message;
            }
        }
    }
}