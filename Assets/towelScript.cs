using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towelScript : MonoBehaviour {

    public gameManager gm;
    GameObject iceCube;

    GameObject collTop;
    GameObject collBottom;
    GameObject collLeft;
    GameObject collRight;

    bool timerOn = false;

    float timer = 0.0f;

    // Use this for initialization
    void Start () {
        iceCube = GameObject.Find("icecube");

        collTop = GameObject.Find("colliderTop");
        collBottom = GameObject.Find("colliderBottom");
        collLeft = GameObject.Find("colliderLeft");
        collRight = GameObject.Find("colliderRight");
    }
	
	// Update is called once per frame
	void Update () {
        loadNextScene();
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.name == iceCube.name)
        {
            iceCube.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 0.0f);
            gm.gameStarted = false;
            timerOn = true;
            iceCube.GetComponentInChildren<meltDown>().shrinking = false;
            iceCube.GetComponentInChildren<meltDown>().enabled = false;
            iceCube.GetComponentInChildren<movementCube>().enabled = false;
            iceCube.GetComponentInChildren<touchMelt>().enabled = false;
            iceCube.GetComponentInChildren<keyboard>().enabled = false;

            collTop.GetComponent<BoxCollider2D>().isTrigger = false;
            collBottom.GetComponent<BoxCollider2D>().isTrigger = false;
            collLeft.GetComponent<BoxCollider2D>().isTrigger = false;
            collRight.GetComponent<BoxCollider2D>().isTrigger = false;

        }
    }

    void loadNextScene()
    {
        if (timerOn == true)
        {
            timer += Time.deltaTime;

            if (collTop.transform.localPosition.y > 0.3f)
            {
                collTop.transform.position -= new Vector3(0.0f, 0.005f, 0.0f);
            }

            if (collBottom.transform.localPosition.y < 0.5f)
            {
                collBottom.transform.position += new Vector3(0.0f, 0.015f, 0.0f);
            }

            if (collLeft.transform.localPosition.x < 0.4f)
            {
                collLeft.transform.position += new Vector3(0.005f, 0.0f, 0.0f);
            }

            if (collRight.transform.localPosition.x > 0.1f)
            {
                collRight.transform.position -= new Vector3(0.005f, 0.0f, 0.0f);
            }
        }

        if (timer > 10.0f)
        {
            gm.registerCollection();
        }
    }


}
