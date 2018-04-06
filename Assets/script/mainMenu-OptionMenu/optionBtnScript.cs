using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class optionBtnScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Button>().onClick.AddListener(OnClickswitchOptionScreen);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnClickswitchOptionScreen()
    {
        SceneManager.LoadScene("optionsMenu");
    }
}
