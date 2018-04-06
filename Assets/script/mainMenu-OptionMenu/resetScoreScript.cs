using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class resetScoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Button>().onClick.AddListener(resetScores);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void resetScores()
    {
        
        int i = 0;
        for (i = 0; i < 38; i++)
        {
            if (i == 0)
            {
                //Debug.Log("Do nothing");
            }
            else
            {
                //Debug.Log("reseting level "+i);
                PlayerPrefs.SetString("level" + i + "sf1", "null");
                PlayerPrefs.SetString("level" + i + "sf2", "null");
                PlayerPrefs.SetString("level" + i + "sf3", "null");
                PlayerPrefs.SetFloat("level" + i + "time", 0.0f);
                PlayerPrefs.SetFloat("level" + i + "current" + "time", 0.0f);
            }
            SceneManager.LoadScene("mainMenu");
        }
    }
}
