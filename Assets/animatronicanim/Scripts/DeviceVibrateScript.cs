using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceVibrateScript : MonoBehaviour
{
    public void vibrateDevice()
    {
        Handheld.Vibrate();
        
    }
}
