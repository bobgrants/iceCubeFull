using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class privacyPolicyBtnScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(loadPage);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loadPage()
    {
        SceneManager.LoadScene("PrivacyPolicyScene");
    }
}
