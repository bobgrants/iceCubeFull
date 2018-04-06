using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restartLevel : MonoBehaviour {

    // Use this for initialization
    

    void Start()
    {

        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClick()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("currentScene"));

    }

}
