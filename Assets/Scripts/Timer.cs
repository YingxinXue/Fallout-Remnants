using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Set 10 min in the scene
    // Update remainning time on the wrist menu
    // Load MainScene when time is up
    public float timerValue = 600;
    private TextMeshProUGUI timerText;

    // Update is called once per frame
    void Update()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        if (timerValue > 0){
            timerValue -= Time.deltaTime;
        }
        else{
            timerValue = 0;
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
        }   
        DisplayTime(timerValue);
    }

    void DisplayTime(float timeToDisplay){
        if (timeToDisplay < 0){
            timeToDisplay = 0;
        }

        float m = Mathf.FloorToInt(timeToDisplay / 60);
        float s = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{00:00}:{1:00}", m, s);
    }
}
