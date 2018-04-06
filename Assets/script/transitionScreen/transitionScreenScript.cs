using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class transitionScreenScript : MonoBehaviour {

    string currentChrono;
    string bestChrono;

    Text chronoBoxText;
    GameObject chronoBoxObject;

    Text bestChronoBoxText;
    GameObject bestChronoBoxObject;

    GameObject sf1Result;
    GameObject sf2Result;
    GameObject sf3Result;

    Button mainMenuButton;
    Button restartButton;
    Button nextButton;

    // Use this for initialization
    void Start () {

        chronoBoxText = GameObject.Find("chrono").GetComponentInChildren<Text>();
        chronoBoxObject = GameObject.Find("chrono");

        bestChronoBoxText = GameObject.Find("bestChrono").GetComponentInChildren<Text>();
        bestChronoBoxObject = GameObject.Find("bestChrono");

        sf1Result = GameObject.Find("sf1Result");
        sf2Result = GameObject.Find("sf2Result");
        sf3Result = GameObject.Find("sf3Result");

        mainMenuButton = GameObject.Find("mainMenuBtn").GetComponent<Button>();
        restartButton = GameObject.Find("restartBtn").GetComponent<Button>();
        nextButton = GameObject.Find("nextBtn").GetComponent<Button>();

        currentChrono = PlayerPrefs.GetFloat(PlayerPrefs.GetString("currentScene")+ "current" + "time").ToString();
        bestChrono = PlayerPrefs.GetFloat(PlayerPrefs.GetString("currentScene") + "time").ToString();

        if (PlayerPrefs.GetFloat(PlayerPrefs.GetString("currentScene") + "current" + "time") < PlayerPrefs.GetFloat(PlayerPrefs.GetString("currentScene") + "time") || PlayerPrefs.GetFloat(PlayerPrefs.GetString("currentScene") + "time") == 0.0f)
        {
            //PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name + "time", PlayerPrefs.GetFloat(PlayerPrefs.GetString("currentScene") + "current" + "time"));
            PlayerPrefs.SetFloat(PlayerPrefs.GetString("currentScene") + "time", PlayerPrefs.GetFloat(PlayerPrefs.GetString("currentScene") + "current" + "time"));

            bestChrono = PlayerPrefs.GetFloat(PlayerPrefs.GetString("currentScene") + "time").ToString();

            Debug.Log("Best Time Updated");
            Debug.Log("Best Time: " + PlayerPrefs.GetFloat(PlayerPrefs.GetString("currentScene") + "time"));

            Debug.Log(SceneManager.GetActiveScene().name);
            Debug.Log(PlayerPrefs.GetString("currentScene"));
        }

        

        chronoBoxText.text = currentChrono + " seconds";
        bestChronoBoxText.text = "Best: " + bestChrono + " seconds";

        displaySF();
        centerBoxes();
    }

    void centerBoxes()
    {
        float screenWidthDiv2 = Screen.width / 2; // 50% 
        //float screenWidthDiv4 = screenWidthDiv2 / 2; // 25%

        float screenWidth10p = Screen.width / 10; // 10% 
        float screenWidth15p = Screen.width / 6.5f; // 15% 
        float screenWidth20p = Screen.width / 5; // 20% 
        float screenWidth33p = Screen.width / 3; // 33% 



        float screenHeightDiv2 = Screen.height / 2; // 50% 
        //float screenHeightDiv4 = screenHeightDiv2 / 2; // 25%
     
        //float screenHeight10p = Screen.height / 10; // 10% 
        //float screenHeight15p = Screen.height / 6.5f; // 15% 
        float screenHeight20p = Screen.height / 5; // 20% 
        float screenHeight33p = Screen.height / 3; // 33% 

        //Debug.Log(screenWidthDiv2);
        //Debug.Log(screenWidthDiv4);

        chronoBoxObject.transform.position = new Vector2(screenWidthDiv2 + screenWidth20p, screenHeightDiv2 + screenHeight33p);
        bestChronoBoxObject.transform.position = new Vector2(screenWidthDiv2 + screenWidth10p, screenHeightDiv2 + screenHeight20p);

        //Debug.Log(chronoBoxObject.transform.position);

        sf1Result.transform.position = new Vector2(screenWidthDiv2, chronoBoxObject.transform.position.y - screenHeight33p);
        sf2Result.transform.position = new Vector2(sf1Result.transform.position.x - screenWidth15p, sf1Result.transform.position.y);
        sf3Result.transform.position = new Vector2(sf1Result.transform.position.x + screenWidth15p, sf1Result.transform.position.y);

        restartButton.transform.position = new Vector2(screenWidthDiv2, screenHeight20p);
        mainMenuButton.transform.position = new Vector2(restartButton.transform.position.x - screenWidth20p, screenHeight20p);
        nextButton.transform.position = new Vector2(restartButton.transform.position.x + screenWidth20p, screenHeight20p);
    }

    void Update () {
		
	}

    void displaySF()
    {
        if (PlayerPrefs.GetString(PlayerPrefs.GetString("currentScene") + "sf1") == "collected")
        {
            GameObject.Find("sf1Result").GetComponentInChildren<Image>().enabled = true;
        }
        if (PlayerPrefs.GetString(PlayerPrefs.GetString("currentScene") + "sf2") == "collected")
        {
            GameObject.Find("sf2Result").GetComponentInChildren<Image>().enabled = true;
        }
        if (PlayerPrefs.GetString(PlayerPrefs.GetString("currentScene") + "sf3") == "collected")
        {
            GameObject.Find("sf3Result").GetComponentInChildren<Image>().enabled = true;
        }
    }
}
