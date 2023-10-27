using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuCon : MonoBehaviour
{
    // Play new canvas and audio
    public GameObject q1;
    public GameObject menu2;
    public AudioSource welcome;
    void Start()
    {
        Invoke("playWel", 4.0f);
    }

    // Update is called once per frame
    void playWel()
    {
        welcome.Play();
        Invoke("q1Act", 15.0f);
    }

    void q1Act()
    {
        menu2.SetActive(false);
        q1.SetActive(true);
    }
}
