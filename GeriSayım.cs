using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GeriSayım : MonoBehaviour
{
    public float zaman;
    public Text zamanText;

    void Start()
    {
        zaman = 25;
        zamanText.text = "" + (int)zaman;
    }

    void Update()
    {
        zaman -= Time.deltaTime;
        zamanText.text = "" + (int)zaman;
        if(zaman <= 0)
        {
            zaman = 0;
            zamanText.text = "" + (int)zaman;
            SceneManager.LoadScene(4);
        }
    }
}
