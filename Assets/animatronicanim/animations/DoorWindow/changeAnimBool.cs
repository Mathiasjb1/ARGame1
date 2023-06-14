using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeAnimBool : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator animatorController1;

    public void changeThisBool()
    {
        animatorController1.SetBool("ButtonPressed?", true);
        animatorController1.SetTrigger("Close");
        //Invoke("resetAnimBool", 2);

    }

    public void changeThisBoolFalse()
    {
        animatorController1.SetBool("ButtonPressed?", false);
    }

    public void resetAnimBool()
    {
        animatorController1.SetBool("ButtonPressed?", false);
        //animatorController1.SetTrigger("Close");
    }
}
