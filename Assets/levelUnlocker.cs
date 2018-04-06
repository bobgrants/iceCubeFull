using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class levelUnlocker : MonoBehaviour {

    public int totalStars;
    public Button[] btnAr;

    public string page2Locked;
    public string page3Locked;
    public string page4Locked;
    public string page5Locked;
    public string page6Locked;
    public string page7Locked;

    public GameObject lockPage2;
    public GameObject lockPage3;
    public GameObject lockPage4;
    public GameObject lockPage5;
    public GameObject lockPage6;
    public GameObject lockPage7;

    // Use this for initialization
    void Start () {

        //debugStarUnlock(); //add stars for debug purpose
        startLocks();

        totalStars = 0;

        initializeLocks();

        starCalculus();

    }

    void startLocks()
    {
        page2Locked = "locked";
        page3Locked = "locked";
        page4Locked = "locked";
        page5Locked = "locked";
        page6Locked = "locked";
        page7Locked = "locked";

        lockPage2 = GameObject.Find("lockPage2");
        lockPage3 = GameObject.Find("lockPage3");
        lockPage4 = GameObject.Find("lockPage4");
        lockPage5 = GameObject.Find("lockPage5");
        lockPage6 = GameObject.Find("lockPage6");
        lockPage7 = GameObject.Find("lockPage7");

        lockPage2.transform.localPosition = new Vector2(125,125);
        lockPage2.GetComponentInChildren<Text>().transform.localPosition = new Vector2(0, -lockPage2.GetComponent<RectTransform>().sizeDelta.y - 20);

        lockPage3.transform.localPosition = new Vector2(125, 125);
        lockPage3.GetComponentInChildren<Text>().transform.localPosition = new Vector2(0, -lockPage3.GetComponent<RectTransform>().sizeDelta.y - 20);

        lockPage4.transform.localPosition = new Vector2(125, 125);
        lockPage4.GetComponentInChildren<Text>().transform.localPosition = new Vector2(0, -lockPage4.GetComponent<RectTransform>().sizeDelta.y - 20);

        lockPage5.transform.localPosition = new Vector2(125, 125);
        lockPage5.GetComponentInChildren<Text>().transform.localPosition = new Vector2(0, -lockPage5.GetComponent<RectTransform>().sizeDelta.y - 20);

        lockPage6.transform.localPosition = new Vector2(125, 125);
        lockPage6.GetComponentInChildren<Text>().transform.localPosition = new Vector2(0, -lockPage6.GetComponent<RectTransform>().sizeDelta.y - 20);

        lockPage7.transform.localPosition = new Vector2(125, 125);
        lockPage7.GetComponentInChildren<Text>().transform.localPosition = new Vector2(0, -lockPage7.GetComponent<RectTransform>().sizeDelta.y - 20);

    }

    public void initializeLocks()
    {
        lockPage2.GetComponent<CanvasGroup>().alpha = 0.0f;
        lockPage2.GetComponentInChildren<Text>().text = totalStars + " / 18";

        lockPage3.GetComponent<CanvasGroup>().alpha = 0.0f;
        lockPage3.GetComponentInChildren<Text>().text = totalStars + " / 33";

        lockPage4.GetComponent<CanvasGroup>().alpha = 0.0f;
        lockPage4.GetComponentInChildren<Text>().text = totalStars + " / 51";

        lockPage5.GetComponent<CanvasGroup>().alpha = 0.0f;
        lockPage5.GetComponentInChildren<Text>().text = totalStars + " / 66";

        lockPage6.GetComponent<CanvasGroup>().alpha = 0.0f;
        lockPage6.GetComponentInChildren<Text>().text = totalStars + " / 84";

        lockPage7.GetComponent<CanvasGroup>().alpha = 0.0f;
        lockPage7.GetComponentInChildren<Text>().text = totalStars + " / 99";


    }

    void starCalculus()
    {
        int i = 0;
        int currentLevel = 0;
        for (i = 0; i < 37; i++)
        {

            currentLevel = i + 1;
            if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected") { totalStars++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected") { totalStars++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected") { totalStars++; }

        }

        Debug.Log("Total Stars: " + totalStars);

    }

	// Update is called once per frame
	void Update () {
		
	}

    public void hideLocked()
    {
        int i = 0;

        if (totalStars >= 0 && totalStars < 18) //Page 1
        {
            for (i = 6; i < 37; i++)
            {
                btnAr[i].GetComponent<Button>().enabled = false;
                btnAr[i].GetComponent<CanvasGroup>().alpha = 0.0f;

                page2Locked = "locked";
                page3Locked = "locked";
                page4Locked = "locked";
                page5Locked = "locked";
                page6Locked = "locked";
                page7Locked = "locked";
            }
        }
        else if (totalStars >= 18 && totalStars < 33) //Page 2
        {
            for (i = 11; i < 37; i++)
            {
                btnAr[i].GetComponent<Button>().enabled = false;
                btnAr[i].GetComponent<CanvasGroup>().alpha = 0.0f;
            }
            for (i = 11; i > -1; i--)
            {
                btnAr[i].GetComponent<Button>().enabled = true;
                btnAr[i].GetComponent<CanvasGroup>().alpha = 1.0f;
            }

            page2Locked = "unlocked";
            page3Locked = "locked";
            page4Locked = "locked";
            page5Locked = "locked";
            page6Locked = "locked";
            page7Locked = "locked";

        }
        else if (totalStars >= 33 && totalStars < 51) //Page 3
        {
            for (i = 17; i < 37; i++)
            {
                btnAr[i].GetComponent<Button>().enabled = false;
                btnAr[i].GetComponent<CanvasGroup>().alpha = 0.0f;
            }
            for (i = 17; i > -1; i--)
            {
                btnAr[i].GetComponent<Button>().enabled = true;
                btnAr[i].GetComponent<CanvasGroup>().alpha = 1.0f;
            }

            page2Locked = "unlocked";
            page3Locked = "unlocked";
            page4Locked = "locked";
            page5Locked = "locked";
            page6Locked = "locked";
            page7Locked = "locked";

        }
        else if (totalStars >= 51 && totalStars < 66) //Page 4
        {
            for (i = 23; i < 37; i++)
            {
                btnAr[i].GetComponent<Button>().enabled = false;
                btnAr[i].GetComponent<CanvasGroup>().alpha = 0.0f;
            }
            for (i = 23; i > -1; i--)
            {
                btnAr[i].GetComponent<Button>().enabled = true;
                btnAr[i].GetComponent<CanvasGroup>().alpha = 1.0f;
            }

            page2Locked = "unlocked";
            page3Locked = "unlocked";
            page4Locked = "unlocked";
            page5Locked = "locked";
            page6Locked = "locked";
            page7Locked = "locked";
        }
        else if (totalStars >= 66 && totalStars < 84) //Page 5
        {
            for (i = 29; i < 37; i++)
            {
                btnAr[i].GetComponent<Button>().enabled = false;
                btnAr[i].GetComponent<CanvasGroup>().alpha = 0.0f;
            }
            for (i = 29; i > -1; i--)
            {
                btnAr[i].GetComponent<Button>().enabled = true;
                btnAr[i].GetComponent<CanvasGroup>().alpha = 1.0f;
            }
            page2Locked = "unlocked";
            page3Locked = "unlocked";
            page4Locked = "unlocked";
            page5Locked = "unlocked";
            page6Locked = "locked";
            page7Locked = "locked";
        }
        else if (totalStars >= 84 && totalStars < 99) //Page 6
        {
            //for (i = 35; i < 37; i++)
            //{
            //    btnAr[i].GetComponent<Button>().enabled = false;
            //    btnAr[i].GetComponent<CanvasGroup>().alpha = 0.0f;
            //}
            for (i = 35; i > -1; i--)
            {
                btnAr[i].GetComponent<Button>().enabled = true;
                btnAr[i].GetComponent<CanvasGroup>().alpha = 1.0f;
            }
            page2Locked = "unlocked";
            page3Locked = "unlocked";
            page4Locked = "unlocked";
            page5Locked = "unlocked";
            page6Locked = "unlocked";
            page7Locked = "locked";
        }
        else if (totalStars >= 99 && totalStars < 115) //Page 7
        {
            //for (i = 35; i < 37; i++)
            //{
            //    btnAr[i].GetComponent<Button>().enabled = false;
            //    btnAr[i].GetComponent<CanvasGroup>().alpha = 0.0f;
            //}
            for (i = 35; i > -1; i--)
            {
                btnAr[i].GetComponent<Button>().enabled = true;
                btnAr[i].GetComponent<CanvasGroup>().alpha = 1.0f;
            }
            page2Locked = "unlocked";
            page3Locked = "unlocked";
            page4Locked = "unlocked";
            page5Locked = "unlocked";
            page6Locked = "unlocked";
            page7Locked = "unlocked";
        }
    }

    void debugStarUnlock()
    {
        int i = 0;
        int currentLevel;
        for (i = 0; i < 37; i++)
        {
            currentLevel = i + 1;

            if (i <= 36) {
                PlayerPrefs.SetString("level" + currentLevel + "sf1", "collected");
                PlayerPrefs.SetString("level" + currentLevel + "sf2", "collected");
                PlayerPrefs.SetString("level" + currentLevel + "sf3", "collected");
                }

            else if (i > 36) {
                PlayerPrefs.SetString("level" + currentLevel + "sf1", "null");
                PlayerPrefs.SetString("level" + currentLevel + "sf2", "null");
                PlayerPrefs.SetString("level" + currentLevel + "sf3", "null");
                }
        }         
    }
}
