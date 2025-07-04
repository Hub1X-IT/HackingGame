using UnityEngine;

public class MonitorAppUI : MonoBehaviour
{
    [SerializeField]
    private AppTitleBarUI titleBar;

    private MonitorAppsManagerUI currentMonitorAppManager;

    public MonitorAppsManagerUI CurrentMonitorAppManager => currentMonitorAppManager;

    // Temporary
    public bool DestroyOnClose { get; set; }

    public void InitializeApp(MonitorAppsManagerUI monitorAppManager)
    {
        currentMonitorAppManager = monitorAppManager;
        titleBar.AppCloseTriggered += CloseApp;
        DestroyOnClose = true;
    }

    public void SetAppName(string appName)
    {
        gameObject.name = name = appName;
        titleBar.SetAppName(appName);
    }

    public void CloseApp()
    {
        Debug.Log($"Close app: {gameObject.name}");
        gameObject.SetActive(false);

        if (DestroyOnClose)
        {
            Destroy(gameObject);
        }
    }
}