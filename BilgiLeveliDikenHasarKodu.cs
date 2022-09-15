using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BilgiLeveliDikenHasarKodu : MonoBehaviour
{
    private float health;
    public float damage;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerManager>().GetDamage(damage);
            SceneManager.LoadScene(6);
        }
    }

    public void GetDamage(float damage)
    {

        if ((health - damage) >= 0)
        {
            health -= damage;
        }
        else
        {
            health = 0;
        }
    }
}
