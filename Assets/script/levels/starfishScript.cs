using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starfishScript : MonoBehaviour
{

    public bool collected;
    GameObject iceCube;


    // Use this for initialization
    void Start()
    {
        collected = false;
        iceCube = GameObject.Find("icecube");

    }

    // Update is called once per frame
    void Update()
    {
        spinSnoflake();
        //Debug.Log("Collected status from snowflake : " + collected);

    }

    void spinSnoflake()
    {

        //transform.Rotate(0, 0, -1.0f);
        if (collected == false)
        {
            transform.Rotate(0f, 0.0f, 1.0f);
        }
        else
        {
            transform.rotation = Quaternion.identity;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == iceCube.name)
        {
            collected = true;
        }
    }
}
