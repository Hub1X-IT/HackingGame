using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskTrigger : MonoBehaviour, IInteractable {


    private readonly CameraController.Cameras deskCamera = CameraController.Cameras.DeskCamera;


    public Transform GetTransform() {
        return transform;
    }


    public void Interact() {
        Debug.Log("Desk: Interact()");
        EnterDeskView();
    }


    private void EnterDeskView() {
        CameraController.Instance.SetActiveCamera(deskCamera);
        // change active input preset
    }
}