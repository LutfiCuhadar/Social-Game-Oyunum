using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesajDestroy : MonoBehaviour
{
    public GameObject MesajOne, MesajTwo, MesajThree, MesajFour, MesajFive,
                      MesajSix, MesajSeven, MesajEight, MesajNine, MesajTen,
                      MesajEleven, MesajTwenty, MesajThreeTeen;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Destroy(this.gameObject, 1);
            Destroy(MesajOne, 2.2f);
            Destroy(MesajTwo, 3.5f);
            Destroy(MesajThree, 4.7f);
            Destroy(MesajFour, 5.9f);
            Destroy(MesajFive, 7.1f);
            Destroy(MesajSix, 8.3f);
            Destroy(MesajSeven, 10.5f);
            Destroy(MesajEight, 11.7f);
            Destroy(MesajNine, 12.5f);
            Destroy(MesajTen, 13.7f);
            Destroy(MesajEleven, 15.4f);
            Destroy(MesajTwenty, 16.6f);
            Destroy(MesajThreeTeen, 17.8f);
        }
    }
}
