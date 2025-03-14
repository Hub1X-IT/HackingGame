using UnityEngine;

public abstract class FileSO : DataContainerSO 
{
    [SerializeField]
    private GameEventSO onTryOpenFileGameEvent;

    [SerializeField]
    private GameEventSO onOpenFileGameEvent;

    public void TriggerOnTryOpenEvent()
    {
        if (onTryOpenFileGameEvent != null)
        {
            onTryOpenFileGameEvent.TryRaiseEvent();
        }
    }

    public void TriggerOnOpenEvent()
    {
        if (onOpenFileGameEvent != null)
        {
            onOpenFileGameEvent.TryRaiseEvent();
        }
    }
}
