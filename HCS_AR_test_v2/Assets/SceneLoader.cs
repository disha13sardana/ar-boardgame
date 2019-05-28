using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

//var originalWidth = 640.0;  // define here the original resolution
//var originalHeight = 400.0; // you used to create the GUI contents 
//private var scale = Vector3;

public class SceneLoader : MonoBehaviour
{
    
    //scale.x = Screen.width / originalWidth; // calculate hor scale
    //scale.y = Screen.height / originalHeight; // calculate vert scale
    //scale.z = 1;
    //var svMat = GUI.matrix; // save current matrix
    //                        // substitute matrix - only scale is altered from standard
    //GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);
    //    //// draw your GUI controls here:
    //    //GUI.Box(Rect(10, 10, 200, 50), "Box");
    //    //GUI.Button(Rect(400, 180, 230, 50), "Button");
    //    ////...
      
    void OnGUI()
    {
        // Calculate change aspects
        float resX = (float)(Screen.width) / 640;
        float resY = (float)(Screen.height) / 400;
        //Set matrix
        GUI.matrix = Matrix4x4.TRS(new Vector3(0, 0, 0), Quaternion.identity, new Vector3(resX, resY, 1));

        if (GUI.Button(new Rect(220, 180, 250, 40), "Start Scanning"))
        {
            Application.LoadLevel("BirdEyeScene");
        }

        GUI.Box(new Rect(20, 100, 600, 200), "Place your tile in this box");
        //if (GUI.Button(new Rect(220, 100, 200, 30), "1. Birdeye View"))
        //{
        //    Application.LoadLevel("BirdEyeScene");
        //}

        //if (GUI.Button(new Rect(220, 130, 200, 30), "2. Outdoors"))
        //{
        //    Application.LoadLevel("OutdoorsScene");
        //}

        //if (GUI.Button(new Rect(220, 160, 200, 30), "3. Indoors"))
        //{
        //    Application.LoadLevel("IndoorsScene");
        //}

        //GUI.Box(new Rect(50, 200, 300, 30), "Current scene: " + Application.loadedLevelName);

        // restore matrix before returning
        //GUI.matrix = svMat; // restore matrix
    }
}