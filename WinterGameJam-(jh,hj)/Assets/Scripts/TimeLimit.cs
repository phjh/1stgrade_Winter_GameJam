using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeLimit : MonoBehaviour
{
    float time=0;
    float limitedTime = 5f;  //제한시간
    bool pause;
    [SerializeField] TextMeshProUGUI timeLimit;
    void Start()
    {
        pause = false;
    }
    void Update()
    {
        if (!pause)
        {
            timeLimit.text = $"Left Time : {(limitedTime-time).ToString("N3")}";
            if(time+Time.deltaTime > limitedTime)
            { 
                SceneManager.LoadScene("MainMenu"); Debug.Log("End"); 
            }
            else if (time < limitedTime) time += Time.deltaTime;
        }
    }
}
