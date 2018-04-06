using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowflakeCollectedPosition1 : MonoBehaviour {

    Camera cam;

	// Use this for initialization
	void Start () {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void FixedUpdate()
    {
        gameObject.transform.position = cam.ViewportToWorldPoint(new Vector3(0.1f, 0.9f, -1));
        //Debug.Log(gameObject.transform.position);
    }
}
