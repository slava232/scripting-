using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Timer : MonoBehaviour
{
    public int minutes = 3;

    public float seconds = 59.0f;

    public TextMeshProUGUI timer;
    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        timer.text = minutes + ":"+seconds ;
        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                minutes -= 1;
                seconds = 59.0f;
            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
    }
}
