using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSeaWave : MonoBehaviour {

    gameManager gm;
    float timer;

    bool timerOn;

    GameObject iceCube;

    // Use this for initialization
    void Start () {
        gm = GameObject.Find("gameManager").GetComponentInChildren<gameManager>();
        timerOn = false;
        iceCube = GameObject.Find("icecube");
    }
	
	// Update is called once per frame
	void Update () {
        loadNextScene();
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.name == iceCube.name)
        {
            iceCube.GetComponent<movementCube>().speed = 0.0f;
            timerOn = true;
            gm.gameStarted = false;
            timerOn = true;
            iceCube.GetComponentInChildren<meltDown>().shrinking = false;
            iceCube.GetComponentInChildren<meltDown>().enabled = false;
            iceCube.GetComponentInChildren<movementCube>().enabled = false;
            iceCube.GetComponentInChildren<touchMelt>().enabled = false;
            iceCube.GetComponentInChildren<keyboard>().enabled = false;
            Destroy(c);
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
            SceneManager.LoadScene("gameOver");
        }
    }
}
