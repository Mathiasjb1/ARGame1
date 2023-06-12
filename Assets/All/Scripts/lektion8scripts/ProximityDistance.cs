using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AugmentedRealityCourse;

public class ProximityDistance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    [SerializeField]
    private GameObject arCamera;

    [SerializeField]
    private GameObject targetObject;

    [SerializeField]
    private float interactionDistance;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(
            arCamera.transform.position,
            targetObject.transform.position);

        if (distance < interactionDistance)
        {
            DebugManager.Instance.AddDebugMessage("Träff!!!");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(arCamera.transform.position, targetObject.transform.position);
    }
}
