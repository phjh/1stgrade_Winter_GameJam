using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class TimeLimit : MonoBehaviour
{
    float time;
    float limitedTime = 30f;  //제한시간
    bool pause;
    [SerializeField] TextMeshProUGUI timeLimit;
    [SerializeField] Slider slider;
    void Start()
    {
        slider.value = 1;
    }
    void Update()
    {
        pause = GameSystem.instance.ispause;
        if (!pause)
        {
            timeLimit.text = $"Left Time : {(limitedTime-time).ToString("N3")}";
            slider.value -= Time.deltaTime/limitedTime;
            if(time+Time.deltaTime > limitedTime)
            { 
                SceneManager.LoadScene("MainMenu");
            }
            else if (time < limitedTime) time += Time.deltaTime;
        }
    }
}
