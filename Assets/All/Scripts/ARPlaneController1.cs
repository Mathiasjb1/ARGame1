using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARPlaneController1 : MonoBehaviour
{
    [SerializeField]
    private ARPlaneManager planeManager;

    public void TogglePlanevisability()
    {
       foreach (ARPlane plane in planeManager.trackables)
       {
            plane.enabled = !plane.enabled;
       }
    }

    public void StopPlaneTracking()
    {
        if (planeManager.enabled)
            planeManager.enabled = false;
        {

        }
        foreach (ARPlane plane in planeManager.trackables)
        {
            plane.enabled = false;
        }
    }

    public void RésumePlaneTracking()
    {
        if (planeManager.enabled)
            planeManager.enabled = false;
    }
}
