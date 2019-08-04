using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AcceptBtnScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(Accept);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Accept()
    {
        PlayerPrefs.SetInt("PrivacyPolicy", 1);
    }
}
