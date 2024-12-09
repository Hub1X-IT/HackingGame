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

    public bool CanEnterComputerView { get; set; }

    public bool IsComputerEnabled { get; set; }


    private void Awake()
    {
        desk = GetComponentInParent<Desk>();
        outline = GetComponent<Outline>();

        computerTrigger.InteractVisual = GetComponent<InteractionVisual>();

        computerTrigger.InteractionTriggered += () => SetComputerViewActive(true);

        desk.DeskViewEnabled += (enabled) =>
        {
            CanEnterComputerView = enabled;
            ToggleComputerTrigger();
        };

        GameInput.OnComputerExitAction += () =>
        {
            if (isInComputerView && CanExitComputerView)
            {
                SetComputerViewActive(false);
            }
        };

        computerCinemachineCamera.enabled = false;


        isInComputerView = false;

        CanExitComputerView = true;
        CanEnterComputerView = false;
        IsComputerEnabled = false;

        ToggleComputerTrigger();
    }

    private void SetComputerViewActive(bool active)
    {
        isInComputerView = active;

        PlayerScriptsController.SetCanShowPlayerHUD(!active);

        desk.CanExitDeskView = !active;
        desk.SetDeskCameraRotationEnabled(!active);

        ToggleComputerTrigger();

        // Probably a temporary solution
        outline.enabled = !active;

        ComputerViewEnabled?.Invoke(active);

        GameManager.HiddenCursorLockMode = active ? CursorLockMode.Confined : CursorLockMode.Locked;
        GameManager.SetCursorShown(false);

        if (active)
        {
            GameInput.PlayerInputActions.Computer.Enable();
            CameraController.SetActiveCinemachineCamera(computerCinemachineCamera);
            computerViewEnabledGameEvent.RaiseEvent(this);
        }
        else
        {
            GameInput.PlayerInputActions.Computer.Disable();
            CameraController.SetActiveCinemachineCamera(desk.DeskCinemachineCamera);
            computerViewDisabledGameEvent.RaiseEvent();
        }
    }

    public void ToggleComputerTrigger()
    {
        computerTrigger.gameObject.SetActive(!isInComputerView && CanEnterComputerView && IsComputerEnabled);
    }
}
