using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinchUnzoom : MonoBehaviour
{
    public float perspectiveZoomSpeed = 0.5f;        // The rate of change of the field of view in perspective mode.
    public float orthoZoomSpeed = 0.005f;        // The rate of change of the orthographic size in orthographic mode.
    Camera cam;


    GameObject iceCube; //GameObject icecube
    Vector2 iceCubePos;

    void Start()
    {
        cam  = GetComponent<Camera>();
        iceCube = GameObject.Find("icecube");
        iceCubePos = iceCube.transform.position;
    }

    void Update()
    {
        if (GameObject.Find("gameManager").GetComponent<gameManager>().gameStarted == true)
        {
            pinchBehavior();
        }
        cameraSize();
    }

    void pinchBehavior()
    {
        // If there are two touches on the device...
        if (Input.touchCount == 2)
        {
            // Store both touches.
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Find the position in the previous frame of each touch.
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Find the magnitude of the vector (the distance) between the touches in each frame.
            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Find the difference in the distances between each frame.
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // If the camera is orthographic...
            if (cam.orthographic)
            {
                if (cam.orthographicSize >= 2.5f && cam.orthographicSize <= 4.0f && deltaMagnitudeDiff != 0.0f)
                {
                    // ... change the orthographic size based on the change in distance between the touches.
                    //cam.orthographicSize += deltaMagnitudeDiff * orthoZoomSpeed * Time.deltaTime;
                    cam.orthographicSize = 4.5f;

                    // Make sure the orthographic size never drops below zero.
                    cam.orthographicSize = Mathf.Max(cam.orthographicSize, 0.1f);


                    Vector2 camPos = cam.transform.position;
                    Vector2 currSpeed = Vector2.zero;

                    if (cam.transform.position.x < 0 && cam.transform.position.y > 0)
                    {
                        //cam.transform.position = Vector2.SmoothDamp(camPos, new Vector2(-1.1f, 1.1f), ref currSpeed, 0.01f, 20.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
                        cam.transform.position = new Vector2(Mathf.Clamp(cam.transform.position.x, -1.1f, -1.0f), Mathf.Clamp(cam.transform.position.y, 1.1f, 1.2f)); //Clamp camera between x -4.2/4.5 and y -2.7/2.5
                    }
                    else if (cam.transform.position.x > 0 && cam.transform.position.y > 0)
                    {
                        //cam.transform.position = Vector2.SmoothDamp(camPos, new Vector2(2.3f, 1.1f), ref currSpeed, 0.01f, 20.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
                        cam.transform.position = new Vector2(Mathf.Clamp(cam.transform.position.x, 2.2f, 2.3f), Mathf.Clamp(cam.transform.position.y, 1.1f, 1.2f)); //Clamp camera between x -4.2/4.5 and y -2.7/2.5
                    }
                    else if (cam.transform.position.x < 0 && cam.transform.position.y < 0)
                    {
                        //cam.transform.position = Vector2.SmoothDamp(camPos, new Vector2(-1.1f, -1.1f), ref currSpeed, 0.01f, 20.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
                        cam.transform.position = new Vector2(Mathf.Clamp(cam.transform.position.x, -1.1f, -1.0f), Mathf.Clamp(cam.transform.position.y, -1.2f, -1.1f)); //Clamp camera between x -4.2/4.5 and y -2.7/2.5
                    }
                    else if (cam.transform.position.x > 0 && cam.transform.position.y < 0)
                    {
                        //cam.transform.position = Vector2.SmoothDamp(camPos, new Vector2(2.3f, -1.2f), ref currSpeed, 0.01f, 20.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
                        cam.transform.position = new Vector2(Mathf.Clamp(cam.transform.position.x, 2.2f, 2.3f), Mathf.Clamp(cam.transform.position.y, -1.2f, -1.1f)); //Clamp camera between x -4.2/4.5 and y -2.7/2.5
                    }

                }
            }


            if (touchZero.phase == TouchPhase.Stationary && touchOne.phase == TouchPhase.Stationary && cam.orthographicSize > 2.5f)
            {
                Vector2 camPos = cam.transform.position;
                Vector2 currSpeed = Vector2.zero;

                cam.GetComponent<cameraBehavior>().Unzoom = true;
                cam.orthographicSize = 4.5f;
                cam.GetComponent<cameraBehavior>().zoomFactor = 0.0f;

                if (cam.transform.position.x < 0 && cam.transform.position.y > 0)
                {
                    //cam.transform.position = Vector2.SmoothDamp(camPos, new Vector2(-1.1f, 1.1f), ref currSpeed, 0.01f, 20.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
                    cam.transform.position = new Vector2(Mathf.Clamp(cam.transform.position.x, -1.1f, -1.0f), Mathf.Clamp(cam.transform.position.y, 1.1f, 1.2f)); //Clamp camera between x -4.2/4.5 and y -2.7/2.5

                }
                else if (cam.transform.position.x > 0 && cam.transform.position.y > 0)
                {
                    //cam.transform.position = Vector2.SmoothDamp(camPos, new Vector2(2.3f, 1.1f), ref currSpeed, 0.01f, 20.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
                    cam.transform.position = new Vector2(Mathf.Clamp(cam.transform.position.x, 2.2f, 2.3f), Mathf.Clamp(cam.transform.position.y, 1.1f, 1.2f)); //Clamp camera between x -4.2/4.5 and y -2.7/2.5

                }
                else if (cam.transform.position.x < 0 && cam.transform.position.y < 0)
                {
                    cam.transform.position = Vector2.SmoothDamp(camPos, new Vector2(-1.1f, -1.1f), ref currSpeed, 0.01f, 20.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
                }
                else if (cam.transform.position.x > 0 && cam.transform.position.y < 0)
                {
                    cam.transform.position = Vector2.SmoothDamp(camPos, new Vector2(2.3f, -1.2f), ref currSpeed, 0.01f, 20.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
                }
            }
            else if (touchZero.phase == TouchPhase.Moved && touchOne.phase == TouchPhase.Moved && cam.orthographicSize > 2.5f)
            {
                Vector2 camPos = cam.transform.position;
                Vector2 currSpeed = Vector2.zero;

                cam.GetComponent<cameraBehavior>().Unzoom = true;
                cam.orthographicSize = 4.5f;
                cam.GetComponent<cameraBehavior>().zoomFactor = 0.0f;

                if (cam.transform.position.x < 0 && cam.transform.position.y > 0)
                {
                    cam.transform.position = Vector2.SmoothDamp(camPos, new Vector2(-1.1f, 1.1f), ref currSpeed, 0.01f, 20.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
                }
                else if (cam.transform.position.x > 0 && cam.transform.position.y > 0)
                {
                    cam.transform.position = Vector2.SmoothDamp(camPos, new Vector2(2.3f, 1.1f), ref currSpeed, 0.01f, 20.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
                }
                else if (cam.transform.position.x < 0 && cam.transform.position.y < 0)
                {
                    cam.transform.position = Vector2.SmoothDamp(camPos, new Vector2(-1.1f, -1.1f), ref currSpeed, 0.01f, 20.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
                }
                else if (cam.transform.position.x > 0 && cam.transform.position.y < 0)
                {
                    cam.transform.position = Vector2.SmoothDamp(camPos, new Vector2(2.3f, -1.2f), ref currSpeed, 0.01f, 20.0f, Time.fixedDeltaTime);   //SmoothDamp pushed the camera towards iceCubePos
                }
            }
            else if (touchZero.phase == TouchPhase.Ended || touchOne.phase == TouchPhase.Ended)
            {
                cam.GetComponent<cameraBehavior>().zoomFactor = 3.0f;
                cam.GetComponent<cameraBehavior>().Unzoom = false;
            }
            else
            {
                cam.GetComponent<cameraBehavior>().zoomed = false;
            }
        }
    }

    void cameraSize()
    {
        if (GameObject.Find("gameManager").GetComponent<gameManager>().gameStarted == true)
        {
            if (cam.orthographicSize < 2.5f) { cam.orthographicSize = 2.5f; }
            if (cam.orthographicSize > 4.5f) { cam.orthographicSize = 4.5f; }
        }
    }
}