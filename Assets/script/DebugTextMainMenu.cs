using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DebugTextMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = PlayerPrefs.GetString("adRemoveStatus");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.R))
        {
            resetInApp();
        }
	}

    void resetInApp(){
        PlayerPrefs.SetString("adRemoveStatus", null);
        SceneManager.LoadScene("mainMenu");
    }
}
