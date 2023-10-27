using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class answer : MonoBehaviour
{
    // Check the player's answers, play related audio and activate new canvas
    // Transfor to end scene
    public GameObject q3;
    public GameObject succ;
    public GameObject fail;
    public AudioSource suS;
    public AudioSource faS;
    private int c=3;
    // Start is called before the first frame update

    public void GetMessageAns(){
        c = c-1;
    }

    public void countNum(){
        q3.SetActive(false);
        if (c == 3){
            succ.SetActive(true);
            suS.Play();
        }
        else{
            fail.SetActive(true);
            faS.Play();
        }
        Invoke("sceneTrans", 8.0f);
    }

    void sceneTrans(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("End");
    }
}
