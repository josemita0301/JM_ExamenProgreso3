using JM_ExamenProgreso3.JM_Data;

namespace JM_ExamenProgreso3;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        string dbPath = JM_FileAccessHelper.GetLocalFilePath("JM_ExamenPerrosDatabase.db3");
        builder.Services.AddSingleton<JM_ExamenDatabase>(s => ActivatorUtilities.CreateInstance<JM_ExamenDatabase>(s, dbPath));


        return builder.Build();
	}
}
