using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class ARTapToPlace : MonoBehaviour
{
    [SerializeField]
    private GameObject refToPrefab;

    [SerializeField]
    private ARRaycastManager raycastManager;

    private static List<ARRaycastHit> hitResult;

    private GameObject spawnedObject;
  
    bool TryGetTouchPosition(out Vector2 touchpos)
    {
        if (Input.touchCount > 0)
        {
            touchpos = Input.GetTouch(0).position;

                return true;
        }

        touchpos = default;

        return false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchPos))
        {
            return;
        }

        if (raycastManager.Raycast(touchPos, hitResult, TrackableType.Planes))
        {
            Pose hitPose = hitResult[0].pose;

            if(spawnedObject == null)
            spawnedObject = Instantiate(refToPrefab, hitPose.position, hitPose.rotation);
            else
            {
                spawnedObject.transform.position = hitPose.position;
                spawnedObject.transform.rotation = hitPose.rotation;
            }
        }


    }
}
