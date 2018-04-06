using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seaWaveDetectorOutScript : MonoBehaviour
{

    public GameObject seaWave;

    // Use this for initialization
    void Start()
    {
        //Debug.Log(seaWave);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.name == seaWave.name)
        {
            //seaWave.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            seaWave.GetComponent<seaWaveScript>().direction = "in";
        }
    }
    void OnTriggerStay2D(Collider2D c)
    {
        if (c.gameObject.name == seaWave.name)
        {
            //seaWave.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            seaWave.GetComponent<seaWaveScript>().direction = "in";
        }
    }
}
