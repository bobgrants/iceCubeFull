using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{

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
        
        //GameObject.Find("Music").GetComponent<musicScript>().fadeVolume = true;
        GameObject.Find("transition screen background").GetComponent<Renderer>().material.color = Color.black;
        GameObject.Find("Canvas").GetComponent<CanvasGroup>().alpha = 0.0f;
        GameObject.Find("Directional light").GetComponent<Light>().intensity = 0.0f;

        SceneManager.LoadScene("volumeDownScene");  

    }

}
