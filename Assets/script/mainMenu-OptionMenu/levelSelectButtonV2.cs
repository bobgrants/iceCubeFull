using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelSelectButtonV2 : MonoBehaviour {

    public Canvas canvas;
    public Camera cam;

    public Button levelSelectButton;
    public Button startButton;
    public Button backMainMenu;
    public Button optionBtn;
    public Button stopMusic;
    public Button rateUsBtn;

    public Image title;
    public Image title2;

    public GameObject ensemble;

    //float camMovementSpeed;

    public string camPosition;

    bool levelSelectClick;
    //bool levelSelectDisplayed;

    void Start()
    {
        ensemble.gameObject.SetActive(false);

        Button btnLevelSelect = levelSelectButton.GetComponent<Button>();
        btnLevelSelect.onClick.AddListener(OnClickLevelSelect);

        Button btnbackMainMenu = backMainMenu.GetComponent<Button>();
        btnbackMainMenu.onClick.AddListener(OnClickBackMainMenu);

        //camMovementSpeed = 2.5f;

        camPosition = "MainMenu";

        levelSelectClick = false;
        //levelSelectDisplayed = false;
    }


    // Update is called once per frame
    void Update ()
    {
        clampCamera();   
    }

    void clampCamera()
    {
        cam.transform.position = new Vector2(Mathf.Clamp(cam.transform.position.x, -4.0f, 5.5f), Mathf.Clamp(cam.transform.position.y, -2.5f, 2.5f)); //Clamp camera between x -4.2/4.5 and y -2.7/2.5
    }

    void FixedUpdate()
    {
        displayingLevelButtons();
    }

    void displayingLevelButtons()
    {
        if (levelSelectClick)
        {
            ensemble.GetComponent<CanvasGroup>().alpha += 0.05f;
        }
    }

    void OnClickLevelSelect()
    {
        levelSelectClick = true;
        //Debug.Log("OnClickLevelSelect levelSelectClick : " + levelSelectClick);

        ensemble.gameObject.SetActive(true);

        levelSelectButton.GetComponentInChildren<Image>().enabled = false;
        //levelSelectButton.GetComponentInChildren<Text>().enabled = false;
        levelSelectButton.GetComponentInChildren<Button>().enabled = false;

        startButton.gameObject.SetActive(false);
        optionBtn.gameObject.SetActive(false);
        stopMusic.gameObject.SetActive(false);
        title.gameObject.SetActive(false);
        title2.gameObject.SetActive(false);
        rateUsBtn.gameObject.SetActive(false);

    }

    void OnClickBackMainMenu()
    {
        levelSelectClick = false;
        Debug.Log("OnClickBackMainMenu levelSelectClick : " + levelSelectClick);

        ensemble.GetComponent<CanvasGroup>().alpha = 0.0f;
        ensemble.gameObject.SetActive(false);

        levelSelectButton.GetComponentInChildren<Image>().enabled = true;
        //levelSelectButton.GetComponentInChildren<Text>().enabled = true;
        levelSelectButton.GetComponentInChildren<Button>().enabled = true;

        startButton.gameObject.SetActive(true);
        optionBtn.gameObject.SetActive(true);
        stopMusic.gameObject.SetActive(true);
        title.gameObject.SetActive(true);
        title2.gameObject.SetActive(true);
        rateUsBtn.gameObject.SetActive(true);

    }
}
