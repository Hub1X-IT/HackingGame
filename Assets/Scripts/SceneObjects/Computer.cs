using System;
using Unity.Cinemachine;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public event Action<bool> ComputerViewEnabled;

    private Desk desk;

    [SerializeField]
    private GameEventComputerSO computerViewEnabledGameEvent;

    [SerializeField]
    private GameEventSO computerViewDisabledGameEvent;

    [SerializeField]
    private InteractionTrigger computerTrigger;

    [SerializeField]
    private CinemachineCamera computerCinemachineCamera;

    private Outline outline;

    private bool isInComputerView;

    public bool CanExitComputerView { get; set; }


    private void Awake()
    {
        desk = GetComponentInParent<Desk>();
        outline = GetComponent<Outline>();

        /*
        computerTrigger = GetComponentInChildren<InteractionTrigger>();
        computerCinemachineCamera = GetComponentInChildren<CinemachineCamera>();
        */

        computerTrigger.InteractVisual = GetComponent<InteractionVisual>();

        computerTrigger.InteractionTriggered += () => SetComputerViewActive(true);

        desk.DeskViewEnabled += SetComputerTriggerEnabled;

        GameInput.OnComputerExitAction += () =>
        {
            if (isInComputerView && CanExitComputerView)
            {
                SetComputerViewActive(false);
            }
        };

        computerCinemachineCamera.enabled = false;

        SetComputerTriggerEnabled(false);

        isInComputerView = false;

        CanExitComputerView = true;
    }

    private void SetComputerViewActive(bool active)
    {
        isInComputerView = active;

        PlayerScriptsController.SetCanShowPlayerHUD(!active);

        desk.CanExitDeskView = !active;
        desk.SetDeskCameraRotationEnabled(!active);

        SetComputerTriggerEnabled(!active);

        // Probably a temporary solution
        outline.enabled = !active;

        ComputerViewEnabled?.Invoke(active);

        if (active)
        {
            GameInput.PlayerInputActions.Computer.Enable();
            CameraController.SetActiveCinemachineCamera(computerCinemachineCamera);
            Cursor.lockState = CursorLockMode.Confined;
            computerViewEnabledGameEvent.RaiseEvent(this);
        }
        else
        {
            GameInput.PlayerInputActions.Computer.Disable();
            CameraController.SetActiveCinemachineCamera(desk.DeskCinemachineCamera);
            GameManager.SetCursorShown(false);
            computerViewDisabledGameEvent.RaiseEvent();
        }
    }

    private void SetComputerTriggerEnabled(bool enabled)
    {
        computerTrigger.gameObject.SetActive(enabled);
    }
}