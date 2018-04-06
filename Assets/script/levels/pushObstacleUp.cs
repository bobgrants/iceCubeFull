using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushObstacleUp : MonoBehaviour {

    public float speed;
    

    GameObject ObsLeft;
    GameObject ObsRight;
    GameObject blockLevelStart;

    public bool MovmtUp;

	// Use this for initialization
	void Start ()
    {
        loadVar();

        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), ObsLeft.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), ObsRight.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), blockLevelStart.GetComponent<Collider2D>());

        MovmtUp = false;
    }

    void loadVar()
    {
        speed = 0.008f;

        ObsLeft = GameObject.Find("iceLeft");
        ObsRight = GameObject.Find("iceRight");
        blockLevelStart = GameObject.Find("blockLevelStart");
    }


	
	void Update () {
		
	}

    void FixedUpdate()
    {
        MoveUp();
    }

    void MoveUp()
    {
        if (MovmtUp == true && gameObject.transform.position.y < -0.6f)
        {
            gameObject.transform.position += new Vector3(0, speed, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "stoneTop")
        {
            MovmtUp = false;
            Debug.Log(MovmtUp);

        }
    }
}
