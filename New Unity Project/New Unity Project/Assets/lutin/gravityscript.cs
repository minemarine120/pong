using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityscript : MonoBehaviour
{
    Vector2 speed;
    // Uptade is called once per frame
    void Start()
    {
        Vector2 speed = new Vector2(1,1);
        GetComponent<Rigidbody2D>().velocity = speed;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}