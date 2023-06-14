using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doAtStart1 : MonoBehaviour
{

    [SerializeField] private Renderer Entity1;
    [SerializeField] private Renderer Entity2;
    [SerializeField] private Renderer Entity3;

    [SerializeField] private Material changeMaterial;
    [SerializeField] private Material changeMaterial2;

    public choseEnityScript choseEnityScriptHere;
    

    private void Start()
    {
        if(choseEnityScript.entityChoice == 1)
        {
            Entity1.material = changeMaterial;
            Entity2.material = changeMaterial;
            Entity3.material = changeMaterial;
        }
        else
        {
            Entity1.material = changeMaterial2;
            Entity2.material = changeMaterial2;
            Entity3.material = changeMaterial2;
        }
    }

    public void loseIntChange()
    {
        int winOrLoseInt = 0; // The int value you want to save
        PlayerPrefs.SetInt("winOrLoseInt", winOrLoseInt);
        PlayerPrefs.Save();
    }

    public void winIntChange()
    {
        int winOrLoseInt = 0; // The int value you want to save
        PlayerPrefs.SetInt("winOrLoseInt", winOrLoseInt);
        PlayerPrefs.Save();
    }


}
