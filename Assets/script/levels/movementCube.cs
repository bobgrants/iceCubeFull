using UnityEngine;
using System.Collections;

public class movementCube : MonoBehaviour
{

    public float speed;

    GameObject gameManager;
    GameObject iceCube;

    private Rigidbody2D rb;

    public bool fallStop;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 4000.0f;

        gameManager = GameObject.Find("gameManager");
        iceCube = GameObject.Find("icecube");

        fallStop = false;
    }

    void FixedUpdate()
    {
        if (gameManager.GetComponentInChildren<gameManager>().gameStarted == true && fallStop == false)
        {
            tiltMove();
        }      
    }

    void tiltMove() {
            Vector2 movement = new Vector2(Input.acceleration.x, Input.acceleration.y);
            // Adding force to rigidbody
            rb.AddForce(movement * speed * Time.deltaTime);
    }

    public void isFalling() {
        fallStop = true;
    }


    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("StoneObs"))
        {
            iceCube.GetComponent<movementCube>().speed = iceCube.GetComponent<movementCube>().speed / 2;
            iceCube.GetComponent<Rigidbody2D>().drag = 2.0f;
            Debug.Log("CollisionStoneIn");
        }
    }

    void OnCollisionExit2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("StoneObs"))
        {
            iceCube.GetComponent<movementCube>().speed = iceCube.GetComponent<movementCube>().speed * 2;
            iceCube.GetComponent<Rigidbody2D>().drag = 0.5f;
            Debug.Log("CollisionStoneOut");
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.name == "floorStone" || c.name == "floorStone2" || c.name == "floorStone3" || c.name == "floorStone4")
        {
            //Destroy(gameObject);
            gameObject.GetComponent<movementCube>().speed = gameObject.GetComponent<movementCube>().speed / 2;
            gameObject.GetComponent<Rigidbody2D>().drag = 2.0f;
            gameObject.GetComponent<Rigidbody2D>().angularDrag = 1.0f;
            Debug.Log("StoneFloorIn");
        }
    }

    void OnTriggerExit2D(Collider2D c)
    {
        if (c.name == "floorStone" || c.name == "floorStone2" || c.name == "floorStone3" || c.name == "floorStone4")
        {
            gameObject.GetComponent<movementCube>().speed = gameObject.GetComponent<movementCube>().speed * 2;
            gameObject.GetComponent<Rigidbody2D>().drag = 0.5f;
            gameObject.GetComponent<Rigidbody2D>().angularDrag = 0.05f;
            Debug.Log("StoneFloorOut");
        }
    }
}