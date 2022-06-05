using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour
{
    int x = 5;
    int y = 2;
    string username = "bachra";
    void Start()
    {
        Debug.Log(x);
        Debug.Log(y);
        int z = x * y;
        Debug.Log(z);
        y = y + 1;
        Debug.Log("HELLO " + username + " you have " + x + " lives");
        Debug.Log(5==3);
        Debug.Log(1 < 2);
        Debug.Log(2 < 1);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Debug.Log(x);
    }
}
