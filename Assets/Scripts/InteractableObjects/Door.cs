using UnityEngine;

public class Door : MonoBehaviour, IInteractable {

    [SerializeField] private Animator doorAnimator;


    private const string DOOR_OPEN_TRIGGER = "DoorOpen";
    private const string DOOR_CLOSE_TRIGGER = "DoorClose";


    private bool doorOpened;

    
    public void Awake() {
        doorAnimator = GetComponent<Animator>();
        doorOpened = false;
    }


    public void Interact() {
        OpenClose();
    }


    private void OpenClose() {
        if (!doorOpened) { // open door
            doorAnimator.SetTrigger(DOOR_OPEN_TRIGGER);
        }
        
        else { // close door
            doorAnimator.SetTrigger(DOOR_CLOSE_TRIGGER);
        }
        doorOpened = !doorOpened;
        
    }

    public InteractionVisual GetInteractionVisual() { return null; }

    public Transform GetTransform() { return transform; }
}
