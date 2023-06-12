using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;
using AugmentedRealityCourse;

public class CustomLeanTouch : MonoBehaviour
{
    private void OnEnable()
    {
        LeanTouch.OnFingerDown += LeanTouch_OnFingerDown;
    }

    private void OnDisable()
    {
        LeanTouch.OnFingerDown -= LeanTouch_OnFingerDown;
    }

    private void LeanTouch_OnFingerDown(LeanFinger obj)
    {
        DebugManager.Instance.AddDebugMessage(obj.ScreenPosition.ToString("Finger Down Yup!"));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
