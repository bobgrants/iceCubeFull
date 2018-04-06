using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneRoll : MonoBehaviour {

    Renderer rend;
    float posf;
    public float speed;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        posf = 0.0f;
        speed = 0.005f;

    }
	
	// Update is called once per frame
	void Update () {
        posf -= speed;

        rend.material.mainTextureOffset = new Vector2(0, posf);
	}
}
