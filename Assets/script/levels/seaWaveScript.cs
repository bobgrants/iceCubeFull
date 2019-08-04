using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seaWaveScript : MonoBehaviour {
    public GameObject seaWave;
    public GameObject icecube;

    public Collider2D detectorIn;
    public Collider2D detectorOut;

    public string direction;

    public float accelerationIn;
    public float accelerationOut;

	// Use this for initialization
	void Start () {
        
        //Debug.Log(seaWave + " - " + detectorIn + " - " + detectorOut);

        direction = "null";

        //seaWave.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 2.0f);

        icecube = GameObject.Find("icecube");
    }

    // Update is called once per frame
    void Update () {
		
	}

    void FixedUpdate() {

        if (direction == "in")
        {
            if (seaWave.GetComponent<Rigidbody2D>().velocity.y < 3.0f) { seaWave.GetComponent<Rigidbody2D>().velocity += new Vector2(0.0f, accelerationIn); }
        }
        else if (direction == "out")
        {
            if (seaWave.GetComponent<Rigidbody2D>().velocity.y > -2.0f) { seaWave.GetComponent<Rigidbody2D>().velocity -= new Vector2(0.0f, accelerationOut); }
        }
        //Debug.Log(seaWave.GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnTriggerStay2D(Collider2D c)
    {
        if (c.gameObject.name == icecube.gameObject.name && seaWave.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
        {

            //icecube.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -15));
            icecube.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, seaWave.GetComponent<Rigidbody2D>().velocity.y * 10.0f));

        }
        else if (c.gameObject.name == icecube.gameObject.name && seaWave.GetComponent<Rigidbody2D>().velocity.y > 1.0f)
        {

            //icecube.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 20));
            icecube.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, seaWave.GetComponent<Rigidbody2D>().velocity.y * 20.0f));

        }
    }


}
