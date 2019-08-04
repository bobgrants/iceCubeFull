using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class tutorialPageSKip : MonoBehaviour {

    public Button skipBtn;
    public GameObject tutoPanel;
    
    public RectTransform position0;
    public RectTransform position1;
    public RectTransform position2;
    RectTransform tutoPanelRT;

    Rigidbody2D tutoPanelRB;

    public int tutoPanelPosition;

    public Sprite nextImage;
    public Sprite playImage;


    // Use this for initialization
    void Start () {
        tutoPanelRB = tutoPanel.GetComponent<Rigidbody2D>();
        skipBtn.onClick.AddListener(clickSkipTuto);

        tutoPanelPosition = 0;
        tutoPanelRT = tutoPanel.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void FixedUpdate () {
        PanelPosition();
	}

    void clickSkipTuto()
    {
        if (tutoPanelPosition == 0)
        {
            tutoPanelPosition = 1;
            GetComponent<Image>().sprite = nextImage;
        }
        else if (tutoPanelPosition == 1)
        {
            tutoPanelPosition = 2;
            GetComponent<Image>().sprite = playImage;
        }
        else if (tutoPanelPosition == 2)
        {
            SceneManager.LoadScene("volumeDownScene");
        }

        //tutoPanelRB.AddForce(movementTutoPanel * Time.deltaTime * 300);
        //SceneManager.LoadScene("volumeDownScene");
    }

    void PanelPosition()
    {
        if (tutoPanelPosition == 0)      { tutoPanelRT.position = Vector3.MoveTowards(tutoPanelRT.position, position0.position, 50); }
        else if (tutoPanelPosition == 1) { tutoPanelRT.position = Vector3.MoveTowards(tutoPanelRT.position, position1.position, 50); }
        else if (tutoPanelPosition == 2) { tutoPanelRT.position = Vector3.MoveTowards(tutoPanelRT.position, position2.position, 50); }
    }
}
