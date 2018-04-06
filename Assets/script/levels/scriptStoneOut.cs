using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptStoneOut : MonoBehaviour {

    public GameObject detectorIn;
    public GameObject stone;

    public Rigidbody2D stoneRB;
    
	// Use this for initialization
	void Start ()
    {
       
        
    }

    // Update is called once per frame
    void Update ()
    {

    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.name == stone.name )
        {
            stoneRB.velocity = Vector3.zero;
            c.GetComponent<wallSmashScript>().direction = "in";
        }
    }

    void OnTriggerStay2D(Collider2D c)
    {
        if (c.gameObject.name == stone.name)
        {
            c.GetComponent<wallSmashScript>().direction = "in";
        }
    }
}
