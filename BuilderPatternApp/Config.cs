namespace BuilderPatternApp;

public class Config
{
    public string AppName { get; set; }
    public string Environment { get; set; }
    public string ConnectionString { get; set; }
    public int CacheTimeoutSeconds { get; set; }
    public int MaxConnections { get; set; }
    public bool EnableLogging { get; set; }
    
    public bool EnableTracing { get; set; }
    
    public override string ToString()
    {
        return $"AppName: {AppName}, Environment: {Environment}, ConnectionString: {ConnectionString}, CacheTimeoutSeconds: {CacheTimeoutSeconds}, MaxConnections: {MaxConnections}, EnableLogging: {EnableLogging}, EnableTracing: {EnableTracing}";
    }
}