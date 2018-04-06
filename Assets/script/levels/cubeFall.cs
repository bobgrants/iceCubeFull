using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cubeFall : MonoBehaviour {

    GameObject iceCube;
    GameObject gameManager;
    GameObject destroyer;

    meltDown md;
    movementCube mc;
    gameManager gm;

    bool fallen;

    // Use this for initialization
    void Start ()
    {
        iceCube = GameObject.Find("icecube");
        gameManager = GameObject.Find("gameManager");
        destroyer = gameObject.transform.GetChild(0).gameObject;

        md = iceCube.GetComponent<meltDown>();
        mc = iceCube.GetComponent<movementCube>();
        gm = gameManager.GetComponent<gameManager>();

        InvokeRepeating("increaseColliderSize", 0.0f, 1.0f);

        fallen = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        fallingGameOver();
    }

    void fallingGameOver() {
        if (fallen == true && iceCube.transform.localScale.x > 0.01f)
        {
            Debug.Log("Falling");
            iceCube.transform.localScale -= new Vector3(1.0f, 1.0f, 0) * Time.fixedDeltaTime;
            iceCube.GetComponent<movementCube>().enabled = false;
            iceCube.GetComponent<keyboard>().enabled = false;
        }
        else if (fallen == true && iceCube.transform.localScale.x < 0.01f)
        {
            SceneManager.LoadScene("gameOver");
        }
    }

    void increaseColliderSize()
    {
        if (md.shrinking)
        {
            GetComponent<CircleCollider2D>().radius += 0.015f;  //0.013f;
            if (GetComponent<CircleCollider2D>().radius >= 0.45f) { GetComponent<CircleCollider2D>().radius = 0.45f; }

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == iceCube.name)
        {
            //GetComponentInParent<holeScript>().enabled = false;
            //other.GetComponent<Rigidbody2D>().AddForce((destroyer.GetComponent<Collider2D>().bounds.center - iceCube.transform.position) * 500f * Time.deltaTime);
            GetComponent<CircleCollider2D>().radius = 0.45f;
            destroyer.GetComponent<CircleCollider2D>().radius = 0.45f;
        }
    }
    }
    

