using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneStickScript : MonoBehaviour {

    Rigidbody2D rb;
    public float spinSpeed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate() {
        spinStick();
    }

    void spinStick() {
        transform.Rotate(0f, 0.0f, spinSpeed);
    }
}
