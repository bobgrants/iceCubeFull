using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class testBtnScript : MonoBehaviour {

    public Button testBtn;
    Image btnImage;

	// Use this for initialization
	void Start () {


        testBtn.onClick.AddListener(OnClick);

        btnImage = testBtn.GetComponent<Image>();

        Debug.Log("testBtn image: " + btnImage);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnClick()
    {
        Debug.Log("Clicked");

        testBtn.GetComponent<CanvasGroup>().alpha = 0;

    }
}
