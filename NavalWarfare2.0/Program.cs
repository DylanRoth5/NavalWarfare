namespace NavalWarfareV2;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    /// 
    public static MainMenu mainMenu;

    public static Classic clasic;
    public static TimeRush timeRush;

    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        mainMenu = new MainMenu();
        clasic = new Classic();
        timeRush = new TimeRush();
        Application.Run(mainMenu);
    }
}