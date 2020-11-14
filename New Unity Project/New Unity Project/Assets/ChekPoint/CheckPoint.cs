using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Sum(3,5));
        Debug.Log(Prod(1,8));
        Debug.Log(Div(9,2));
        

    }

    private float Sum(float a, float b)
    {
        return a + b;
    }
    private float Prod (float a, float b)
    {
        return a + b;
    }
    private float Div (float a, float b)  
    {
        if (b == 0)
        {
            return 0;
        }
        else{
            return a / b;
        }
    } 
        
}




