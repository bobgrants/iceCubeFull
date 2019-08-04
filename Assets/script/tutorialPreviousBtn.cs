using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tutorialPreviousBtn : MonoBehaviour {

    public Button prevBtn;
    public Button nextBtn;
    public tutorialPageSKip tPS;

    public Sprite nextImage;
    public Sprite playImage;

    // Use this for initialization
    void Start () {
        prevBtn.onClick.AddListener(prevBtnClick);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void prevBtnClick()
    {
        if (tPS.tutoPanelPosition == 0)
        {
            tPS.tutoPanelPosition = 0;
            nextBtn.GetComponent<Image>().sprite = nextImage;
        }
        else if (tPS.tutoPanelPosition == 1)
        {
            tPS.tutoPanelPosition = 0;
            nextBtn.GetComponent<Image>().sprite = nextImage;
        }
        else if (tPS.tutoPanelPosition == 2)
        {
            tPS.tutoPanelPosition = 1;
            nextBtn.GetComponent<Image>().sprite = nextImage;
        }
    }
}
