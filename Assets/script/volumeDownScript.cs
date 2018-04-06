using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volumeDownScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	void Update ()
    {
        volumeDown();
	}

    void volumeDown()
    {
        if (GameObject.Find("Music"))
        {
            GameObject.Find("Music").GetComponent<AudioSource>().volume -= 0.5f * Time.deltaTime;
        }
        else if (!GameObject.Find("Music"))
        {
            switchToLevel();
        }

        if (GameObject.Find("Music").GetComponent<AudioSource>().volume <= 0.0f)
        {
            adCaller ac = GameObject.Find("adManagerRequestInterstitial").GetComponent<adCaller>();
            ac.playAd();
            GameObject.Find("Music").GetComponent<AudioSource>().Stop();
            switchToLevel();
        }

    }

    void switchToLevel()
    {
        switch (PlayerPrefs.GetString("currentScene"))
        {
            case "mainMenu":
                SceneManager.LoadScene("level1");
                break;

            case "level1":
                SceneManager.LoadScene("level2");
                break;

            case "level2":
                SceneManager.LoadScene("level3");
                break;

            case "level3":
                SceneManager.LoadScene("level4");
                break;

            case "level4":
                SceneManager.LoadScene("level5");
                break;

            case "level5":
                SceneManager.LoadScene("level6");
                break;

            case "level6":
                SceneManager.LoadScene("level7");
                break;

            case "level7":
                SceneManager.LoadScene("level8");
                break;

            case "level8":
                SceneManager.LoadScene("level9");
                break;

            case "level9":
                SceneManager.LoadScene("level10");
                break;

            case "level10":
                SceneManager.LoadScene("level11");
                break;

            case "level11":
                SceneManager.LoadScene("level12");
                break;

            case "level12":
                SceneManager.LoadScene("level13");
                break;

            case "level13":
                SceneManager.LoadScene("level14");
                break;

            case "level14":
                SceneManager.LoadScene("level15");
                break;

            case "level15":
                SceneManager.LoadScene("level16");
                break;

            case "level16":
                SceneManager.LoadScene("level17");
                break;

            case "level17":
                SceneManager.LoadScene("level18");
                break;

            case "level18":
                SceneManager.LoadScene("level19");
                break;

            case "level19":
                SceneManager.LoadScene("level20");
                break;

            case "level20":
                SceneManager.LoadScene("level21");
                break;

            case "level21":
                SceneManager.LoadScene("level22");
                break;

            case "level22":
                SceneManager.LoadScene("level23");
                break;

            case "level23":
                SceneManager.LoadScene("level24");
                break;

            case "level24":
                SceneManager.LoadScene("level25");
                break;

            case "level25":
                SceneManager.LoadScene("level26");
                break;

            case "level26":
                SceneManager.LoadScene("level27");
                break;

            case "level27":
                SceneManager.LoadScene("level28");
                break;

            case "level28":
                SceneManager.LoadScene("level29");
                break;

            case "level29":
                SceneManager.LoadScene("level30");
                break;

            case "level30":
                SceneManager.LoadScene("level31");
                break;

            case "level31":
                SceneManager.LoadScene("level32");
                break;

            case "level32":
                SceneManager.LoadScene("level33");
                break;

            case "level33":
                SceneManager.LoadScene("level34");
                break;

            case "level34":
                SceneManager.LoadScene("level35");
                break;

            case "level35":
                SceneManager.LoadScene("level36");
                break;

            case "level36":
                SceneManager.LoadScene("level37");
                break;

            case "level37":
                SceneManager.LoadScene("mainMenu");
                break;
        }
    }
}
