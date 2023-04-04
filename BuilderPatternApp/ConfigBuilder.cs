namespace BuilderPatternApp;

public class ConfigBuilder
{
    private Config _config;

    public ConfigBuilder()
    {
        _config = new Config();
    }

    public ConfigBuilder SetAppName(string appName)
    {
        _config.AppName = appName;
        return this;
    }

    public ConfigBuilder SetEnvironment(string environment)
    {
        _config.Environment = environment;
        return this;
    }

    public ConfigBuilder SetConnectionString(string connectionString)
    {
        _config.ConnectionString = connectionString;
        return this;
    }

    public ConfigBuilder SetCacheTimeoutSeconds(int cacheTimeoutSeconds)
    {
        _config.CacheTimeoutSeconds = cacheTimeoutSeconds;
        return this;
    }

    public ConfigBuilder SetMaxConnections(int maxConnections)
    {
        _config.MaxConnections = maxConnections;
        return this;
    }

    public ConfigBuilder EnableLogging(bool enableLogging)
    {
        _config.EnableLogging = enableLogging;
        return this;
    }

    public ConfigBuilder EnableTracing(bool enableTracing)
    {
        _config.EnableTracing = enableTracing;
        return this;
    }

    public Config Build()
    {
        return _config;
    }
}
