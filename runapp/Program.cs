using System;
using System.IO;
using Microsoft.Extensions.Configuration;

class Program
{
    static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        IConfiguration configuration = builder.Build();
        AppSettings? settings = configuration.GetSection("appSettings").Get<AppSettings>();

        Console.WriteLine($"App Name: {settings?.AppName ?? "N/A"}");
        Console.WriteLine($"Version: {settings?.Version ?? "N/A"}");
        Console.WriteLine($"URL: {settings?.Url ?? "N/A"}");
    }
}

public class AppSettings
{
    public string AppName { get; set; } = string.Empty;
    public string Version { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}
