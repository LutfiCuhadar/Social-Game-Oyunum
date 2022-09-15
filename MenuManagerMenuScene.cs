using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManagerMenuScene : MonoBehaviour
{
    public GameObject oyunCikis; 
   
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OyunGiris()
    {
        SceneManager.LoadScene(1);
    }

    public void OyunCikis()
    {
        Application.Quit();
    }
}
