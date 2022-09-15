using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ÖncekiLevelNext : MonoBehaviour
{
    public float gecitPortalRotation = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * gecitPortalRotation);
    }

    private void OnTriggerEnter2D(Collider2D gecitPortal)
    {
        if(gecitPortal.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
