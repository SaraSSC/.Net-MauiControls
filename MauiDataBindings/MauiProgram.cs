using Microsoft.Extensions.Logging;

namespace MauiDataBindings
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
                    fonts.AddFont("AfacadFlux-Black.ttf", "AfacadBlack");
                    fonts.AddFont("AfacadFlux-Bold.ttf", "AfacadBold");
                    fonts.AddFont("AfacadFlux-Light.ttf", "AfacadLight");
                    fonts.AddFont("AfacadFlux-Regular.ttf", "AfacadRegular");
                    fonts.AddFont("fontello.tff", "IconsFont");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
