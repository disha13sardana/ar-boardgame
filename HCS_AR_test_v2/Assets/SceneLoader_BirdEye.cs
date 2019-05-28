using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

//var originalWidth = 640.0;  // define here the original resolution
//var originalHeight = 400.0; // you used to create the GUI contents 
//private var scale = Vector3;

public class SceneLoader_BirdEye : MonoBehaviour
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

        //if (Input.touchCount == 1 && Input.GetTouch(0).position.y >= 200 && Input.GetTouch(0).phase == TouchPhase.Began)
        //{
        //    Application.LoadLevel("OutdoorsScene");
        //    TouchPhase touchPhase = TouchPhase.Ended;
        //}

        if (GUI.Button(new Rect(20, 20, 120, 30), "Back"))
        {
            Application.LoadLevel("InitScene");
        }

        //if (GUI.Button(new Rect(220, 50, 200, 30), "3. Indoors"))
        //{
        //    Application.LoadLevel("IndoorsScene");
        //}

        //if (GUI.Button(new Rect(220, 180, 250, 40), D2_birdeye))
        //{
        //    Application.LoadLevel("OtdoorsScene");
        //}

        if (GUI.Button(new Rect(500, 20, 120, 30), "Next"))
        {
            Application.LoadLevel("OutdoorsScene");
        }

        GUI.Box(new Rect(0, 350, 660, 30), "Birdeye View");

        // restore matrix before returning
        //GUI.matrix = svMat; // restore matrix
    }
}
