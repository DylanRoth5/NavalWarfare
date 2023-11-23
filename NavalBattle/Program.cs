using System.Net.Mime;
using NavalBattle.Controlers;
using NavalBattle.Entities;

namespace NavalBattle;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    public static bool Logged;
    public static Forms.Login? Login;
    public static Forms.MainMenu? Menu;
    public static Forms.Classic? Classic;
    public static Forms.TimeRush? TimeRush;
    public static User? CurrentUser;
    public static bool NewMatch;

    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        Conexion.OpenConnection();
        ApplicationConfiguration.Initialize();
        Login = new Forms.Login();
        Menu = new Forms.MainMenu();
        TimeRush = new Forms.TimeRush();
        Application.Run(Login);
        Classic = new Forms.Classic();
        if (Logged) Application.Run(Menu);
        Conexion.CloseConnection();
    }
}