using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class TimeLimit : MonoBehaviour
{
    GameSystem instance;
    float time;
    float limitedTime = 5f;  //제한시간
    bool pause;
    [SerializeField] TextMeshProUGUI timeLimit;
    [SerializeField] Slider slider;
    private void Awake()
    {
        instance = GameSystem.instance;
    }
    void Start()
    {
        pause = instance.ispause;
        slider.value = 1;
    }
    void Update()
    {
        if (!pause)
        {
            timeLimit.text = $"Left Time : {(limitedTime-time).ToString("N3")}";
            slider.value -= Time.deltaTime/limitedTime;
            if(time+Time.deltaTime > limitedTime)
            { 
                SceneManager.LoadScene("MainMenu"); Debug.Log("End"); 
            }
            else if (time < limitedTime) time += Time.deltaTime;
        }
    }
}
