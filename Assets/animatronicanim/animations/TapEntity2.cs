using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapEntity2 : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Entity1 Animator")]
    [SerializeField] private Animator animatorController1;
    [Header("Entity2 Animator")]
    [SerializeField] private Animator animatorController2;

    public void changeThisBool()
    {
        animatorController2.SetBool("AnimOn?", true);
        animatorController1.SetBool("AnimOn?", false);
    }

}
