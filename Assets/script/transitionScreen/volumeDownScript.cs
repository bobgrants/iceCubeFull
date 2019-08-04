using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volumeDownScript : MonoBehaviour
{


    int totalStarsPage2;
    int totalStarsPage3;
    int totalStarsPage4;
    int totalStarsPage5;
    int totalStarsPage6;
    int totalStarsPage7;

    // Use this for initialization
    void Start()
    {

    }



    void Update()
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
                starCalculusPage2();
                if (totalStarsPage2 >= 18)
                {
                    SceneManager.LoadScene("level7");
                }
                else if (totalStarsPage2 < 18)
                {
                    SceneManager.LoadScene("mainMenu");
                }
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
                starCalculusPage3();
                if (totalStarsPage3 >= 33)
                {
                    SceneManager.LoadScene("level13");
                }
                else if (totalStarsPage3 < 33)
                {
                    SceneManager.LoadScene("mainMenu");
                }
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
                starCalculusPage4();
                if (totalStarsPage4 >= 51)
                {
                    SceneManager.LoadScene("level19");
                }
                else if (totalStarsPage4 < 51)
                {
                    SceneManager.LoadScene("mainMenu");
                }
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
                starCalculusPage5();
                if (totalStarsPage5 >= 66)
                {
                    SceneManager.LoadScene("level25");
                }
                else if (totalStarsPage5 < 66)
                {
                    SceneManager.LoadScene("mainMenu");
                }
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
                starCalculusPage6();
                if (totalStarsPage6 >= 84)
                {
                    SceneManager.LoadScene("level31");
                }
                else if (totalStarsPage6 < 84)
                {
                    SceneManager.LoadScene("mainMenu");
                }
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
                starCalculusPage7();
                if (totalStarsPage7 >= 99)
                {
                    SceneManager.LoadScene("level37");
                }
                else if (totalStarsPage7 < 99)
                {
                    SceneManager.LoadScene("mainMenu");
                }
                break;

            case "level37":
                SceneManager.LoadScene("mainMenu");
                break;
        }
    }

    void starCalculusPage2()
    {
        int i = 0;
        int currentLevel = 0;
        for (i = 0; i < 6; i++)
        {

            currentLevel = i + 1;
            if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected") { totalStarsPage2++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected") { totalStarsPage2++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected") { totalStarsPage2++; }

        }
    }

    void starCalculusPage3()
    {
        int i = 0;
        int currentLevel = 0;
        for (i = 0; i < 12; i++)
        {

            currentLevel = i + 1;
            if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected") { totalStarsPage3++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected") { totalStarsPage3++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected") { totalStarsPage3++; }

        }
    }

    void starCalculusPage4()
    {
        int i = 0;
        int currentLevel = 0;
        for (i = 0; i < 18; i++)
        {

            currentLevel = i + 1;
            if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected") { totalStarsPage4++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected") { totalStarsPage4++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected") { totalStarsPage4++; }

        }
    }

    void starCalculusPage5()
    {
        int i = 0;
        int currentLevel = 0;
        for (i = 0; i < 24; i++)
        {

            currentLevel = i + 1;
            if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected") { totalStarsPage5++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected") { totalStarsPage5++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected") { totalStarsPage5++; }

        }
    }

    void starCalculusPage6()
    {
        int i = 0;
        int currentLevel = 0;
        for (i = 0; i < 32; i++)
        {

            currentLevel = i + 1;
            if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected") { totalStarsPage6++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected") { totalStarsPage6++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected") { totalStarsPage6++; }

        }
    }

    void starCalculusPage7()
    {
        int i = 0;
        int currentLevel = 0;
        for (i = 0; i < 36; i++)
        {

            currentLevel = i + 1;
            if (PlayerPrefs.GetString("level" + currentLevel + "sf1") == "collected") { totalStarsPage7++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf2") == "collected") { totalStarsPage7++; }
            if (PlayerPrefs.GetString("level" + currentLevel + "sf3") == "collected") { totalStarsPage7++; }

        }
    }

}
