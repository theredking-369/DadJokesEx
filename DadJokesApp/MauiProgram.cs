using Microsoft.Extensions.Logging;
using DadJokesApp.Services;
using DadJokesApp.Views;
using DadJokesApp.ViewModels;
namespace DadJokesApp
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<DadJokeApiService>();
            builder.Services.AddSingleton<DisplayJokesViewModel>();
            builder.Services.AddTransient<DisplayJokesView>();

            return builder.Build();
        }
    }
}
