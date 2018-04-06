using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lvl05Button : MonoBehaviour {

    

    void Start()
    {
        
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnClick() {
        SceneManager.LoadScene("level05");

    }


}
