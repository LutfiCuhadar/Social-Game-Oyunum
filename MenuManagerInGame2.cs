using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManagerInGame2 : MonoBehaviour
{
    public GameObject InGameScreen, PauseScreen;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        InGameScreen.SetActive(false);
        PauseScreen.SetActive(true);
    }

    public void PlayButton()
    {
        Time.timeScale = 1;
        PauseScreen.SetActive(false);
        InGameScreen.SetActive(true);
    }

    public void ReplayButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void HomeButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
