using JM_ExamenProgreso3.JM_Data;

namespace JM_ExamenProgreso3;

public partial class App : Application
{
    public static JM_ExamenDatabase ExamenDatabase { get; set; }
    public App(JM_ExamenDatabase repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        ExamenRepo = repo;
    }
}
