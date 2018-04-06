using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelName : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
        Scene scene = SceneManager.GetActiveScene();
        gameObject.GetComponentInChildren<Text>().text = scene.name;

        }
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
