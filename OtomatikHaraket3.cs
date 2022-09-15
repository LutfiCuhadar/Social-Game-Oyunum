using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtomatikHaraket3 : MonoBehaviour
{
    public GameObject Camera;

    public float speed = 2.0f;

    public Vector3 startPos1;
    public Vector3 startPos2;

    public Transform currentPoint;
    public GameObject platform;

    void Start()
    {
        startPos1 = platform.transform.position;
    }

    void Update()
    {
        platform.transform.position = Vector3.MoveTowards(platform.transform.position, startPos1, Time.deltaTime * speed);

        if (platform.transform.position == startPos1)
        {
            startPos1 = startPos2;
        }

        if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.Space)) 
        {
            Destroy(Camera);
        }
    }
}
