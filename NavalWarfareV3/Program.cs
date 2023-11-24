using NavalWarfareV3.Conection;
using NavalWarfareV3.Forms;

namespace NavalWarfareV3;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    /// 
    public static MainMenu? MainMenu;

    public static Classic? Classic;
    public static TimeRush? TimeRush;

    [STAThread]
    private static void Main()
    {
        
        ApplicationConfiguration.Initialize();
        MainMenu = new MainMenu();
        Classic = new Classic();
        TimeRush = new TimeRush();
        Conexion.OpenConnection();
        Application.Run(MainMenu);
        Conexion.CloseConnection();
    }
}