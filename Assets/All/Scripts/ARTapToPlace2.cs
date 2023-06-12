using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class ARTapToPlace2 : MonoBehaviour
{
    [SerializeField]
    private GameObject refToPrefab;

    [SerializeField]
    private ARRaycastManager raycastManager;

    private static List<ARRaycastHit> hitResult;

    private GameObject spawnedObject;

    private List<GameObject> _listOfObjects;

    private bool hasBeenCreated;
  
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

            if(spawnedObject == null && hasBeenCreated == false)
            {
                spawnedObject = Instantiate(refToPrefab, hitPose.position, hitPose.rotation);
                hasBeenCreated = true;
            }

            
            

            //_listOfObjects.Add(go);

        }
    }

    public void CreateObject()
    {
        hasBeenCreated = false;
        Destroy(spawnedObject);
        spawnedObject = null;
    }
}
