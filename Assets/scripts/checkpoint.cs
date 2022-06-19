using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Sum(4,5)) ;
        Debug.Log(Prod(7, 9));
        Debug.Log(divi(5, 2));
    }

    void Update()
    {
        
    }

    float Sum(float a, float b)
    {
        return a + b;
    }
    float Prod(float a,float b)
    {
        return a * b;
     }
    
    float divi(float a,float b)
    {
        if (b == 0){
            Debug.Log("ERROR");
        }
        else
        {
            return a / b;
        }

        return 0;
    }
}
