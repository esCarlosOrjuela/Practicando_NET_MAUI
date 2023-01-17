using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace Aprendiendo_Net_MAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.UseMauiApp<App>().UseMauiCommunityToolkit();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Creamer .ttf", "Creamer");
                fonts.AddFont("fontello.ttf", "FontelloIcon");
                fonts.AddFont("Bison-Bold(PersonalUse).ttf", "Bison");
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}

