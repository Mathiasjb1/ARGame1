using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [Header("GameObject 1")]
    [SerializeField] private GameObject GameObject1;
    [Header("GameObject 2")]
    [SerializeField] private GameObject GameObject2;
    [Header("GameObject 3")]
    [SerializeField] private GameObject GameObject3;

    public void destroyThemObjects()
    {
        Object.Destroy(GameObject1);
        Object.Destroy(GameObject2);
        Object.Destroy(GameObject3);
    }

    public void hideThemObjects()
    {
        GameObject1.SetActive(false);
        GameObject2.SetActive(false);
        GameObject3.SetActive(false);
    }

    public void showThemObjects()
    {
        GameObject1.SetActive(true);
        GameObject2.SetActive(true);
        GameObject3.SetActive(true);
    }
}
