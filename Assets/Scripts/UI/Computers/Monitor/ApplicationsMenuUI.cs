using UnityEngine;
using UnityEngine.UI;

public class ApplicationsMenuUI : MonoBehaviour
{
    [SerializeField]
    private Button doorAppButton;

    [SerializeField]
    private DoorAppUI doorApp;

    private bool isDoorAppEnabled;

    private void Awake()
    {
        doorAppButton.onClick.AddListener(() => SetDoorAppEnabled(!isDoorAppEnabled));

        SetDoorAppEnabled(false);
    }

    private void CloseAll()
    {
        doorApp.gameObject.SetActive(false);
    }

    private void SetDoorAppEnabled(bool enabled)
    {
        CloseAll();
        doorApp.gameObject.SetActive(enabled);
        isDoorAppEnabled = enabled;
    }

    /*
    private void DoorAppEnable()
    {
        Debug.Log("bazinga4");

        if (doorAppCanvas.enabled == false)
        {
            CloseAll();
            doorAppCanvas.enabled = true;
        }
        else
        {
            doorAppCanvas.enabled = false;
        }
    }
    */
}