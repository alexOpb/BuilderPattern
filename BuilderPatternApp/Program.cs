using BuilderPatternApp;

var developmentConfig = new ConfigBuilder()
    .SetAppName("App2")
    .SetEnvironment("Development")
    .SetConnectionString("Dev_Connection_String")
    .SetCacheTimeoutSeconds(100)
    .SetMaxConnections(16)
    .EnableLogging(true)
    .EnableTracing(true)
    .Build();

var productionConfig = new ConfigBuilder()
    .SetAppName("App1")
    .SetEnvironment("Production")
    .SetConnectionString("Prod_Connection_String")
    .SetCacheTimeoutSeconds(500)
    .SetMaxConnections(100)
    .EnableLogging(true)
    .EnableTracing(false)
    .Build();

Console.WriteLine(developmentConfig);
Console.WriteLine(productionConfig);

