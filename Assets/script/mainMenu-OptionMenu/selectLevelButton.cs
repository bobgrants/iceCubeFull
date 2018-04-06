using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class selectLevelButton : MonoBehaviour {

    public Button yourButton;

    void Start()
    {
        
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnClick() {
        SceneManager.LoadScene("lvlSelect");

    }


}
