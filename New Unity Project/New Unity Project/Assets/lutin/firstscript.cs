using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstscript : MonoBehaviour
{
  int x = 5;
  float r = 1.2f; 

  string userName = "ada"; 

  bool win = false;
    bool over;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("Hello world!");

       win = true;

       Debug.Log("YOU WIN!");

        over = false;

        Debug.Log("GAME OVER!!");
    }

       

    // Update is called once per frame
    void Update()

    {

    }
 
}