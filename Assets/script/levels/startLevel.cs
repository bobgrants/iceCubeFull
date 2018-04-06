using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startLevel : MonoBehaviour {

    GameObject iceCube;
    GameObject gameManager;
    public bool zoomed;

    float timerStart;

	// Use this for initialization
	void Start () {
        iceCube = GameObject.Find("icecube");
        gameManager = GameObject.Find("gameManager");
        zoomed = false;

        timerStart = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && zoomed == false) //firstly, check if a touch has been made
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                    break;

                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    if (GameObject.Find("Main Camera") != null && timerStart > 2.0f)
                    {
                        GetComponentInParent<cameraBehavior>().zoomTap = true;
                    }
                    else if (GameObject.Find("Main CameraSand") != null)
                    {
                        GetComponentInParent<cameraBehavior>().zoomTap = true;
                    }
                    break;
            }

        }
        else if (Input.touchCount > 0 && zoomed == true) //firstly, check if a touch has been made
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:

                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:

                    break;

                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    iceCube.GetComponentInChildren<meltDown>().shrinking = true;
                    gameManager.GetComponentInChildren<gameManager>().gameStarted = true;
                    if (GameObject.Find("stoneBottom")) { GameObject.Find("stoneBottom").GetComponent<pushObstacleUp>().MovmtUp = true; }
                    if (GameObject.Find("stoneTop")) { GameObject.Find("stoneTop").GetComponent<pushObstacleDown>().MovmtDown = true; }
                    Destroy(gameObject);

                    break;
            }
            
        }

        if (Input.GetKeyDown("space") && zoomed == false && timerStart > 2.0f)  //For debug purpose / unity player
        {
            if (GameObject.Find("Main Camera") != null)
            {
                GetComponentInParent<cameraBehavior>().zoomTap = true;
            }
            else if (GameObject.Find("Main CameraSand") != null)
            {
                GetComponentInParent<cameraBehavior>().zoomTap = true;
            }
        }
        else if (Input.GetKeyDown("space") && zoomed == true) //firstly, check if a touch has been made
        {
            iceCube.GetComponentInChildren<meltDown>().shrinking = true;
            gameManager.GetComponentInChildren<gameManager>().gameStarted = true;
            if (GameObject.Find("stoneBottom")) { GameObject.Find("stoneBottom").GetComponent<pushObstacleUp>().MovmtUp = true; }
            if (GameObject.Find("stoneTop")) { GameObject.Find("stoneTop").GetComponent<pushObstacleDown>().MovmtDown = true; }
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        timerStart += 1.0f * Time.deltaTime;
        //Debug.Log(timerStart);
    }
}
