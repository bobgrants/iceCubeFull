﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinSFResult : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        gameObject.transform.Rotate(0,0,-100.0f*Time.deltaTime);
		
	}
}
