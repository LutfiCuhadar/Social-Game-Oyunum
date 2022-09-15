using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BilgiManager : MonoBehaviour
{
    public GameObject BilgiScreen;
    public GameObject BilgiScreen2;
    
    void Start()
    {
        Time.timeScale = 0;
    }

    public void DevamButton()
    {
        BilgiScreen.SetActive(false);
        BilgiScreen2.SetActive(true);
    }

    public void XButton()
    {
        BilgiScreen2.SetActive(false);
        Time.timeScale = 1;
    }
}
