using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AugmentedRealityCourse;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using newInputTouch = UnityEngine.InputSystem.EnhancedTouch;
public class Interactionmanager2 : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToplace;

    private GameObject spawnedObject;

    [SerializeField]
    private ARRaycastManager raycastManager;

    private static List<ARRaycastHit> hitResults = new List<ARRaycastHit>();

    private void Awake()
    {

        EnhancedTouchSupport.Enable();

    }


    private void OnEnable()
    {
        newInputTouch.Touch.onFingerDown += Touch_onFingerDown;

    }

    private void OnDisable()
    {
        newInputTouch.Touch.onFingerDown -= Touch_onFingerDown;
    }

    private void Touch_onFingerDown(Finger obj)
    {

        if (raycastManager.Raycast(obj.screenPosition, hitResults, TrackableType.Planes))

        {

            Pose hitPose = hitResults[0].pose;

            if (spawnedObject == null)
            {
                DebugManager.Instance.AddDebugMessage("La ut bollen");

                spawnedObject = objectToplace;

                spawnedObject.SetActive(true);
                spawnedObject.transform.position = hitPose.position;
                spawnedObject.transform.rotation = hitPose.rotation;

            }
        }
    }
}
