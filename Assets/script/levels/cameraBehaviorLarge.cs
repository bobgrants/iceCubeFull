using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBehaviorLarge : MonoBehaviour {

    Camera cam; //GameObject camera
    GameObject iceCube; //GameObject icecube

    float timer;    //Timer
    float camMovementSpeed; //Camera speed used in follow behavior

    bool zoomed;    //DId the zoom behavior executed ?
    public bool zoomTap;

    Vector2 iceCubeInitialPos;  
    
    

	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
        iceCube = GameObject.Find("icecube");
        zoomed = false;
        zoomTap = false;

        camMovementSpeed = 2.5f;

        iceCubeInitialPos = iceCube.transform.position;

    }
	

	// Update is called once per frame
	void Update () {
        clampCamera();  //Clamp camera to level borders
    }


    void FixedUpdate()
    {
        if (zoomed == false && zoomTap == true)
        {
            focusIceCube();
        }
        else if (zoomed == true)
        {
            followCube();   //Follow cube is in Fixed update to avoid stuttering
        }
        zooming();
    }

    void zooming()
    {
        if (cam.orthographicSize > 2.5f && zoomTap == true) // && timer < 3.5f
        {
            cam.orthographicSize -= 1.5f * Time.deltaTime; //Reduce cam size for zoom effect
        }
        else if(cam.orthographicSize < 2.5f)
        {
            zoomed = true;
            if (GameObject.Find("Plane") != null) { GetComponentInChildren<startLevel>().zoomed = true; }
        }
    }

    public void focusIceCube() {

        //This below center the camera on the ice cube while the camera is zooming in
        if (cam.transform.position.x > iceCubeInitialPos.x+0.2f && cam.transform.position.x > -4.5f)
        {
            cam.transform.position = new Vector3(cam.transform.position.x - camMovementSpeed * Time.deltaTime, cam.transform.position.y, -10.0f);
        }
        else if (cam.transform.position.x < iceCubeInitialPos.x-0.2f)
        {
            cam.transform.position = new Vector3(cam.transform.position.x + camMovementSpeed * Time.deltaTime, cam.transform.position.y, -10.0f);
        }

        if (cam.transform.position.y > iceCubeInitialPos.y+0.2f)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y - camMovementSpeed * Time.deltaTime, -10.0f);
        }
        else if (cam.transform.position.y < iceCubeInitialPos.y-0.2f)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y + camMovementSpeed * Time.deltaTime, -10.0f);
        }
    }

    void followCube() { //Once the zoom and center behavior is finished, the camera will follow the cube for the rest of the level
        Vector2 iceCubePos = iceCube.transform.position;
        Vector2 camPos = cam.transform.position;
        Vector2 currSpeed = Vector2.zero;
        cam.transform.position = Vector2.SmoothDamp(camPos, iceCubePos, ref currSpeed, 0.1f, 40.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
    }

    void clampCamera() {
        cam.transform.position = new Vector2(Mathf.Clamp(cam.transform.position.x, -4.5f, 9.2f), Mathf.Clamp(cam.transform.position.y, -16f, 9.5f)); //Clamp camera between x -4.2/4.5 and y -2.7/2.5
    }
}
