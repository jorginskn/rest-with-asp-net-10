using Serilog;

namespace RestWithASPNET9Jorge.Configurations;

public static class LoggingConfig
{
  public static void AddSeriloggerConfiguration(this WebApplicationBuilder builder)
  {

        Log.Logger = new LoggerConfiguration()
             .ReadFrom.Configuration(builder.Configuration)
             .Enrich.FromLogContext()
             .WriteTo.Console()
             .WriteTo.Debug()
             .CreateLogger();
        builder.Host.UseSerilog();
    }
}
