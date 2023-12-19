using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using FruitVegBasket.Services;
using FruitVegBasket.ViewModels;
using FruitVegBasket.Pages;

namespace FruitVegBasket
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
                })

            .UseMauiCommunityToolkit();

            builder.Services.AddSingleton<HomePageViewModel>();
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<CategoryService>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}