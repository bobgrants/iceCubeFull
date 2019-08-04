using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBehaviorTutorialScreen : MonoBehaviour
{

    Camera cam; //GameObject camera
    GameObject iceCube; //GameObject icecube

    float timer;    //Timer
    float camMovementSpeed; //Camera speed used in follow behavior
    public float zoomFactor;

    public bool zoomed;    //Did the zoom behavior executed ?
    public bool zoomTap;

    Vector2 iceCubeInitialPos;

    //IceCube follow var.
    public Vector2 iceCubePos;
    Vector2 camPos;
    Vector2 currSpeed;

    public bool Unzoom;

    // Use this for initialization
    void Start()
    {
        cam = GetComponent<Camera>();
        iceCube = GameObject.Find("icecubeTutorialPage");
        zoomed = false;
        zoomTap = false;
        Unzoom = false;

        camMovementSpeed = 2.5f;
        zoomFactor = 1.5f;

        iceCubeInitialPos = iceCube.transform.position;

        //IceCube follow var.
        iceCubePos = iceCube.transform.position;
        camPos = cam.transform.position;
        currSpeed = Vector2.zero;
    }


    // Update is called once per frame
    void Update()
    {


    }


    void FixedUpdate()
    {
        if (Unzoom == false)
        {
            if (zoomed == false && zoomTap == true)
            {
                focusIceCube();
            }
            else if (zoomed == true)
            {
                followCube();   //Follow cube is in Fixed update to avoid stuttering
            }
        }

        zooming();
        clampCamera();  //Clamp camera to level borders
    }

    void zooming()
    {
        if (cam.orthographicSize > 2.5f && zoomTap == true)
        {
            cam.orthographicSize -= zoomFactor * Time.deltaTime; //Reduce cam size for zoom effect

        }
        else if (cam.orthographicSize <= 2.5f)
        {
            zoomed = true;
            if (GameObject.Find("Plane") != null) { GetComponentInChildren<startLevel>().zoomed = true; }
        }
    }

    public void focusIceCube()
    {
        iceCubeInitialPos = iceCube.transform.position;
        //This below center the camera on the ice cube while the camera is zooming in
        if (cam.transform.position.x > iceCubeInitialPos.x + 0.2f && cam.transform.position.x > -4.2f)
        {
            cam.transform.position = new Vector3(cam.transform.position.x - camMovementSpeed * Time.deltaTime, cam.transform.position.y, -10.0f);
        }
        else if (cam.transform.position.x < iceCubeInitialPos.x - 0.2f)
        {
            cam.transform.position = new Vector3(cam.transform.position.x + camMovementSpeed * Time.deltaTime, cam.transform.position.y, -10.0f);
        }

        if (cam.transform.position.y > iceCubeInitialPos.y + 0.2f)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y - camMovementSpeed * Time.deltaTime, -10.0f);
        }
        else if (cam.transform.position.y < iceCubeInitialPos.y - 0.2f)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y + camMovementSpeed * Time.deltaTime, -10.0f);
        }
    }

    void clampCamera()
    {
        if (cam.orthographicSize < 2.6f)
        {
            cam.transform.position = new Vector2(Mathf.Clamp(cam.transform.position.x, -4.2f, 5.5f), Mathf.Clamp(cam.transform.position.y, -2.9f, 3.8f)); //Clamp camera between x -4.2/4.5 and y -2.7/2.5
        }
        else if (cam.orthographicSize > 2.6f && GameObject.Find("gameManager").GetComponent<gameManager>().gameStarted == true)
        {
            //cam.transform.position = new Vector2(Mathf.Clamp(cam.transform.position.x, -0.5f, 2.15f), Mathf.Clamp(cam.transform.position.y, -1.1f, 1.05f)); //Clamp camera between x -4.2/4.5 and y -2.7/2.5
            //focusIceCube();
        }
    }

    void followCube()   //Once the zoom and center behavior is finished, the camera will follow the cube for the rest of the level
    {
        iceCubePos = iceCube.transform.position;
        camPos = cam.transform.position;
        currSpeed = Vector2.zero;
        if (cam.orthographicSize < 2.6f)
        {
            cam.transform.position = Vector2.SmoothDamp(camPos, iceCubePos, ref currSpeed, 0.01f, 20.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
        }
    }
}
