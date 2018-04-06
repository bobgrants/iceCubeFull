using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smashStoneScript : MonoBehaviour {

    Rigidbody2D stoneRB;
    GameObject detector;

    public bool smash;

    public float smashspeed;

    // Use this for initialization
    void Start () {

        gameObject.SetActive(true);

        smash = false;

        stoneRB = transform.Find("stone").GetComponent<Rigidbody2D>();
        detector = transform.Find("detector").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        if (smash == true)
        {
            stoneRB.AddForce((detector.transform.position - gameObject.transform.position) * smashspeed);
            detector.SetActive(false);
        } else if (smash == false)
        {
            stoneRB.velocity = Vector3.zero;
        }
    }


    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name != null || c.gameObject.tag != null)
        {
            stoneRB.velocity = Vector3.zero;
        }
    }

}
