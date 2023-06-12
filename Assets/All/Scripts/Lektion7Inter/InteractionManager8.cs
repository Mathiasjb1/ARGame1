using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.InputSystem;

using UnityEngine.InputSystem.EnhancedTouch;

using newInputTouch = UnityEngine.InputSystem.EnhancedTouch;

using AugmentedRealityCourse;

public class InteractionManager8 : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToPlace;

    [SerializeField]
    private GameObject spawnedObject;

    [SerializeField]
    private ARRaycastManager ARRaycastManager;

    [SerializeField] private GameObject playSoundOnHit;

    [SerializeField]
    private static List<ARRaycastHit> hitResult = new List<ARRaycastHit> ();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
    }

    private void OnEnable()
    {
        newInputTouch.Touch.onFingerDown += Touch_onFingerDown;
    }

    private void Touch_onFingerDown(Finger obj)
    {
        /// gör interaktion här! Wow
        //DebugManager.Instance.AddDebugMessage(obj.screenPosition.ToString());

        Vector3 screenPos = new Vector3(obj.screenPosition.x, obj.screenPosition.y, Camera.main.nearClipPlane);

        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        RaycastHit hit;

        if ((Physics.Raycast(ray, out hit) && hit.collider.gameObject == spawnedObject)) 
        {
            // Om äppen når ända hit, har en interaktion skett med ett 3d object i scenen.
            DebugManager.Instance.AddDebugMessage("Du hittade Objektet men fortfarande inga bitches");
            playSoundOnHit.SetActive(true);

        }
    }


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

        if (ARRaycastManager.Raycast(touchPos, hitResult, TrackableType.Planes))
        {
            Pose pose = hitResult[0].pose;

            if (spawnedObject == null)
            {
                // spawnedObject = Instantiate(objectToPlace, pose.position, pose.rotation);

                DebugManager.Instance.AddDebugMessage("Placed Le Object");
                spawnedObject = objectToPlace;
                spawnedObject.SetActive(true);
                spawnedObject.transform.position = pose.position;
                spawnedObject.transform.position = pose.position;
            }
            else
            {
                //spawnedObject.transform.position = pose.position;
                //spawnedObject.transform.position = pose.position;
            }
        }
    }
}
