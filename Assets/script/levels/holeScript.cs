using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holeScript : MonoBehaviour {

    GameObject iceCube;
    GameObject fallDetector;

    bool pullCube;

    Vector2 destination;

    CircleCollider2D cc2;
    float radius;

	// Use this for initialization
	void Start () {
        pullCube = false;

        iceCube = GameObject.Find("icecube");
        fallDetector = gameObject.transform.GetChild(0).gameObject;

        //destination = new Vector2(fallDetector.GetComponent<Renderer>().bounds.center.x, fallDetector.GetComponent<Renderer>().bounds.center.y);
        //destination = new Vector2(fallDetector.GetComponent<Collider2D>().bounds.center);


        cc2 = this.GetComponent<CircleCollider2D>();
        radius = cc2.transform.localScale.x;
        Debug.Log("Radius Test " + radius + " " + gameObject.name);
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void FixedUpdate()
    {
        pulling();
    }

    void pulling()
    {

        if (pullCube == true)
        {
            iceCube.GetComponent<Rigidbody2D>().AddForce((fallDetector.GetComponent<Collider2D>().bounds.center - iceCube.transform.position) * 1000 * Time.deltaTime);
            Debug.Log("Pulling");
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == iceCube.name)
        {
            pullCube = true;
        }
        else if (other.name != iceCube.name)
        {
            other.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            other.GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == iceCube.name)
        {
            pullCube = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == iceCube.name)
        {
            pullCube = true;
        }
        else if (other.name != iceCube.name)
        {
            other.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            other.GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }


}


