namespace DepInjecDemo;

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

		// services
        builder.Services.AddSingleton<INameService, NameService>();

		// view models
		builder.Services.AddSingleton<MainViewModel>();

		return builder.Build();
	}
}