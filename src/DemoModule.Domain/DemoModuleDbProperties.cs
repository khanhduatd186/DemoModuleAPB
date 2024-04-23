namespace DemoModule;

public static class DemoModuleDbProperties
{
    public static string DbTablePrefix { get; set; } = "DemoModule";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "DemoModule";
}
