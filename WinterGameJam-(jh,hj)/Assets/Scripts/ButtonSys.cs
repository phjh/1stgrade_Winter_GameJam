using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSys : MonoBehaviour
{
    public void GameButton()
    {
        SceneManager.LoadScene("InGame");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void MenuButton()
    {

        SceneManager.LoadScene("MainMenu");
    }
    public void RankingButton()
    {
        
    }
}

