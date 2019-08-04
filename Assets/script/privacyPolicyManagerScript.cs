using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class privacyPolicyManagerScript : MonoBehaviour
{
    GameObject textGO;
    GameObject BackgroudGO;
    GameObject AcceptBtn;

    GameObject RateUs;
    GameObject Play;

    int PolicyAccepted;

    // Start is called before the first frame update
    void Start()
    {
        PolicyAccepted = PlayerPrefs.GetInt("PrivacyPolicy");

        textGO = transform.Find("Text").gameObject;
        BackgroudGO = transform.Find("Background").gameObject;
        AcceptBtn = transform.Find("AcceptBtn").gameObject;

        RateUs = GameObject.Find("rateAppBtn").gameObject;
        Play = GameObject.Find("start").gameObject;

        if (PolicyAccepted == 0)
        {
            SetbackgroundSizeAndDisable();
        }
        else if (PolicyAccepted == 1)
        {
            HidePrivacyAndEnable();
        }
    }

    // Update is called once per frame
    void Update()
    {
        PolicyAccepted = PlayerPrefs.GetInt("PrivacyPolicy");

        if (PlayerPrefs.GetInt("PrivacyPolicy")== 0)
        {
            SetbackgroundSizeAndDisable();
        }
        else if (PlayerPrefs.GetInt("PrivacyPolicy") == 1)
        {
            HidePrivacyAndEnable();
        }
    }

    void SetbackgroundSizeAndDisable()
    {
        RateUs.GetComponent<Button>().enabled = false;
        Play.GetComponent<Button>().enabled = false;
        BackgroudGO.GetComponent<RectTransform>().sizeDelta = textGO.GetComponent<RectTransform>().sizeDelta;
    }

    void HidePrivacyAndEnable()
    {
        Destroy(AcceptBtn);
        Destroy(textGO);
        Destroy(BackgroudGO);

        RateUs.GetComponent<Button>().enabled = true;
        Play.GetComponent<Button>().enabled = true;


    }
}
