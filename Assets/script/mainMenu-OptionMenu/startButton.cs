using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startButton : MonoBehaviour {

    

    void Start()
    {
        PlayerPrefs.SetString("currentScene", SceneManager.GetActiveScene().name);
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnClick() {
        SceneManager.LoadScene("storyboard");

    }


}
