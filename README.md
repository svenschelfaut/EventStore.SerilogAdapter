EventStore.SerilogAdapter
=========================
This small library enables you to use Serilog (http://serilog.net) as a logger for Greg Young's EventStore (http://geteventstore.com)
<h1>Usage</h1>

Extensions method ```UseSerilog``` is available on ```ConnectionSettingsBuilder```.

This will use the default logger from Serilog ```Log.Logger```:

    var connectionSettings =
      ConnectionSettings
        .Create()
        .UseSerilog()       
        ...
        .Build();

It is also possible to pass a SeriLog ```ILogger``` instance:

    var connectionSettings =
      ConnectionSettings
        .Create()
        .UseSerilog(loggerInstance)        
        ...
        .Build();

<h1>Dependencies</h1>
* <a href="https://www.nuget.org/packages/Serilog/">Serilog</a>
* <a href="https://www.nuget.org/packages/EventStore.Client/">EventStore.Client</a>


