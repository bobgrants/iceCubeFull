using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endLevelScript : MonoBehaviour {

    gameManager gm;
    float timer;

    bool timerOn;

    GameObject iceCube;

	// Use this for initialization
	void Start ()
    {
        gm = GameObject.Find("gameManager").GetComponentInChildren<gameManager>();
        timerOn = false;
        iceCube = GameObject.Find("icecube");
    }
	
	// Update is called once per frame
	void Update ()
    {
        loadNextScene();
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.name == iceCube.name) {
            gm.gameStarted = false;
            timerOn = true;
            iceCube.GetComponentInChildren<meltDown>().shrinking = false;
            iceCube.GetComponentInChildren<meltDown>().enabled = false;
            iceCube.GetComponentInChildren<movementCube>().enabled = false;
            iceCube.GetComponentInChildren<touchMelt>().enabled = false;
            iceCube.GetComponentInChildren<keyboard>().enabled = false;
        }
    }

    

    void loadNextScene()
    {
        if (timerOn == true)
        {
            timer += Time.deltaTime;
        }

        if (timer > 2.5f)
        {
            gm.registerCollection();
        }
    }
}
