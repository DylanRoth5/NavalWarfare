namespace NavalWarfare
{
    internal static class Program
    {
        public static bool soloOK;
        public static bool coopOK;
        public static Main mainMenu;
        public static gSolo solo;
        public static gCoop coop;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            mainMenu = new Main();
            solo = new gSolo();
            coop = new gCoop();
            Application.Run(mainMenu);

            //soloOK = false;
            //coopOK = false;
            ////aca iria la conexion con la BD
            //if (soloOK)
            //{
            //    Application.Run(new gSolo()); //run solo
            //}
            
            //if (coopOK) 
            //{ 
            //    //run coop 
            //}
        }
    }
}