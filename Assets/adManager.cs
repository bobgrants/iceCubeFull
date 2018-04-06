using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GoogleMobileAds.Api;


public class adManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string appId = "ca-app-pub-5829870489953278~6374751145";

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
