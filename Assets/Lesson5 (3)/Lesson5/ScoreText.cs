using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

    private int score = 0;
    private GameObject scoreText;


    // Use this for initialization
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
        score = 0; 

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 40;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            score += 30;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 20;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 10;
        }
        String str = score.ToString();
        this.scoreText.GetComponent<Text>().text = str;
    }
}

