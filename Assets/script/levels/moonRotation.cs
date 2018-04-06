using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonRotation : MonoBehaviour {

    public float spinSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        spinOfMoon();
    }

    void spinOfMoon()
    {
        transform.Rotate(0f, 0.0f, spinSpeed);
    }
}
