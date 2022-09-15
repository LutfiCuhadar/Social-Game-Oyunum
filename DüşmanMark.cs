using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DüşmanMark : MonoBehaviour
{
    public Transform Karakter;
    public bool HareketIznı;
    public float KarakterHız;

    void Start()
    {
        
    }

    void Update()
    {
        if (HareketIznı)
        {
            KarekterKovalama();
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            HareketIznı = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            HareketIznı = false;
        }
    }

    void KarekterKovalama()
    {
        transform.position = Vector3.MoveTowards(transform.position, Karakter.position, KarakterHız * Time.deltaTime);
    }
}
