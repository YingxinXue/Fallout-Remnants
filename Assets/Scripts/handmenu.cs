using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handmenu : MonoBehaviour
{
    // Activate hand scanning menu after 4 seconds
    public GameObject handm;
    void Start()
    {
        Invoke("handmActive", 4.0f);
    }

    // Update is called once per frame
    void handmActive()
    {
        handm.SetActive(true);
    }
}
