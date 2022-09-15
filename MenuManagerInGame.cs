using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerInGame : MonoBehaviour
{
    public GameObject AramaButtonScreen;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AramaButton()
    {
        Time.timeScale = 0;
        
        AramaButtonScreen.SetActive(true);
    }

    public void ProfilButton()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
}
