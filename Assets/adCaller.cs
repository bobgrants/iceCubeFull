using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;



public class adCaller : MonoBehaviour {

    InterstitialAd interstitial;


    // Use this for initialization
    void Start () {
        RequestInterstitial();
    }
	
	// Update is called once per frame
	void Update () {
    }

    private void RequestInterstitial()
    {

        string adUnitId = "ca-app-pub-5829870489953278/2062719774";

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);



        // Create an empty ad request.
        AdRequest.Builder request = new AdRequest.Builder();

        request.AddTestDevice("520F5961E840FD9D");
        request.AddTestDevice("BDFA6A1A1B88723");

        AdRequest requestBuilt= request.Build();

        // Load the interstitial with the request.
        interstitial.LoadAd(requestBuilt);

    }

    public void playAd()
    {
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }

    }


}
