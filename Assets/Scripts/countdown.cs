using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countdown : MonoBehaviour
{
    // Play count down audio when there is only 5 seconds left in this scene
    public AudioSource countdownS;

    // Start is called before the first frame update
    void Start()
    {
        countdownS = GetComponent<AudioSource>();
        Invoke("PlaySound", 594.0f);
    }

    void PlaySound(){
        countdownS.Play();
    }
}
