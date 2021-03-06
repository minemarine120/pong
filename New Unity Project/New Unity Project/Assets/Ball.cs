﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{//begin
    public Text scoreRightText;
    public Text scoreLeftText;
    int scoreRight;
    int scoreLeft;

    public float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
      GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }


    float hitFactor(Vector2 ballPos, Vector2 racketPos,
        float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "defensedroite")
        {
            float y = hitFactor(transform.position,
                col.transform.position,
                col.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if (col.gameObject.name == "defensegauche")
        {
            float y = hitFactor(transform.position,
                col.transform.position,
                col.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (col.gameObject.name== "traidroit")
        {
            scoreLeft++;
            scoreLeftText.text = scoreLeft.ToString();

        }
        if (col.gameObject.name == "traigauche")
        {
            scoreRight++;
            scoreRightText.text = scoreRight.ToString();

        }
    }


}//end
