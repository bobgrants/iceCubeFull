using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneStopOnContact : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (gameObject.GetComponent<Rigidbody2D>().velocity != Vector2.zero)
        {
            if (c.gameObject.name != null || c.gameObject.tag != null)
            {
                GetComponentInParent<smashStoneScript>().smash = false;
                gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;

            }
        }
    }

    void OnCollisionStay2D(Collision2D c)
    {
        if (gameObject.GetComponent<Rigidbody2D>().velocity != Vector2.zero)
        {
            if (c.gameObject.name != null || c.gameObject.tag != null)
            {
                GetComponentInParent<smashStoneScript>().smash = false;
                gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            }
        }
    }
}
