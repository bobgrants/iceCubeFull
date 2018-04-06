using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icePlatformSlowMelt : MonoBehaviour {


    GameObject icecube;

    // Use this for initialization
    void Start()
    {
        icecube = GameObject.Find("icecube");
        Debug.Log(icecube);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == icecube.name)
        {
            icecube.GetComponent<meltDown>().inIcePlatform = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == icecube.name)
        {
            icecube.GetComponent<meltDown>().inIcePlatform = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == icecube.name)
        {
            icecube.GetComponent<meltDown>().inIcePlatform = false;
        }
    }
}
