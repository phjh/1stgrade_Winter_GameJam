using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSys : MonoBehaviour
{
    public bool EscScenemange;
    public void Gamebutton_st() => SceneManager.LoadScene("Stage");
    public void GameButton() => SceneManager.LoadScene("InGame");
    public void QuitButton() => Application.Quit();
    public void MenuButton()=> SceneManager.LoadScene("MainMenu");
    public void RankingButton()
    {
        
    }
    public void BacktoStage() => GameSystem.instance.StageSelect();
    public void Update()
    {
        if (EscScenemange&&Input.GetKeyDown(KeyCode.Escape))
        {
            EscScenemange = false;
            MenuButton();
        }
    }
}

