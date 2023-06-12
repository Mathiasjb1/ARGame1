using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choseEnityScript : MonoBehaviour
{
    public static int entityChoice = 0;

    [SerializeField] private int showWhatInt;

    private void Start()
    {
        showWhatInt = entityChoice;
    }

    public void firstEntity()
    {
        entityChoice = 0;
    }

    public void secondEntity()
    {
        entityChoice = 1;
    }
}
