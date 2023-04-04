# BuilderPattern

To run: just run a console app.

The builder design pattern is used to create different configurations for various environments, such as development and production.
The builder design pattern separates the creation and representation of the `Config` object.
Method chaning is a more readable and expressive syntax for creating objects, than using constructor overloads.

1. `ConfigBuilder` class is used to constrcut the `Config` object.
2. `ConfigBuilder`contains methods for setting each property of the `Config` object.
3. These methods return the `ConfigBuilder` itself to allow for method chaining.
4. `Build` method is called at the end of the chain to create the final `Config` object.

Outputs:
```
AppName: App2, Environment: Development, ConnectionString: Dev_Connection_String, CacheTimeoutSeconds: 100, MaxConnections: 16, EnableLogging: True, EnableTracing: True
AppName: App1, Environment: Production, ConnectionString: Prod_Connection_String, CacheTimeoutSeconds: 500, MaxConnections: 100, EnableLogging: True, EnableTracing: False
```
