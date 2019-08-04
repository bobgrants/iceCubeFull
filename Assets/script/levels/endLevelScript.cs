using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endLevelScript : MonoBehaviour {

    gameManager gm;

    float timer;
    bool timerOn;

    float textTimer;
    bool textTimerOn;

    GameObject iceCube;

    GameObject gridText;
    Text gridTextText;

	// Use this for initialization
	void Start ()
    {
        gm = GameObject.Find("gameManager").GetComponentInChildren<gameManager>();
        timerOn = false;
        iceCube = GameObject.Find("icecube");

        gridTextText = GameObject.Find("gridText").GetComponent<Text>();

        Debug.Log(" this.GetComponent<SpriteRenderer>().enabled: " + this.GetComponent<SpriteRenderer>().enabled);
        Debug.Log("gridTextText.enabled: " + gridTextText.enabled);
    }
	
	// Update is called once per frame
	void Update ()
    {
        loadNextScene();
        TextTimer();
    }

    private void FixedUpdate()
    {
        
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.name == iceCube.name && this.GetComponent<SpriteRenderer>().enabled == true)
        {
            gm.gameStarted = false;
            timerOn = true;
            iceCube.GetComponentInChildren<meltDown>().shrinking = false;
            iceCube.GetComponentInChildren<meltDown>().enabled = false;
            iceCube.GetComponentInChildren<movementCube>().enabled = false;
            iceCube.GetComponentInChildren<touchMelt>().enabled = false;
            iceCube.GetComponentInChildren<keyboard>().enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
    if (c.gameObject.name == iceCube.name && this.GetComponent<SpriteRenderer>().enabled == false)
           {
            gridTextText.enabled = true;
            textTimerOn = true;
            Debug.Log("Touchy Touchy Touchy Touchy  ");
        }

    }

    void TextTimer()
    {
        if (textTimerOn == true)
        {
            textTimer += Time.deltaTime;
        }
        if (textTimer > 3.0f)
        {
            gridTextText.enabled = false;
            textTimerOn = false;
            textTimer = 0.0f;
        }

    }

    void loadNextScene()
    {
        if (timerOn == true)
        {
            timer += Time.deltaTime;
        }

        if (timer > 2.5f)
        {
            gm.registerCollection();
        }
    }
}
