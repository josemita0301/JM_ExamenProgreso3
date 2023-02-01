namespace JM_ExamenProgreso3;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(JM_Views.JM_Registrar), typeof(JM_Views.JM_Registrar));
        Routing.RegisterRoute(nameof(JM_Views.JM_PáginaPrincipal), typeof(JM_Views.JM_PáginaPrincipal));
    }
}
