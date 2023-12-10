using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 10, 20, 30, 50, 60 };

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
