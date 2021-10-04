using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMN : MonoBehaviour
{
    
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;
    public GameObject BackgroundText;
    public GameObject Text;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        BackgroundText.SetActive(true);
        Text.SetActive(true);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void Pause()
    {
        BackgroundText.SetActive(false);
        Text.SetActive(false);
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Menu(){
        Application.LoadLevel("Menu");
    }

    
    public void ExitGame()
    {
        Application.Quit();
    }
}
