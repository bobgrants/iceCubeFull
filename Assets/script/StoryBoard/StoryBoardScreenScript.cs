using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryBoardScreenScript : MonoBehaviour {

    //Image panel1;
    //Image panel2;
    //Image panel3;
    //Image panel4;

    GameObject panel1;
    GameObject panel2;
    GameObject panel3;
    GameObject panel4;

    BoxCollider2D tapDetector;

    private float holdTime = 0.1f; // time for a touch to be considered a hold
    private float acumTime = 0; // Accumulated time since begining of hold
    private float screenTime = 2.0f; // Time before player can skip next screen


    bool panel1Move;
    bool panel2Move;
    bool panel3Move;
    bool panel4Move;

    Button skipButton;

    // Use this for initialization
    void Start () {
        panel1 = GameObject.Find("panel1");
        panel2 = GameObject.Find("panel2");
        panel3 = GameObject.Find("panel3");
        panel4 = GameObject.Find("panel4");
        tapDetector = GameObject.Find("tapDetector").GetComponent<BoxCollider2D>();

        //Debug.Log(panel1);
        //Debug.Log(tapDetector);

        panel1Move = false;
        panel2Move = false;
        panel3Move = false;
        panel4Move = false;

        screenTime = 0.0f;

        skipButton = GameObject.Find("skipButton").GetComponent<Button>();
        skipButton.onClick.AddListener(clickSkipIntro);
        //Debug.Log(skipButton);
    }

    void clickSkipIntro()
    {
        Debug.Log("Clicked Skip Intro");

        //GameObject.Find("Music").GetComponent<musicScript>().fadeVolume = true;

        SceneManager.LoadScene("tutorialScene");
    }

    // Update is called once per frame
    void Update ()
    {
        mouseClickPosition();
        autoSkipPanel();
    }

    void FixedUpdate()
    {
        panelMovmt();
        screenTime += Time.deltaTime;
    }

    void mouseClickPosition()
    {
        if (Input.GetButton("Fire1"))
        {
            rayCastMethod();

        }
        else if (Input.touchCount > 0)
        {
            acumTime += Input.GetTouch(0).deltaTime;

            if (acumTime >= holdTime)
            {
                if (Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position) == transform.position)
                {
                    rayCastMethodTouch();
                }
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                acumTime = 0;
            }
        }
    }

    void rayCastMethod()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), -Vector2.zero);
        if (hit.collider == tapDetector)
        {
 

            if (panel1 && screenTime > 1.0f)
            {
                panel1Move = true;
            }
            else if (!panel1 && panel2 && screenTime > 1.0f)
            {
                panel2Move = true;
            }
            else if (!panel1 && !panel2 && panel3 && screenTime > 1.0f)
            {
                panel3Move = true;
            }
            else if (!panel1 && !panel2 && !panel3 && panel4 && screenTime > 1.0f)
            {
                panel4Move = true;
            }
        }
    }

    void rayCastMethodTouch()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position), -Vector2.zero);
        if (hit.collider == tapDetector)
        {
            Debug.Log(hit.collider);
        }
    }

    void autoSkipPanel()
    {
        if (panel1 && screenTime > 4.0f)
        {
            panel1Move = true;
        }
        else if (!panel1 && panel2 && screenTime > 4.0f)
        {
            panel2Move = true;
        }
        else if (!panel1 && !panel2 && panel3 && screenTime > 4.0f)
        {
            panel3Move = true;
        }
        else if (!panel1 && !panel2 && !panel3 && panel4 && screenTime > 4.0f)
        {
            panel4Move = true;
        }
    }

    void panelMovmt()
    {
        float panelSpeed = -1.0f;

        if (panel1 && panel1Move == true)
        {
            panel1.transform.position += new Vector3(0, panelSpeed, 0);
            if (panel1.transform.position.y < -50f) { Destroy(panel1); Debug.Log("Destroy1"); screenTime = 0.0f; }
        }
        if (panel2 && panel2Move == true)
        {
            panel2.transform.position += new Vector3(0, panelSpeed, 0);
            if (panel2.transform.position.y < -50f) { Destroy(panel2); Debug.Log("Destroy2"); screenTime = 0.0f; }
        }
        if (panel3 && panel3Move == true)
        {
            panel3.transform.position += new Vector3(0, panelSpeed, 0);
            if (panel3.transform.position.y < -50f) { Destroy(panel3); Debug.Log("Destroy3"); screenTime = 0.0f; }
        }
        if (panel4 && panel4Move == true)
        {
            if (GameObject.Find("Music"))
            {
                GameObject.Find("Music").GetComponent<musicScript>().fadeVolume = true;
            }

            GameObject.Find("panel4").GetComponent<Renderer>().material.color = Color.black;

            GameObject.Find("Canvas").GetComponent<CanvasGroup>().alpha = 0.0f;
            GameObject.Find("Directional light").GetComponent<Light>().intensity = 0.0f;
            SceneManager.LoadScene("tutorialScene");
        }
    }
}
