using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit; 

public class RightHandGrip : MonoBehaviour
{
    // Add animation when griping
    private InputDevice rightController;
    // Start is called before the first frame update
    void Start()
    {
        rightController = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }

    public Animator gripAnimator;

    // Update is called once per frame
    void Update()
    {
        rightController.TryGetFeatureValue(CommonUsages.trigger, out float grip);
        gripAnimator.SetFloat("Grip",grip);
    }
}
