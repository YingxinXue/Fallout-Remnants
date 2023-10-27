using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateTeleportationRay : MonoBehaviour
{
    // Activate teleportation ray when pressing trigger
    public GameObject rightTeleportation;
    public GameObject leftTeleportation;

    public InputActionProperty rightActivate;
    public InputActionProperty leftActivate;

    // Update is called once per frame
    void Update()
    {
        rightTeleportation.SetActive(rightActivate.action.ReadValue<float>() > 0.1f);
        leftTeleportation.SetActive(leftActivate.action.ReadValue<float>() > 0.1f);
    }
}
