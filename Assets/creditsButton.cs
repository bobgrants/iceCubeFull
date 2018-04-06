using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class creditsButton : MonoBehaviour {

    Button creditsBtn;
    
        // Use this for initialization
    void Start () {
        creditsBtn = this.gameObject.GetComponent<Button>();
        creditsBtn.onClick.AddListener(OnClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnClick()
    {
        SceneManager.LoadScene("creditsScene");
    }
}
