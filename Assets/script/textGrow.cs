using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textGrow : MonoBehaviour {

    Text textObject;
    string textStatus;

    float growSpeed = 0.5f;
    float textSizeFloat = 50;



    // Use this for initialization
    void Start()
    {
        textObject = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        textSize();
        //pingPong = Mathf.PingPong(Time.time * speed, 1);
        //Debug.Log("textSizeFloat: " + textSizeFloat);
    }

    void textSize()
    {

        if (textSizeFloat < 51 )
        {

            textStatus = "grow";
        }
        else if (textSizeFloat > 60)
        {

            textStatus = "shrink";
        }

        if (textStatus == "grow")
        {
            textSizeFloat += growSpeed;

            textObject.fontSize = Mathf.FloorToInt(textSizeFloat); 
        }
        if (textStatus == "shrink")
        {
            textSizeFloat -= growSpeed;

            textObject.fontSize = Mathf.FloorToInt(textSizeFloat);
        }
    }
}
