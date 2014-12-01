using EventStore.ClientAPI;

namespace EventStore.SerilogAdapter
{
    /// <summary>
    /// Extensions to use on <see cref="ConnectionSettingsBuilder"/>
    /// </summary>
    public static class ConnectionSettingsExtensions
    {
        /// <summary>
        /// Uses serilog logger.
        /// </summary>
        /// <param name="connectionSettingsBuilder">The connection settings builder.</param>
        /// <returns></returns>
        public static ConnectionSettingsBuilder UseSerilog(this ConnectionSettingsBuilder connectionSettingsBuilder)
        {
            return connectionSettingsBuilder.UseCustomLogger(new EventStoreSerilogger());
        }

        /// <summary>
        /// Uses serilog logger.
        /// </summary>
        /// <param name="connectionSettingsBuilder">The connection settings builder.</param>
        /// <param name="seriLogger">Serilog logger</param>
        /// <returns></returns>
        public static ConnectionSettingsBuilder UseSeriLog(this ConnectionSettingsBuilder connectionSettingsBuilder, Serilog.ILogger seriLogger)
        {
            return connectionSettingsBuilder.UseCustomLogger(new EventStoreSerilogger(seriLogger));
        }
    }
}