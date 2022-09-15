using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerInGame3 : MonoBehaviour
{
    public GameObject AramaButtonScreen;

    public void AramaButton()
    {
        Time.timeScale = 0;
        AramaButtonScreen.SetActive(true);
    }

    public void ProfilButton()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1;
    }
}
