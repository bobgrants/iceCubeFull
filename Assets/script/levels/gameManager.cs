using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

    public bool gameStarted;
    public bool fallStop;
    //public bool sf1Collected, sf2Collected, sf3Collected;

    float seconds;
    float mili;
    float waitGameOver;

    float localTimer;

    Text chrono;

    string sf1Collected, sf2Collected, sf3Collected;
    string currentScene;

    GameObject sf1, sf2, sf3;
    //GameObject sf1Particle, sf2Particle, sf3Particle;
    GameObject sf1CollectedPoint, sf2CollectedPoint, sf3CollectedPoint;

    //Camera cam;


    void Awake()
    {
        if (GameObject.Find("Music"))
        {
            GameObject.Find("Music").GetComponent<musicScript>().chooseMusic(SceneManager.GetActiveScene().name);
        }
    }
    // Use this for initialization
    void Start () {

        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        gameStarted = false;
        fallStop = false;

        seconds = 0;
        mili = 0;
        waitGameOver = 0;

        localTimer = 0;

        chrono = GameObject.Find("chrono").GetComponentInChildren<Text>();
        chrono.text = "0.00";
        //Debug.Log("chrone: " + chrono);

        PlayerPrefs.SetString("currentScene", SceneManager.GetActiveScene().name);


        //findCamera();
        loadGameObjects();
        //loadCollectedStatus();

        GameObject.Find("grid").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("grid").GetComponent<BoxCollider2D>().isTrigger = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        localTimer += Time.deltaTime;
        monitorCollection();
        collectionAnimation();
    }

    //void findCamera()
    //{
    //    if (GameObject.Find("Main Camera") != null)
    //    {
    //        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    //    }
    //    else if (GameObject.Find("Main CameraSand") != null)
    //    {
    //        cam = GameObject.Find("Main CameraSand").GetComponent<Camera>();
    //    }
    //}

    void FixedUpdate() {
        if (gameStarted == true && fallStop == false)
        {
            chronometre();
        }
        activateGrid();
    }

    void loadGameObjects()
    {
        sf1 = GameObject.Find("snowflake1");
        sf2 = GameObject.Find("snowflake2");
        sf3 = GameObject.Find("snowflake3");

        sf1CollectedPoint = GameObject.Find("snowflakeCollected1");
        sf2CollectedPoint = GameObject.Find("snowflakeCollected2");
        sf3CollectedPoint = GameObject.Find("snowflakeCollected3");

        //sf1Particle = sf1.transform.GetChild(0).gameObject;
        //sf2Particle = sf2.transform.GetChild(0).gameObject;
        //sf3Particle = sf3.transform.GetChild(0).gameObject;
    }

    void loadCollectedStatus()
    {
        sf1Collected = PlayerPrefs.GetString(SceneManager.GetActiveScene().name + "sf1");
        sf2Collected = PlayerPrefs.GetString(SceneManager.GetActiveScene().name + "sf2");
        sf3Collected = PlayerPrefs.GetString(SceneManager.GetActiveScene().name + "sf3");

        if (sf1Collected == "collected")
        {
            Destroy(sf1);
            sf1CollectedPoint.GetComponent<Image>().enabled = true;
        }
        if (sf2Collected == "collected")
        {
            Destroy(sf2);
            sf2CollectedPoint.GetComponent<Image>().enabled = true;
        }
        if (sf3Collected == "collected")
        {
            Destroy(sf3);
            sf3CollectedPoint.GetComponent<Image>().enabled = true;
        }
    }

    void chronometre()
    {
        waitGameOver += 100f * Time.fixedDeltaTime;
        mili += 100f * Time.fixedDeltaTime;

        if (mili >= 100)
        {
            mili = 0;
            waitGameOver = 0;
            seconds++;
        }
        //else if (seconds == 30)
        //{
            
        //    seconds = 30;
        //    mili = 00;
            
        //    if (waitGameOver > 150f) { SceneManager.LoadScene("gameOver"); }
        //}

        chrono.text = seconds.ToString() + "." + mili.ToString();

    }

    void monitorCollection()
    {
        if (GameObject.Find("snowflake1"))
        {
            if (sf1.GetComponent<snowflakeScript>().collected == true) { sf1Collected = "collected"; }
        }
        if (GameObject.Find("snowflake2"))
        {
            if (sf2.GetComponent<snowflakeScript>().collected == true) { sf2Collected = "collected"; }
        }
        if (GameObject.Find("snowflake3"))
        {
            if (sf3.GetComponent<snowflakeScript>().collected == true) { sf3Collected = "collected"; }
        }
    }

    public void registerCollection() 
    {
        if(PlayerPrefs.GetString(SceneManager.GetActiveScene().name + "sf1") != "collected" || PlayerPrefs.GetString(SceneManager.GetActiveScene().name + "sf2") != "collected" || PlayerPrefs.GetString(SceneManager.GetActiveScene().name + "sf3") != "collected")
        {
            if (sf1Collected == "collected")
            {
                PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "sf1", "collected");
            }
            else
            {
                PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "sf1", "");
            }

            if (sf2Collected == "collected")
            {
                PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "sf2", "collected");
            }
            else
            {
                PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "sf2", "");
            }

            if (sf3Collected == "collected")
            {
                PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "sf3", "collected");
            }
            else
            {
                PlayerPrefs.SetString(SceneManager.GetActiveScene().name + "sf3", "");
            }
        }

        PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name + "current" + "time", float.Parse(chrono.text));

        nextLevel();
    }

    public void nextLevel()
    {
        SceneManager.LoadScene("transitionScreen");
    }

    public void isFalling()
    {
        fallStop = true;
    }

    void collectionAnimation()
    {
        if (GameObject.Find("snowflake1") != null && sf1Collected == "collected")
        {
            if (sf1.GetComponent<snowflakeScript>().collected == true)
            {

                gameObject.GetComponent<AudioSource>().Play();
                sf1.SetActive(false); //
                sf1CollectedPoint.GetComponentInChildren<Image>().enabled = true; //
            }
        }

        if (GameObject.Find("snowflake2") != null && sf2Collected == "collected")
        {
            if (sf2.GetComponent<snowflakeScript>().collected == true)
            {
                gameObject.GetComponent<AudioSource>().Play();
                sf2.SetActive(false); //
                sf2CollectedPoint.GetComponentInChildren<Image>().enabled = true; //
            }
        }

        if (GameObject.Find("snowflake3") != null && sf3Collected == "collected")
        {
            if (sf3.GetComponent<snowflakeScript>().collected == true)
            {
                gameObject.GetComponent<AudioSource>().Play();
                sf3.SetActive(false); //
                sf3CollectedPoint.GetComponentInChildren<Image>().enabled = true; //
            }
        }
    }

    void activateGrid()
    {
        if (sf1Collected == "collected" && sf2Collected == "collected" && sf3Collected == "collected")
        {
            GameObject.Find("grid").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("grid").GetComponent<BoxCollider2D>().isTrigger = true;

            if (GameObject.Find("parasol"))
            {
                GameObject.Find("parasol").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("parasol").GetComponent<BoxCollider2D>().enabled = false;
                GameObject.Find("towel2").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("towel2").GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
}
