using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchMelt : MonoBehaviour {


    private float holdTime = 0.1f; // time for a touch to be considered a hold
    private float acumTime = 0; // Accumulated time since begining of hold

    private PolygonCollider2D icecubePolygonColl2D;
    private BoxCollider2D icecubeBoxCollider2D;

    void Start()
    {
        //icecube = GameObject.Find("icecube").GetComponentInChildren<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update () {
        
    }

    void FixedUpdate()
    {
        mouseClickPosition();
    }

    void mouseClickPosition()
    {
        if (Input.GetButton("Fire1"))
        {
                rayCastMethod();
        }
        else if (Input.touchCount > 0)
        {
            acumTime += Input.GetTouch(0).deltaTime;

            if (acumTime >= holdTime)
            {
                if (Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position) == transform.position)
                {
                    rayCastMethodTouch();
                }
            }

            if (Input.GetTouch(0).phase == TouchPhase.Ended) 
            {
                acumTime = 0;
            }
        }
    }

    void rayCastMethod()
    {
        //RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), -Vector2.zero);
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), -Vector2.zero);

        if (hit.collider == gameObject.GetComponent<Collider2D>())
        {
            transform.localScale -= new Vector3(0.006f, 0.006f, 0);
            //Debug.Log(transform.localScale);
            //Debug.Log(hit.collider);
        }
    }

    void rayCastMethodTouch()
    {
        //RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position), -Vector2.zero);
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position), new Vector3(0, 0, 1));

        if (hit.collider == gameObject.GetComponent<Collider2D>())
        {
            transform.localScale -= new Vector3(0.01f, 0.01f, 0);
            Debug.Log(transform.localScale);
        }
    }

    void OnCollisionStay2D(Collision2D c)
    {
        if (c.gameObject.tag == "stone")
        {
            //transform.localScale -= new Vector3(0.015f, 0.015f, 0);
        }
    }
}
