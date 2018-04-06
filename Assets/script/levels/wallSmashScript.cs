using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallSmashScript : MonoBehaviour {

    public GameObject detectorIn;
    public GameObject detectorOut;

    public float speed;

    public string direction;


    // Use this for initialization
    void Start () {

        ignoreCollision();
        

        direction = "in";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        if (direction == "in")
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce((detectorIn.transform.position - gameObject.transform.position) * speed);
        }
        else if (direction == "out")
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce((detectorOut.transform.position - gameObject.transform.position) * speed);
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }

    void ignoreCollision()
    {
        if (GameObject.Find("bottomRight"))
        {
            Physics2D.IgnoreCollision(GameObject.Find("bottomRight").GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        if (GameObject.Find("bottomLeft"))
        {
            Physics2D.IgnoreCollision(GameObject.Find("bottomLeft").GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        if (GameObject.Find("mainTop"))
        {
            Physics2D.IgnoreCollision(GameObject.Find("mainTop").GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        if (GameObject.Find("mainBottom"))
        {
            Physics2D.IgnoreCollision(GameObject.Find("mainBottom").GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        if (GameObject.Find("top"))
        {
            Physics2D.IgnoreCollision(GameObject.Find("top").GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        if (GameObject.Find("bottom"))
        {
            Physics2D.IgnoreCollision(GameObject.Find("bottom").GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }

     
}
