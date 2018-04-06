using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelSelectEnsemble : MonoBehaviour {

    public Button[] btnAr;
    public Camera cam;

    public bool fadeIn;
    public bool fadeOut;

    public Button nextBtn;
    public Button previousBtn;

    public int currentPage;

    public GameObject snowflake;

    
    void Awake()
    {
        this.gameObject.GetComponent<CanvasGroup>().alpha = 0.0f;
    }

	// Use this for initialization
	void Start () {
        
        //debugTime(); //add 33.3 seconds score to all levels

        currentPage = 1;
        buttonPlacement();
        
        fadeIn = false;
        fadeOut = false;
        
        nextBtn.GetComponent<Button>().onClick.AddListener(nextPageLevelList);
        previousBtn.GetComponent<Button>().onClick.AddListener(previousPageLevelList);
        previousBtn.GetComponent<Image>().enabled = false;

    }

    // Update is called once per frame
    void Update () {


    }

    void nextPageLevelList()
    {
        GetComponent<levelUnlocker>().hideLocked();
        GetComponent<levelUnlocker>().initializeLocks();

        currentPage++;
        previousBtn.GetComponent<Image>().enabled = true;

        if (currentPage >= 7)
        {
            currentPage = 7;
            nextBtn.GetComponent<Image>().enabled = false;
        }
        else if (currentPage < 7)
        {
            nextBtn.GetComponent<Image>().enabled = true;
        }

        buttonPlacement();

        if (currentPage == 2 && GetComponent<levelUnlocker>().page2Locked == "locked")
        {
            GetComponent<levelUnlocker>().lockPage2.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
        else if (currentPage == 3 && GetComponent<levelUnlocker>().page3Locked == "locked")
        {
            GetComponent<levelUnlocker>().lockPage3.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
        else if (currentPage == 4 && GetComponent<levelUnlocker>().page4Locked == "locked")
        {
            GetComponent<levelUnlocker>().lockPage4.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
        else if (currentPage == 5 && GetComponent<levelUnlocker>().page5Locked == "locked")
        {
            GetComponent<levelUnlocker>().lockPage5.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
        else if (currentPage == 6 && GetComponent<levelUnlocker>().page6Locked == "locked")
        {
            GetComponent<levelUnlocker>().lockPage6.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
        else if (currentPage == 7 && GetComponent<levelUnlocker>().page7Locked == "locked")
        {
            GetComponent<levelUnlocker>().lockPage7.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
    }

    void previousPageLevelList()
    {
        GetComponent<levelUnlocker>().hideLocked();
        GetComponent<levelUnlocker>().initializeLocks();

        currentPage--;
        nextBtn.GetComponent<Image>().enabled = true;

        if (currentPage <= 1)
        {
            currentPage = 1;
            previousBtn.GetComponent<Image>().enabled = false;
        }
        else if (currentPage > 1)
        {
            previousBtn.GetComponent<Image>().enabled = true;
        }

        buttonPlacement();

        if (currentPage == 2 && GetComponent<levelUnlocker>().page2Locked == "locked")
        {
            GetComponent<levelUnlocker>().lockPage2.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
        else if (currentPage == 3 && GetComponent<levelUnlocker>().page3Locked == "locked")
        {
            GetComponent<levelUnlocker>().lockPage3.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
        else if (currentPage == 4 && GetComponent<levelUnlocker>().page4Locked == "locked")
        {
            GetComponent<levelUnlocker>().lockPage4.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
        else if (currentPage == 5 && GetComponent<levelUnlocker>().page5Locked == "locked")
        {
            GetComponent<levelUnlocker>().lockPage5.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
        else if (currentPage == 6 && GetComponent<levelUnlocker>().page6Locked == "locked")
        {
            GetComponent<levelUnlocker>().lockPage6.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
        else if (currentPage == 7 && GetComponent<levelUnlocker>().page7Locked == "locked")
        {
            GetComponent<levelUnlocker>().lockPage7.GetComponent<CanvasGroup>().alpha = 1.0f;
        }
    }

    void buttonPlacement()
    {
        int i = 0;

        float screenWidthPixel = cam.pixelWidth;
        float screenHeightPixel = cam.pixelHeight;

        float screenWidthPixel20p = cam.pixelWidth / 5;
        
        float screenHeightPixel5p = cam.pixelHeight / 20;
        float screenHeightPixel40p = cam.pixelHeight / 2.5f;

        Vector3 initialScreenPos = new Vector3(screenWidthPixel / 2, screenHeightPixel - btnAr[0].gameObject.GetComponent<RectTransform>().sizeDelta.y / 2 - screenHeightPixel5p - screenHeightPixel5p, 0.0f);

        if (currentPage == 1)
        {
            for (i = 0; i < 37; i++)
            {
                int currentLevelLoop = i + 1;
                if (i == 0)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }

                    if (PlayerPrefs.GetString("level" + currentLevelLoop + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevelLoop + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevelLoop + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }


                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevelLoop + "time").ToString();
                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;

                    //Debug.Log(PlayerPrefs.GetFloat("level" + currentLevelLoop + "time"));

                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else if (i == 3)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevelLoop + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevelLoop + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevelLoop + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevelLoop + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else if (i == 6 || i == 12 || i == 18 || i == 24)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i == 9 || i == 15 || i == 21)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i > 0 && i < 6)
                {

                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }

                    //Debug.Log("Loop snowflake display: " + i + " - " + "level" + currentLevelLoop + "sf1");

                    if (PlayerPrefs.GetString("level" + currentLevelLoop + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevelLoop + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevelLoop + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevelLoop + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else
                {
                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    btnAr[i].gameObject.SetActive(false);
                }
            }
        }
        else if (currentPage == 2)
        {
            for (i = 0; i < 37; i++)
            {
                int currentLevel = i + 1;
                //Debug.Log("btnAr: " + btnAr[i] + " i= " + i);
                if (i == 6)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else if (i == 9)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else if (i == 0 || i == 12 || i == 18 || i == 24)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i == 3 || i == 15 || i == 21)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i > 6 && i < 12)
                {
                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else //if (i != 0 && i != 3) && i != 6 && i != 9 && i != 12)
                {
                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    btnAr[i].gameObject.SetActive(false);
                }
            }
        }
        else if (currentPage == 3)
        {
            for (i = 0; i < 37; i++)
            {
                int currentLevel = i + 1;
                //Debug.Log("btnAr: " + btnAr[i] + " i= " + i);
                if (i == 12)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else if (i == 15)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else if (i == 0 || i == 6 || i == 18 || i == 24)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i == 3 || i == 9 || i == 21)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i > 12 && i < 18)
                {
                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else
                {
                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    btnAr[i].gameObject.SetActive(false);
                }
            }
        }
        else if (currentPage == 4)
        {
            for (i = 0; i < 37; i++)
            {
                int currentLevel = i + 1;
                if (i == 18)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")   // Check if stars has been collected
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else if (i == 21)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); Debug.Log("Button " + i + btnAr[i].gameObject.activeInHierarchy); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }

                }
                else if (i == 0 || i == 6 || i == 12 || i == 18)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i == 3 || i == 9 || i == 15)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i > 18 && i < 24)
                {
                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else
                {
                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    btnAr[i].gameObject.SetActive(false);
                }
            }
        }
        else if (currentPage == 5)
        {
            for (i = 0; i < 37; i++)
            {
                int currentLevel = i + 1;
                if (i == 24)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")   // Check if stars has been collected
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else if (i == 27)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); Debug.Log("Button " + i + btnAr[i].gameObject.activeInHierarchy); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else if (i == 0 || i == 6 || i == 12 || i == 18)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i == 3 || i == 9 || i == 15 || i == 21)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i > 24 && i < 31)
                {
                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else
                {
                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    btnAr[i].gameObject.SetActive(false);
                }
            }
        }
        else if (currentPage == 6)
        {
            for (i = 0; i < 37; i++)
            {
                int currentLevel = i + 1;
                if (i == 30)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")   // Check if stars has been collected
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else if (i == 33)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); Debug.Log("Button " + i + btnAr[i].gameObject.activeInHierarchy); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else if (i == 0 || i == 6 || i == 12 || i == 18 || i == 24)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i == 3 || i == 9 || i == 15 || i == 21 || i == 27)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i > 30 && i < 37)
                {
                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else
                {
                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    btnAr[i].gameObject.SetActive(false);
                }
            }
        }
        else if (currentPage == 7)
        {
            for (i = 0; i < 37; i++)
            {
                int currentLevel = i + 1;
                if (i == 36)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")   // Check if stars has been collected
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else if (i == 39)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); Debug.Log("Button " + i + btnAr[i].gameObject.activeInHierarchy); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else if (i == 0 || i == 6 || i == 12 || i == 18 || i == 24)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos;
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i == 3 || i == 9 || i == 15 || i == 21 || i == 27)
                {
                    btnAr[i].gameObject.transform.position = initialScreenPos - new Vector3(0.0f, screenHeightPixel40p, 0.0f);
                    btnAr[i].gameObject.SetActive(false);
                }
                else if (i > 36 && i < 42)
                {
                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    if (!btnAr[i].gameObject.activeInHierarchy) { btnAr[i].gameObject.SetActive(true); }
                    if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").transform.localPosition = new Vector3(-35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").transform.localPosition = new Vector3(0.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (1)").gameObject.SetActive(false);
                    }

                    if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected")
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(true);
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").transform.localPosition = new Vector3(35.0f, -70.0f, 1.0f);
                    }
                    else
                    {
                        btnAr[i].transform.Find("snowflakeLevelSelectScreen (2)").gameObject.SetActive(false);
                    }

                    btnAr[i].GetComponentInChildren<Text>().GetComponent<RectTransform>().transform.localPosition = new Vector2(0, -105);
                    btnAr[i].GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("level" + currentLevel + "time").ToString();

                    btnAr[i].GetComponentInChildren<Text>().fontSize = 30;
                    if (btnAr[i].GetComponentInChildren<Text>().text == "0")
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = false;
                    }
                    else
                    {
                        btnAr[i].GetComponentInChildren<Text>().enabled = true;
                    }
                }
                else
                {
                    btnAr[i].gameObject.transform.position = btnAr[i - 1].gameObject.transform.position + (new Vector3(screenWidthPixel20p, 0.0f, 0.0f));
                    btnAr[i].gameObject.SetActive(false);
                }
            }


        }
    }
    void debugTime()
    {
        int i = 0;
        for (i = 0; i < 37; i++)
            {
            int currentLevel = i + 1;
            PlayerPrefs.SetFloat("level" + currentLevel + "time", 33.3f);
        }
    }
}
    
