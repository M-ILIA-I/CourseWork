using CourseWork.Pages;
using CourseWork.Services;
using CourseWork.ViewModel;
using Microsoft.Extensions.Logging;
using Mopups.Hosting;

namespace CourseWork;

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

#if DEBUG
		builder.Logging.AddDebug();
		builder.Services.AddSingleton<FindToursViewModel>();
		builder.Services.AddSingleton<ToursPage>();
		builder.Services.AddSingleton<UserPageViewModel>();
		builder.Services.AddSingleton<DetailUserPage>();
		builder.Services.AddSingleton<AdminPage>();
		builder.Services.AddSingleton<AddTourService>();
		builder.Services.AddSingleton<FindTourService>();
		builder.Services.AddSingleton<UserDBService>();
		builder.Services.AddSingleton<UserToursViewModel>();
        builder.Services.AddSingleton<DetailUserToursPage>();
		builder.Services.AddSingleton<Search>();
		builder.Services.AddSingleton<SignUpPages>();
		builder.Services.AddSingleton<UserPage>();
		builder.Services.AddSingleton<Tourhunter>();
#endif

        return builder.Build();
	}
}
