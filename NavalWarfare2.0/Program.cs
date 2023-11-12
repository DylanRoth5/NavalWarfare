using NavalWarfare2._0.Forms;

namespace NavalWarfareV2;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    /// 
    public static MainMenu? mainMenu;

    public static Classic? classic;
    public static TimeRush? timeRush;

    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        mainMenu = new MainMenu();
        classic = new Classic();
        timeRush = new TimeRush();
        Application.Run(mainMenu);
    }
}