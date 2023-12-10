using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Order : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5];

        array[0] = 40;
        array[1] = 20;
        array[2] = 50;
        array[3] = 10;
        array[4] = 80;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
