using CollectionViewDemo.ViewModels;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace CollectionViewDemo
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
            ConfigureCulture();
            ConfigureServices(builder.Services);

            return builder.Build();
        }

        private static void ConfigureCulture()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-NG");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-NG");
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<DataPageViewModel>();
            services.AddSingleton<ProductsViewPageModel>();
        }
    }
}
