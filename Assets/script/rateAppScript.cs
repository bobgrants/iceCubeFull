using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif


public class rateAppScript : MonoBehaviour {

    int startUpNbr = 0;
#if UNITY_EDITOR
    [MenuItem("Example/ShowPopup Example")]
#endif

    // Use this for initialization
    void Start () {
#if UNITY_EDITOR
        if (PlayerPrefs.GetInt("startUpNbr") != 0)
        {
            startUpNbr = PlayerPrefs.GetInt("startUpNbr");
        }

        startUpNbr++;

        PlayerPrefs.SetInt("startUpNbr", startUpNbr);

        Debug.Log("startUpNbr: " + startUpNbr);
        Debug.Log("startUpNbr PlayerPrefs: " + PlayerPrefs.GetInt("startUpNbr"));


#endif

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void rateAppClick()
    {
        Application.OpenURL("market://details?id=com.Mth.Tsic");
    }

}
