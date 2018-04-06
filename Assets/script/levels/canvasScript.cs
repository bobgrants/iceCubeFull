using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasScript : MonoBehaviour {

    GameObject chrono;

    GameObject levelNameBox;


    GameObject sf1, sf2, sf3;

    void Start () {
        chrono = GameObject.Find("chrono");
        levelNameBox = GameObject.Find("levelName");

        sf1 = GameObject.Find("snowflakeCollected1");
        sf2 = GameObject.Find("snowflakeCollected2");
        sf3 = GameObject.Find("snowflakeCollected3");

        centerBoxes();

	}
	
	void Update () {
		
	}

    void centerBoxes()
    {
        float screenWidth50p = Screen.width / 2; // 50% 
        //float screenWidth25p = screenWidth50p / 2; // 25%

        float screenWidth10p = Screen.width / 10; // 10% 
        //float screenWidth15p = Screen.width / 6.5f; // 15% 
        //float screenWidth20p = Screen.width / 5; // 20% 
        //float screenWidth33p = Screen.width / 3; // 33% 
        float screenWidth05p = screenWidth10p / 2; // 5% 
        

        //float screenHeight50p = Screen.height / 2; // 50% 
        //float screenHeight25p = screenHeight50p / 2; // 25%

        float screenHeight10p = Screen.height / 10; // 10% 
        //float screenHeight15p = Screen.height / 6.5f; // 15% 
        //float screenHeight20p = Screen.height / 5; // 20% 
        //float screenHeight33p = Screen.height / 3; // 33% 
        //float screenHeight05p = screenHeight10p / 2; // 5%

        chrono.transform.position = new Vector2(screenWidth50p, Screen.height - screenHeight10p);
        levelNameBox.transform.position = new Vector2(levelNameBox.transform.position.x, chrono.transform.position.y);

        sf1.transform.position = new Vector2(screenWidth05p, chrono.transform.position.y);
        sf2.transform.position = new Vector2(sf1.transform.position.x + screenWidth10p, chrono.transform.position.y);
        sf3.transform.position = new Vector2(sf2.transform.position.x + screenWidth10p, chrono.transform.position.y);

    }
}
