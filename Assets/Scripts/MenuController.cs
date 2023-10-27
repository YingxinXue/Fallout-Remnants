using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuController : MonoBehaviour
{
    // When start button is pressed, change to Home scene
    public AudioSource startSound;
    public void StartBtn(){
        startSound.Play();
        transf();
    }

    public void transf(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Home");
        //UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }
}
