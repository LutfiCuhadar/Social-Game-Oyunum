using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaşTrigger : MonoBehaviour
{
 private void OnTriggerEnter2D(Collider2D taş)
    {
        if (taş.tag == "Player")
        {
            SceneManager.LoadScene(11);
        }
    }
}
