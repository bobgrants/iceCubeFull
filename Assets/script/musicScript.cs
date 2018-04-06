using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;
//using UnityEditor;
using UnityEngine.SceneManagement;

public class musicScript : MonoBehaviour
{

    AudioSource aSource;
    AudioClip music1;
    AudioClip music2;
    AudioClip music3;
    string levelName;

    float randomFactor;

    float startVolume;

    public bool fadeVolume;

    public bool volumeOff;

    // Use this for initialization
    void Awake()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        volumeOff = false;
        DontDestroyOnLoad(gameObject);
        aSource = GetComponent<AudioSource>();

        levelName = SceneManager.GetActiveScene().name;

        randomFactor = 0.00f;

        startVolume = aSource.volume;

        chooseMusic(levelName);

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void chooseMusic(string levelName)
    {
        aSource.volume = startVolume;

        if (volumeOff == false)
        {

            switch (levelName)
            {

                case "mainMenu":
                    music1 = Resources.Load<AudioClip>("Movement 1");

                    aSource.clip = music1;
                    aSource.Stop(); aSource.Play(); aSource.loop = true;
                    //Debug.Log("Playing: " + aSource.clip);
                    break;

                case "level1":
                    aSource.Stop();
                    music1 = Resources.Load<AudioClip>("Movement 4");
                    music2 = Resources.Load<AudioClip>("Movement 5");
                    music3 = Resources.Load<AudioClip>("Movement 7 variant");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Stop(); aSource.Play(); aSource.loop = true;
                        Debug.Log("Playing: " + aSource.clip);
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Stop(); aSource.Play(); aSource.loop = true;
                        Debug.Log("Playing: " + aSource.clip);
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Stop(); aSource.Play(); aSource.loop = true;
                        Debug.Log("Playing: " + aSource.clip);
                    }
                    break;

                case "level2":
                    music1 = Resources.Load<AudioClip>("Movement 3 variant");
                    music2 = Resources.Load<AudioClip>("Movement 6");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 50)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }

                    break;
                case "level3":
                    music1 = Resources.Load<AudioClip>("Movement 8 variant");
                    music2 = Resources.Load<AudioClip>("Movement 9");
                    music3 = Resources.Load<AudioClip>("Movement 18");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level4":
                    music1 = Resources.Load<AudioClip>("Movement 11");
                    music2 = Resources.Load<AudioClip>("Movement 16 variant");
                    music3 = Resources.Load<AudioClip>("Movement 17 variant");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level5":
                    music1 = Resources.Load<AudioClip>("Movement 12");
                    music2 = Resources.Load<AudioClip>("Movement 13");
                    music3 = Resources.Load<AudioClip>("Movement 14 variant");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level6":
                    music1 = Resources.Load<AudioClip>("Movement 14");
                    music2 = Resources.Load<AudioClip>("Movement 15");
                    music3 = Resources.Load<AudioClip>("Movement 16");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level7":
                    music1 = Resources.Load<AudioClip>("Movement 18 variant 2");
                    music2 = Resources.Load<AudioClip>("Movement 19 variant");
                    music3 = Resources.Load<AudioClip>("Movement 25 variant");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(music1);
                    Debug.Log(music2);
                    Debug.Log(music3);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level8":
                    music1 = Resources.Load<AudioClip>("Movement 5 variant");
                    music2 = Resources.Load<AudioClip>("Movement 7");
                    music3 = Resources.Load<AudioClip>("Movement 9 variant");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;

                case "level9":
                    music1 = Resources.Load<AudioClip>("Movement 20 variant");
                    music2 = Resources.Load<AudioClip>("Movement 21");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 50)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;

                case "level10":
                    music1 = Resources.Load<AudioClip>("Movement 2");
                    music2 = Resources.Load<AudioClip>("Movement 3");
                    music3 = Resources.Load<AudioClip>("Movement 6 variant");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level11":
                    music1 = Resources.Load<AudioClip>("Movement 4");
                    music2 = Resources.Load<AudioClip>("Movement 15 variant");
                    music3 = Resources.Load<AudioClip>("Movement 17 variant");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level12":
                    music1 = Resources.Load<AudioClip>("Movement 8");
                    music2 = Resources.Load<AudioClip>("Movement 20 variant 3");
                    music3 = Resources.Load<AudioClip>("Movement 25");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level13":
                    music1 = Resources.Load<AudioClip>("Movement 6");
                    music2 = Resources.Load<AudioClip>("Movement 12 variant");
                    music3 = Resources.Load<AudioClip>("Movement 17 variant 2");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level14":
                    music1 = Resources.Load<AudioClip>("Movement 19");
                    music2 = Resources.Load<AudioClip>("Movement 21 variant");
                    music3 = Resources.Load<AudioClip>("Movement 26");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level15":
                    music1 = Resources.Load<AudioClip>("Movement 20");
                    music2 = Resources.Load<AudioClip>("Movement 24");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 50)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;

                case "level16":
                    music1 = Resources.Load<AudioClip>("Movement 7 variant");
                    music2 = Resources.Load<AudioClip>("Movement 18");
                    music3 = Resources.Load<AudioClip>("Movement 20 variant 2");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level17":
                    music1 = Resources.Load<AudioClip>("Movement 10");
                    music2 = Resources.Load<AudioClip>("Movement 22");
                    music3 = Resources.Load<AudioClip>("Movement 23");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level18":
                    music1 = Resources.Load<AudioClip>("Movement 17");
                    music2 = Resources.Load<AudioClip>("Movement 18 variant");
                    music3 = Resources.Load<AudioClip>("Movement 18 variant 3");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level19":
                    music1 = Resources.Load<AudioClip>("Movement 2 variant");
                    music2 = Resources.Load<AudioClip>("Movement 5");
                    music3 = Resources.Load<AudioClip>("Movement 8 variant");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level20":
                    music1 = Resources.Load<AudioClip>("Movement 9");
                    music2 = Resources.Load<AudioClip>("Movement 16 variant");
                    music3 = Resources.Load<AudioClip>("Movement 19 variant");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level21":
                    music1 = Resources.Load<AudioClip>("Movement 3 variant");
                    music2 = Resources.Load<AudioClip>("Movement 14 variant");
                    music3 = Resources.Load<AudioClip>("Movement 13");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level22":
                    music1 = Resources.Load<AudioClip>("Movement 11");
                    music2 = Resources.Load<AudioClip>("Movement 14");
                    music3 = Resources.Load<AudioClip>("Movement 20 variant");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level23":
                    music1 = Resources.Load<AudioClip>("Movement 2");
                    music2 = Resources.Load<AudioClip>("Movement 5 variant");
                    music3 = Resources.Load<AudioClip>("Movement 18 variant 2");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level24":
                    music1 = Resources.Load<AudioClip>("Movement 6 variant");
                    music2 = Resources.Load<AudioClip>("Movement 13");
                    music3 = Resources.Load<AudioClip>("Movement 15");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level25":
                    music1 = Resources.Load<AudioClip>("Movement 16");
                    music2 = Resources.Load<AudioClip>("Movement 15");
                    music3 = Resources.Load<AudioClip>("Movement 12");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level26":
                    music1 = Resources.Load<AudioClip>("Movement 10");
                    music2 = Resources.Load<AudioClip>("Movement 22");
                    music3 = Resources.Load<AudioClip>("Movement 23");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level27":
                    music1 = Resources.Load<AudioClip>("Movement 3");
                    music2 = Resources.Load<AudioClip>("Movement 7");
                    music3 = Resources.Load<AudioClip>("Movement 9 variant");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level28":
                    music1 = Resources.Load<AudioClip>("Movement 15 variant");
                    music2 = Resources.Load<AudioClip>("Movement 17 variant");
                    music3 = Resources.Load<AudioClip>("Movement 19");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level29":
                    music1 = Resources.Load<AudioClip>("Movement 20");
                    music2 = Resources.Load<AudioClip>("Movement 21");
                    music3 = Resources.Load<AudioClip>("Movement 25");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level30":
                    music1 = Resources.Load<AudioClip>("Movement 5");
                    music2 = Resources.Load<AudioClip>("Movement 6");
                    music3 = Resources.Load<AudioClip>("Movement 8");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level31":
                    music1 = Resources.Load<AudioClip>("Movement 8 variant");
                    music2 = Resources.Load<AudioClip>("Movement 14 variant");
                    music3 = Resources.Load<AudioClip>("Movement 17");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level32":
                    music1 = Resources.Load<AudioClip>("Movement 7 variant");
                    music2 = Resources.Load<AudioClip>("Movement 16 variant");
                    music3 = Resources.Load<AudioClip>("Movement 17 variant 2");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level33":
                    music1 = Resources.Load<AudioClip>("Movement 18");
                    music2 = Resources.Load<AudioClip>("Movement 20 variant 2");
                    music3 = Resources.Load<AudioClip>("Movement 21 variant");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level34":
                    music1 = Resources.Load<AudioClip>("Movement 24");
                    music2 = Resources.Load<AudioClip>("Movement 25 variant");
                    music3 = Resources.Load<AudioClip>("Movement 26");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level35":
                    music1 = Resources.Load<AudioClip>("Movement 2 variant");
                    music2 = Resources.Load<AudioClip>("Movement 4");
                    music3 = Resources.Load<AudioClip>("Movement 9");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level36":
                    music1 = Resources.Load<AudioClip>("Movement 18 variant");
                    music2 = Resources.Load<AudioClip>("Movement 19 variant");
                    music3 = Resources.Load<AudioClip>("Movement 20 variant 3");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level37":
                    music1 = Resources.Load<AudioClip>("Movement 27");
                    music2 = Resources.Load<AudioClip>("Movement 27");
                    music3 = Resources.Load<AudioClip>("Movement 27");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level38":
                    music1 = Resources.Load<AudioClip>("Movement 3");
                    music2 = Resources.Load<AudioClip>("Movement 3");
                    music3 = Resources.Load<AudioClip>("Movement 3");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level39":
                    music1 = Resources.Load<AudioClip>("Movement 3");
                    music2 = Resources.Load<AudioClip>("Movement 3");
                    music3 = Resources.Load<AudioClip>("Movement 3");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level40":
                    music1 = Resources.Load<AudioClip>("Movement 3");
                    music2 = Resources.Load<AudioClip>("Movement 3");
                    music3 = Resources.Load<AudioClip>("Movement 3");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level41":
                    music1 = Resources.Load<AudioClip>("Movement 3");
                    music2 = Resources.Load<AudioClip>("Movement 3");
                    music3 = Resources.Load<AudioClip>("Movement 3");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level42":
                    music1 = Resources.Load<AudioClip>("Movement 3");
                    music2 = Resources.Load<AudioClip>("Movement 3");
                    music3 = Resources.Load<AudioClip>("Movement 3");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level43":
                    music1 = Resources.Load<AudioClip>("Movement 3");
                    music2 = Resources.Load<AudioClip>("Movement 3");
                    music3 = Resources.Load<AudioClip>("Movement 3");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level44":
                    music1 = Resources.Load<AudioClip>("Movement 3");
                    music2 = Resources.Load<AudioClip>("Movement 3");
                    music3 = Resources.Load<AudioClip>("Movement 3");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level45":
                    music1 = Resources.Load<AudioClip>("Movement 3");
                    music2 = Resources.Load<AudioClip>("Movement 3");
                    music3 = Resources.Load<AudioClip>("Movement 3");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;
                case "level46":
                    music1 = Resources.Load<AudioClip>("Movement 3");
                    music2 = Resources.Load<AudioClip>("Movement 3");
                    music3 = Resources.Load<AudioClip>("Movement 3");
                    randomFactor = UnityEngine.Random.Range(0.01f, 1.00f) * 100;

                    Debug.Log(randomFactor);

                    if (randomFactor <= 33)
                    {
                        aSource.clip = music1;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 66)
                    {
                        aSource.clip = music2;
                        aSource.Play(); aSource.loop = true;
                    }
                    else if (randomFactor <= 100)
                    {
                        aSource.clip = music3;
                        aSource.Play(); aSource.loop = true;
                    }
                    break;

            }
        }
        else if (volumeOff == true)
        {
            aSource.Stop();
            aSource.volume = 0.0f;
        }
        }
    public void turnOffMusic()
    {
        aSource.Stop();
        aSource.volume = 0.0f;
    }
    }


