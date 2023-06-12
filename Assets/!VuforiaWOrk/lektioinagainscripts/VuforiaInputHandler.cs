using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using Lean.Touch;

public class VuforiaInputHandler : MonoBehaviour
{
    [SerializeField] private PlaneFinderBehaviour planeFinderBehavior;

    [SerializeField] private GameObject placementObject;


    private void OnEnable()
    {
        LeanTouch.OnFingerDown += LeanTouch_OnFingerDown;

        planeFinderBehavior.OnInteractiveHitTest.AddListener((hitTestResult) =>
        {
            placementObject.SetActive(true);

            placementObject.transform.position = hitTestResult.Position;
            placementObject.transform.rotation = hitTestResult.Rotation;

        });
    }

    private void OnDisable()
    {
        LeanTouch.OnFingerDown -= LeanTouch_OnFingerDown;
    }

    private void LeanTouch_OnFingerDown(LeanFinger obj)
    {
        Vector3 sceenPos = new Vector3(obj.ScreenPosition.x, obj.ScreenPosition.y, Camera.main.nearClipPlane);

        planeFinderBehavior.PerformHitTest(sceenPos);
    }
}
