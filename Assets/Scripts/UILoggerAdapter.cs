public class UILoggerAdapter : ILogger
{
    private UILogger uiLogger;

    public UILoggerAdapter(UILogger uiLogger)
    {
        this.uiLogger = uiLogger;
    }

    public void Log(string message)
    {
        uiLogger.WriteToUI(message);
    }
}