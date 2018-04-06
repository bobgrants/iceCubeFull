using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundStone : MonoBehaviour {

    GameObject icecube;


	// Use this for initialization
	void Start () {
        icecube = GameObject.Find("icecube");	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.name == icecube.name)
        {
            icecube.GetComponent<movementCube>().speed = icecube.GetComponent<movementCube>().speed / 2;
            icecube.GetComponent<Rigidbody2D>().drag = 2.0f;
            Debug.Log("ENTERED");
        }
    }

    void OnTriggerExit2D(Collider2D c)
    {
        if (c.name == icecube.name) {
            icecube.GetComponent<movementCube>().speed = icecube.GetComponent<movementCube>().speed * 2;
            icecube.GetComponent<Rigidbody2D>().drag = 0.5f;
        }
    }
}
