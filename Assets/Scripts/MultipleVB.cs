using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class MultipleVB : MonoBehaviour
{
    public GameObject firstVB, secondVB;
    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterOnButtonPressed(OnButtonPressed);
            vrb[i].RegisterOnButtonReleased(OnButtonReleased);
        }
        firstVB.SetActive(false);
        secondVB.SetActive(false);
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "Steering")
        {
            UnityEngine.Debug.Log("Developer Button pressed");
            firstVB.SetActive(true);
            secondVB.SetActive(false);
           
        }
        else if (vb.VirtualButtonName == "Wheel")
        {
            UnityEngine.Debug.Log("Trainer Button pressed");
            firstVB.SetActive(false);
            secondVB.SetActive(true);
           
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not supported");
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        UnityEngine.Debug.Log(vb.VirtualButtonName + " released");
    }
}