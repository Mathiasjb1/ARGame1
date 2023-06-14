using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapEntity1 : MonoBehaviour
{
    // Start is called before the first frame update 
    [Header("Entity1 Animator")]
    [SerializeField] private Animator animatorController1;
    [Header("Entity2 Animator")]
    [SerializeField] private Animator animatorController2;
    public void changeThisBool()
    {
        animatorController1.SetBool("AnimOn?", true);
        animatorController2.SetBool("AnimOn?", false);

    }
}
