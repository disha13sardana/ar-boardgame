using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

//var originalWidth = 640.0;  // define here the original resolution
//var originalHeight = 400.0; // you used to create the GUI contents 
//private var scale = Vector3;

public class SceneLoader_Indoors : MonoBehaviour
{
    public AudioSource MyAudioSource;
    //scale.x = Screen.width / originalWidth; // calculate hor scale
    //scale.y = Screen.height / originalHeight; // calculate vert scale
    //scale.z = 1;
    //var svMat = GUI.matrix; // save current matrix
    //                        // substitute matrix  - only scale is altered from standard
    //GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);
    //    //// draw your GUI controls here:
    //    //GUI.Box(Rect(10, 10, 200, 50), "Box");
    //    //GUI.Button(Rect(400, 180, 230, 50), "Button");
    //    ////...
    private GameObject artifact_cookie;
    private GameObject artifact_steth;
    private GameObject artifact_flag;
    private GameObject artifact_agb;

    void OnGUI()
    {
        artifact_cookie = GameObject.Find("EditorPreview_cookie");
        artifact_steth = GameObject.Find("EditorPreview_steth");
        artifact_flag = GameObject.Find("EditorPreview_flag");
        artifact_agb = GameObject.Find("agb");

        // Calculate change aspects
        float resX = (float)(Screen.width) / 640;
        float resY = (float)(Screen.height) / 400;
        //Set matrix
        GUI.matrix = Matrix4x4.TRS(new Vector3(0, 0, 0), Quaternion.identity, new Vector3(resX, resY, 1));

        if (GUI.Button(new Rect(20, 20, 120, 30), "Back"))
        {
            Destroy(MyAudioSource);
            Application.LoadLevel("OutdoorsScene");

        }


        if (GUI.Button(new Rect(500, 20, 120, 30), "Exit"))
        {
            Destroy(MyAudioSource);
            Application.LoadLevel("InitScene");

        }

        GUI.Box(new Rect(0, 350, 660, 30), "Indoors View");


        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (Input.GetTouch(0).position.y >= 400)
            {//Fetch the AudioSource from the GameObject
                MyAudioSource = GetComponent<AudioSource>();

                // todo: add spatial audio to object.
                //audiosource audiosource = datapoint.addcomponent<audiosource>();
                //MyAudioSource = EditorPreview_cookie vu.AddComponent<AudioSource>();
                MyAudioSource.clip = Resources.Load("tada1") as AudioClip;
                //Play the audio you attach to the AudioSource component

                MyAudioSource.Play();

                DestroyObject(artifact_cookie);
                DestroyObject(artifact_steth);
                DestroyObject(artifact_flag);
                DestroyObject(artifact_agb);

            }

            TouchPhase touchPhase = TouchPhase.Ended;
        }
        
      



        //if (GUI.Button(new Rect(220, 50, 200, 30), "3. Indoors"))
        //{
        //    Application.LoadLevel("IndoorsScene");
        //}

        //if (GUI.Button(new Rect(220, 20, 200, 30), "Collect Artifact"))
        //{
        //    //Fetch the AudioSource from the GameObject
        //    MyAudioSource = GetComponent<AudioSource>();

        //    // todo: add spatial audio to object.
        //    //audiosource audiosource = datapoint.addcomponent<audiosource>();
        //    //MyAudioSource = EditorPreview_cookie vu.AddComponent<AudioSource>();
        //    MyAudioSource.clip = Resources.Load("tada1") as AudioClip;
        //    //Play the audio you attach to the AudioSource component
           
        //    MyAudioSource.Play();

        //    DestroyObject(artifact);

        //}


        //if (GUI.Button(new Rect(20, 50, 200, 30), "1. Birdeye View"))
        //{
        //    Application.LoadLevel("BirdEyeScene");
        //}

        //if (GUI.Button(new Rect(220, 50, 200, 30), "2. Outdoors"))
        //{
        //    Application.LoadLevel("OutdoorsScene");
        //}

        //if (GUI.Button(new Rect(420, 50, 200, 30), "Home"))
        //{
        //    Application.LoadLevel("InitScene");
        //}

        //GUI.Box(new Rect(50, 200, 300, 30), "Current scene: " + Application.loadedLevelName);

        // restore matrix before returning
        //GUI.matrix = svMat; // restore matrix
    }
}
