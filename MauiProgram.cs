using MauiApp3.Views.Startup;
using MauiApp3.ViewModels.Startup;
using Microsoft.Extensions.Logging;
using MauiApp3.Views.Homepage;
using MauiApp3.ViewModels.Homepage;

namespace MauiApp3
{
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

            //Views
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<HomePage>();

            builder.Services.AddSingleton<LoginPageViewModel>();
            builder.Services.AddSingleton<HomePageViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}
