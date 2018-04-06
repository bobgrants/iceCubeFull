using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCubeHole : MonoBehaviour {

    GameObject iceCube;
    GameObject gameManager;


    meltDown md;
    movementCube mc;
    gameManager gm;

    // Use this for initialization
    void Start () {
        iceCube = GameObject.Find("icecube");
        gameManager = GameObject.Find("gameManager");

        md = iceCube.GetComponent<meltDown>();
        mc = iceCube.GetComponent<movementCube>();
        gm = gameManager.GetComponent<gameManager>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == iceCube.name)
        {
            Debug.Log("IceCube in the Middle");
            other.GetComponent<Collider2D>().isTrigger = true;


            mc.isFalling();     // Stop icecube Movement
            md.isFalling();    // and melting
            gm.isFalling();     // and chronometer
            //other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            //iceCube.GetComponent<Rigidbody2D>().isKinematic = true;
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(other.GetComponent<Rigidbody2D>().velocity.x / 20.0f, other.GetComponent<Rigidbody2D>().velocity.y / 20.0f);
            Debug.Log("fallen");
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == iceCube.name)
        {
            other.GetComponent<Rigidbody2D>().AddForce((gameObject.GetComponent<Collider2D>().bounds.center - other.transform.position) * 500f * Time.deltaTime);
            other.transform.localScale -= new Vector3(0.6f, 0.6f, 0) * Time.deltaTime; ; //* Time.deltaTime; // 
        }

    }
    }
