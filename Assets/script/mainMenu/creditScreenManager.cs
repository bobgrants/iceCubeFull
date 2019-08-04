using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class creditScreenManager : MonoBehaviour {

    public GameObject titleText;
    public GameObject programmerText;
    public GameObject graphicalText;
    public GameObject graphicalText2;
    public GameObject musicText;

    public GameObject returnBtn;


	// Use this for initialization
	 IEnumerator Start () {
        yield return null;
        graphicalText2 = GameObject.Find("graphical2");

        centerBoxes();

    }

    //IEnumerator Start()
    //{
    //    yield return null;
    //    Debug.Log(GetComponent<RectTransform>().rect.width);
    //}

    // Update is called once per frame
    void Update () {
		
	}

    void centerBoxes()
    {
        float screenWidthDiv2 = Screen.width / 2; // 50% 
        //float screenWidthDiv4 = screenWidthDiv2 / 2; // 25%
        float screenWidth10p = Screen.width / 10; // 10% 
        //float screenWidth15p = Screen.width / 6.5f; // 15% 
        //float screenWidth20p = Screen.width / 5; // 20% 
        //float screenWidth33p = Screen.width / 3; // 33% 



        //float screenHeightDiv2 = Screen.height / 2; // 50% 
        //float screenHeightDiv4 = screenHeightDiv2 / 2; // 25%
        float screenHeight10p = Screen.height / 10; // 10% 
        float screenHeight15p = Screen.height / 6.5f; // 15% 
        float screenHeight20p = Screen.height / 5; // 20% 
        //float screenHeight33p = Screen.height / 3; // 33% 
        float screenHeight2_5p = screenHeight10p / 5; // 2.5%


        titleText.transform.position = new Vector2(screenWidthDiv2, Screen.height-screenHeight15p);
        programmerText.transform.position = new Vector2(screenWidthDiv2, titleText.transform.position.y - screenHeight20p);
        graphicalText.transform.position = new Vector2(screenWidthDiv2, programmerText.transform.position.y - screenHeight15p);
        graphicalText2.transform.position = new Vector2(graphicalText2.transform.position.x, graphicalText.transform.position.y - screenHeight2_5p - screenHeight2_5p - screenHeight2_5p - screenHeight2_5p);
        musicText.transform.position = new Vector2(screenWidthDiv2, graphicalText.transform.position.y - screenHeight20p - screenHeight2_5p);

        returnBtn.transform.position = new Vector2(screenWidth10p, musicText.transform.position.y - screenHeight15p);

        Debug.Log(graphicalText2);
        Debug.Log(graphicalText2.GetComponent<RectTransform>().rect.width * GameObject.Find("Canvas (1)").GetComponent<CanvasScaler>().scaleFactor);

    }
}
