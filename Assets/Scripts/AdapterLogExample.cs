using TMPro;
using UnityEngine;

public class AdapterLogExample : MonoBehaviour
{
    public TMP_Text logText;

    private ILogger consoleLogger;
    private ILogger uiLogger;

    void Start()
    {
        ConsoleLogger consoleAdaptee = new ConsoleLogger();
        consoleLogger = new ConsoleLoggerAdapter(consoleAdaptee);

        UILogger uiAdaptee = new UILogger(logText);
        uiLogger = new UILoggerAdapter(uiAdaptee);

        consoleLogger.Log("Game started");
        uiLogger.Log("Game started");
    }
}
