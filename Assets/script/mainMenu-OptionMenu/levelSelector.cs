using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelSelector : MonoBehaviour {

    Button[] BtnAr;

	// Use this for initialization
	void Start () {
        BtnAr = GetComponent<levelSelectEnsemble>().btnAr;
        //Debug.Log(BtnAr[0]);
        int i = 0;

        for (i = 0; i < 37; i++)
        {
           // BtnAr[i].GetComponent<Button>().onClick.AddListener(() => ButtonClicked(i));
            int n = i;
            BtnAr[i].GetComponent<Button>().onClick.AddListener(() => { ButtonClicked(n); });
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ButtonClicked(int i)
    {
        int lvlNumbr = i + 1;
        Debug.Log("Load level " + lvlNumbr);
        SceneManager.LoadScene("level"+ lvlNumbr);

    }
}
