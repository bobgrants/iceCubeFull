using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class stopMusicScript : MonoBehaviour {

    public Sprite soundOn;
    public Sprite soundOff;
    Button stopMusicBtn;


	// Use this for initialization
	void Start () {
        //gameObject.GetComponent<Image>().sprite = soundOn;
        stopMusicBtn = gameObject.GetComponent<Button>();
        stopMusicBtn.onClick.AddListener(OnClickstopMusicBtn);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnClickstopMusicBtn()
    {
        if (gameObject.GetComponent<Image>().sprite == soundOn)
        {
            gameObject.GetComponent<Image>().sprite = soundOff;
            GameObject.Find("Music").GetComponent<musicScript>().volumeOff = true;
            GameObject.Find("Music").GetComponent<musicScript>().turnOffMusic();

        }
        else if (gameObject.GetComponent<Image>().sprite == soundOff)
        {
            gameObject.GetComponent<Image>().sprite = soundOn;
            GameObject.Find("Music").GetComponent<musicScript>().volumeOff = false;
            GameObject.Find("Music").GetComponent<musicScript>().chooseMusic(SceneManager.GetActiveScene().name);
        }
        
    }
}
