using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logoSize : MonoBehaviour
{

    public static logoSize current;
    Renderer rend;

    float screenHeight;
    float screenWidth;
    
    // Use this for initialization
    void Start()
    {
        

        current = this;

        rend = GetComponent<Renderer>();

        //Adapting background quad to screen size
        screenHeight = Camera.main.orthographicSize * 2.0f;
        
        
        screenWidth = screenHeight * Screen.width / Screen.height;
        transform.localScale = new Vector3(screenWidth, screenHeight, 1);

        Debug.Log("Screen Height: " + screenHeight);
        Debug.Log("Screen Height2: " + Screen.height);

        Debug.Log("Screen Width: " + screenWidth);
        Debug.Log("Screen Width2: " + Screen.width);

        Debug.Log("Local Scale: " + transform.localScale);



        //Set texture to wrap when pushed down
        //Should be working only via editor but seems to not work sometimes

        rend.material.mainTexture.wrapMode = TextureWrapMode.Repeat;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void resetImages()
    {


    }
}
