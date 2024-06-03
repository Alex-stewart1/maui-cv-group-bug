using MemoryToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace MauiGroupedCollectionMemoryLeak
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

            // Configure logging
            builder.Logging.AddDebug();

            builder.UseLeakDetection();

            return builder.Build();
        }
    }
}
