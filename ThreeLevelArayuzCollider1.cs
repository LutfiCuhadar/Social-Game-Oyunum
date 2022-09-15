using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThreeLevelArayuzCollider1 : MonoBehaviour
{
 private void OnTriggerEnter2D(Collider2D arayuz)
    {
        if (arayuz.tag == "Player")
        {
            SceneManager.LoadScene(9);
        }
    }
}
