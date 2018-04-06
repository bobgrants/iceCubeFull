using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class tutorialPageSKip : MonoBehaviour {

    public Button skipBtn;

	// Use this for initialization
	void Start () {
        skipBtn.onClick.AddListener(clickSkipTuto);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void clickSkipTuto()
    {
        SceneManager.LoadScene("volumeDownScene");
    }
}
