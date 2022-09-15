using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public float bulletDamage, lifeTime;

    public float bulletRotation = -15.0f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update() 
    {
        transform.Rotate(Vector3.forward * bulletRotation);
    }

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.tag == "Bullet") 
        {
            bulletRotation = 0f; 
        } else
        { 
            bulletRotation = -15.0f; 
            Update(); 
        }
    }
}
