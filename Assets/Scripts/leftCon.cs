using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.XR.PXR.PXR_Input;
using Unity.XR.PXR;

public class leftCon : MonoBehaviour
{
    // Set haptic impulse
    public Controller controllerL;
    
    public void GetMessage(){
        PXR_Input.SetControllerVibration(0.3f, 1000, controllerL);
    }
}
