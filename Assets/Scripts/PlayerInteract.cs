using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {


    [SerializeField] private Transform cameraFollowObject;


    [SerializeField] private LayerMask interactableLayerMask;


    private readonly float raycastInteractRange = 10f;


    // private float interactRange = 2f;


    private void Start() {
        GameInput.Instance.OnInteractAction += GameInput_OnInteractAction;
    }


    private void GameInput_OnInteractAction(object sender, System.EventArgs e) {
        Debug.Log("Interact");
        IInteractable interactable = GetInteractableObject();
        interactable?.Interact(); // ? -> Check if not null
    }

    /*
    public IInteractable GetInteractableObject() {
        List<IInteractable> interactableList = new List<IInteractable>();
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray) {
            if (collider.TryGetComponent(out IInteractable interactable)) {
                interactableList.Add(interactable);
            }
        }

        IInteractable closestInteractable = null;
        foreach (IInteractable interactable in interactableList) {
            if (closestInteractable == null) {
                closestInteractable = interactable;
            }
            else {
                // Calculate and compare distance
                if ((transform.position - interactable.GetTransform().position).sqrMagnitude < 
                    (transform.position - closestInteractable.GetTransform().position).sqrMagnitude) {
                    // Closer
                    closestInteractable = interactable;
                }
            }
        }

        return closestInteractable;
    }
    */


    private void Update() {
        // Debug.Log(cameraFollowObject.rotation.eulerAngles);
    }


    public IInteractable GetInteractableObject() {
        Debug.DrawRay(cameraFollowObject.position, cameraFollowObject.forward, Color.red, raycastInteractRange);

        if (Physics.Raycast(cameraFollowObject.position, 
            cameraFollowObject.forward,
            out RaycastHit hit, raycastInteractRange)) {

            Debug.Log(hit.transform.gameObject);

            if (hit.transform.gameObject.TryGetComponent<IInteractable>(out IInteractable interactable)) {
                return interactable;
            }
            interactable = hit.transform.gameObject.GetComponentInParent<IInteractable>();
            return interactable;            
        }
        return null;
    }
}