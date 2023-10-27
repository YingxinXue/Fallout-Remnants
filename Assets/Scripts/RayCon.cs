using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit; 

public class RayCon : MonoBehaviour
{
    // Activate teleportation ray when pushing thumbstick
    public GameObject rightTeleportation;
    public GameObject leftTeleportation;

    // Update is called once per frame
    void Update()
    {
        Vector2 r2DAxis = Vector2.zero;
        Vector2 l2DAxis = Vector2.zero;
        InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.primary2DAxis, out r2DAxis);
        InputDevices.GetDeviceAtXRNode(XRNode.LeftHand).TryGetFeatureValue(CommonUsages.primary2DAxis, out l2DAxis);
        rightTeleportation.SetActive(r2DAxis.x > 0.1f || r2DAxis.y > 0.1f);
        leftTeleportation.SetActive(l2DAxis.x > 0.1f || l2DAxis.y > 0.1f);
    }
}
