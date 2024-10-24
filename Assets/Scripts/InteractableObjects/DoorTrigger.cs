using System;
using UnityEngine;

public class DoorTrigger : MonoBehaviour, IInteractable {  

    public event EventHandler OnDoorInteract;

    private InteractionVisual interactionVisual;

    private void Start() {
        // gameObject.layer = InteractionController.Instance.DefaultInteractableLayerMask;
    }


    public void Interact() {
        OnDoorInteract?.Invoke(this, EventArgs.Empty);
    }

    public void SetInteractionVisual(InteractionVisual interactionVisual) { this.interactionVisual = interactionVisual; } // may not be an optimal solution

    public InteractionVisual GetInteractionVisual() { return interactionVisual; }

    public Transform GetTransform() { return transform; }
}
