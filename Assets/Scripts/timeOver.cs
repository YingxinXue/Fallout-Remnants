using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeOver : MonoBehaviour
{
    // Play time over audio when there is 1 min left
    public AudioSource timeOverS;

    // Start is called before the first frame update
    void Start()
    {
        timeOverS = GetComponent<AudioSource>();
        Invoke("PlaySound", 540.0f);
    }

    void PlaySound(){
        timeOverS.Play();
    }

}
