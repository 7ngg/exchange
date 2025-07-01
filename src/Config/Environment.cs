using Exchange.Entities.Exceptions;
using Exchange.Entities.Options;

namespace Exchange.Config;

public static class EnvironmentExtensions
{
    private static readonly string BinanceKey = "BINANCE_KEY";
    private static readonly string BinanceSecret = "BINANCE_SECRET";

    public static void ConfigureVariables(this IServiceCollection services, IConfiguration config)
    {
        var apiKey =
            config.GetValue<string>(BinanceKey)
            ?? throw new MissingConfigurationException(nameof(BinanceKey));

        var secretKey =
            config.GetValue<string>(BinanceSecret)
            ?? throw new MissingConfigurationException(nameof(BinanceSecret));

        services.Configure<BinanceOptions>(options =>
        {
            options.ApiKey = apiKey;
            options.SecretKey = secretKey;
        });
    }
}
