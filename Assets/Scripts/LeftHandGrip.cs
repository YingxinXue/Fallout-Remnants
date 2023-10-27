using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit; 

public class LeftHandGrip : MonoBehaviour
{
    // Add animation when griping
    private InputDevice leftController;
    // Start is called before the first frame update
    void Start()
    {
        leftController = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
    }

    public Animator gripAnimator;

    // Update is called once per frame
    void Update()
    {
        leftController.TryGetFeatureValue(CommonUsages.trigger, out float grip);
        gripAnimator.SetFloat("Grip",grip);
    }
}
