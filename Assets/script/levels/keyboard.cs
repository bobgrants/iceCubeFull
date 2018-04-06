using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GetComponentInChildren<meltDown>().shrinking == true)
        {
            move();
        }
	}

    void move() {

        if (Input.GetKey("a"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 2 * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (Input.GetKey("d")) {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 2 *Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z); 
        }


        if (Input.GetKey("w"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 2 * Time.deltaTime, gameObject.transform.position.z);
        }

        if (Input.GetKey("s"))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 2 * Time.deltaTime, gameObject.transform.position.z);
        }
    }
}
