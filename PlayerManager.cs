using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public float health, bulletSpeed;

    bool dead = false;

    Transform muzzle;

    public Transform bullet;

    public Slider slider;

    public AudioClip TypeSound;
    AudioSource audSrc;

    void Awake()
    {
        audSrc = GetComponent<AudioSource>();
    }
    void Start()
    {
        muzzle = transform.GetChild(1);
        slider.maxValue = health;
        slider.value = health;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBullet();
            audSrc.PlayOneShot(TypeSound);
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
        slider.value = health;
        AmIDead();
    }

    void AmIDead()
    {
        if (health <= 0)
        {
            dead = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        } 
    }

    void ShootBullet()
    {
        Transform tempBullet;
        tempBullet = Instantiate(bullet, muzzle.position, Quaternion.identity); 
        tempBullet.GetComponent<Rigidbody2D>().AddForce(muzzle.forward * bulletSpeed);
    }
}
