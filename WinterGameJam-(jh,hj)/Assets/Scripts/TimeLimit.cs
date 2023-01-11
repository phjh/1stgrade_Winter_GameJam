using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class TimeLimit : MonoBehaviour
{
    public static TimeLimit tInstance;
    private void Awake()
    {
        tInstance = this;
    }
    float time=0;
    float limitedTime = 4f;  //제한시간
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
            timeLimit.text = $"{(limitedTime-time).ToString("N3")}";
            //timeLimit.text = $"Left Time : {(limitedTime - time).ToString("N3")}";
            slider.value -= Time.deltaTime/limitedTime;
            if (time + Time.deltaTime > limitedTime)
            {
                GameSystem.instance.Ranking();
            }
            else if (time < limitedTime) time += Time.deltaTime;
        }
    }
    public void Correct()
    {
        limitedTime -= 0.05f;
        slider.value = 1;
        time = 0;
    }
}
