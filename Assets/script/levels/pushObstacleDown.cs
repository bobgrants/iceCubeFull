using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushObstacleDown : MonoBehaviour {

    public float speed;
    

    GameObject ObsLeft;
    GameObject ObsRight;
    GameObject blockLevelStart;

    public bool MovmtDown;

	// Use this for initialization
	void Start ()
    {
        loadVar();

        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), ObsLeft.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), ObsRight.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), blockLevelStart.GetComponent<Collider2D>());

        MovmtDown = false;
    }

    void loadVar()
    {
        speed = -0.018f;
        
        ObsLeft = GameObject.Find("iceLeft");
        ObsRight = GameObject.Find("iceRight");
        blockLevelStart = GameObject.Find("blockLevelStart");
    }


	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        MoveDown();
    }

    void MoveDown()
    {
        if (MovmtDown == true && gameObject.transform.position.y > -12.5)
        {
            gameObject.transform.position += new Vector3(0, speed, 0);
            


        }
    }
    
}
