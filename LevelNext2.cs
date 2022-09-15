using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNext2 : MonoBehaviour
{
    public float gecitPortalRotation2 = 10.0f;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * gecitPortalRotation2);
    }

    private void OnTriggerEnter2D(Collider2D gecitPortalRotation2)
    {
        if(gecitPortalRotation2.tag == "Player")
        {
            SceneManager.LoadScene(10);
        }
    }
}
