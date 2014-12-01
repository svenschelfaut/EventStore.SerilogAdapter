using System;

namespace EventStore.SerilogAdapter
{
    /// <summary>
    /// Adapter to use Serilog Logger in EventStore client.
    /// </summary>
    public class EventStoreSerilogger : ClientAPI.ILogger
    {
        private readonly Serilog.ILogger _seriLogger;

        public EventStoreSerilogger() : this(Serilog.Log.Logger)
        {
        }

        public EventStoreSerilogger(Serilog.ILogger seriLogger)
        {
            _seriLogger = seriLogger;
        }

        /// <summary>
        /// Writes an error to the logger
        /// </summary>
        /// <param name="format">Format string for the log message.</param>
        /// <param name="args">Arguments to be inserted into the format string.</param>
        public void Error(string format, params object[] args)
        {
            _seriLogger.Error(format, args);
        }

        /// <summary>
        /// Writes an error to the logger
        /// </summary>
        /// <param name="ex">A thrown exception.</param>
        /// <param name="format">Format string for the log message.</param>
        /// <param name="args">Arguments to be inserted into the format string.</param>
        public void Error(Exception ex, string format, params object[] args)
        {
            _seriLogger.Error(ex, format, args);
        }

        /// <summary>
        /// Writes an information message to the logger
        /// </summary>
        /// <param name="format">Format string for the log message.</param>
        /// <param name="args">Arguments to be inserted into the format string.</param>
        public void Info(string format, params object[] args)
        {
            _seriLogger.Information(format, args);
        }

        /// <summary>
        /// Writes an information message to the logger
        /// </summary>
        /// <param name="ex">A thrown exception.</param>
        /// <param name="format">Format string for the log message.</param>
        /// <param name="args">Arguments to be inserted into the format string.</param>
        public void Info(Exception ex, string format, params object[] args)
        {
            _seriLogger.Information(ex, format, args);
        }

        /// <summary>
        /// Writes a debug message to the logger
        /// </summary>
        /// <param name="format">Format string for the log message.</param>
        /// <param name="args">Arguments to be inserted into the format string.</param>
        public void Debug(string format, params object[] args)
        {
            _seriLogger.Debug(format, args);
        }

        /// <summary>
        /// Writes a debug message to the logger
        /// </summary>
        /// <param name="ex">A thrown exception.</param>
        /// <param name="format">Format string for the log message.</param>
        /// <param name="args">Arguments to be inserted into the format string.</param>
        public void Debug(Exception ex, string format, params object[] args)
        {
            _seriLogger.Debug(ex, format, args);
        }
    }
}
