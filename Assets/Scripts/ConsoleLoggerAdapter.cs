public class ConsoleLoggerAdapter : ILogger
{
    private ConsoleLogger consoleLogger;

    public ConsoleLoggerAdapter(ConsoleLogger consoleLogger)
    {
        this.consoleLogger = consoleLogger;
    }

    public void Log(string message)
    {
        consoleLogger.WriteToConsole(message);
    }
}