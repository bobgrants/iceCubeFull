using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class meltDown : MonoBehaviour {

    public float targetScale;
    public bool shrinking;
    public bool fallStop;

    

    GameObject iceCube;

    float repeatRate;

    public bool inSand;
    public bool inIcePlatform;

    // Use this for initialization
    void Start()
    {
        repeatRate = 0.03f;
        targetScale = 0.0001f;
        iceCube = this.gameObject;
        shrinking = false;
        fallStop = false;
        InvokeRepeating("shrinkCube", 0.0f, repeatRate);

        inSand = false;
        inIcePlatform = false;

    }

    void Update()
    {
        
    }

    void shrinkCube() {
        //Debug.Log("repeatRate " + repeatRate);

        if (shrinking == true && fallStop == false)
        {
            sandAndPlatform();

            //iceCube.transform.localScale -=  new Vector3(0.001f, 0.001f, 0); //* Time.deltaTime; // 
            if (iceCube.transform.localScale.x < targetScale)
            { 
                shrinking = false;
            Debug.Log("MELTED !");
            }
        }

        if (shrinking == false && iceCube.transform.localScale.x < targetScale)
        {
            Debug.Log("Chrono: " + GameObject.Find("chrono").GetComponent<Text>().text);
            SceneManager.LoadScene("gameOver");
        }
        gameObject.GetComponent<TrailRenderer>().widthMultiplier = gameObject.transform.localScale.x - 0.002f;
    }

    public void isFalling()
    {
        //fallStop = true;
        repeatRate = 0.001f;
    }

    public void sandAndPlatform()
    {
        
        if (inSand == true && inIcePlatform == false)
        {
            iceCube.transform.localScale -= new Vector3(0.08f, 0.08f, 0) * Time.deltaTime;
            //Debug.Log("Sand Melting !");
        }
        else if (inSand == true && inIcePlatform == true)
        {
            if (iceCube.transform.localScale.x < 1.0f)
                {
                iceCube.transform.localScale += new Vector3(0.05f, 0.05f, 0) * Time.deltaTime; // 
                //Debug.Log("Platform slow melt !");
                }
        }
        else if (inSand == false && inIcePlatform == false)
        {
            iceCube.transform.localScale -= new Vector3(0.001f, 0.001f, 0); //* Time.deltaTime; // 
            //Debug.Log("Normal melt !");
        }
    }
}
