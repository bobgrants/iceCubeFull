using UnityEngine;
using System.Collections;

public class popUpWindowsScript : MonoBehaviour
{
    public Rect windowRect = new Rect(Screen.width / 2, Screen.height / 2, 100, 100);


    void Start()
    {
        GUI.backgroundColor = Color.red;
        GUI.contentColor = Color.black; 
        windowRect = new Rect(Screen.width / 2, Screen.height / 2, 400, 400);
    }

    void OnGUI()
    {
        // Register the window. Notice the 3rd parameter
        windowRect = GUI.Window(0, windowRect, DoMyWindow, "");
    }

    // Make the contents of the window
    void DoMyWindow(int windowID)
    {
        if (GUI.Button(new Rect(10, 20, 100, 20), "Hello World"))
        {
            print("Got a click");
        }
    }
}