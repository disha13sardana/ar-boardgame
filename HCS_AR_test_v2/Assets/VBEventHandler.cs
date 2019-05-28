using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{

    // Use this for initialization
    void Start()
    {
        VirtualButtonBehaviour vbb = GetComponentInChildren<VirtualButtonBehaviour>();
        if (vbb != null)
        {
            Debug.Log("Registering VB event handler");
            vbb.RegisterEventHandler(this);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button Released");
    }
}