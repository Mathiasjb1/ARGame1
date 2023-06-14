using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWInOrLose : MonoBehaviour
{
    [SerializeField] private GameObject jumpScare;
    [SerializeField] private GameObject showMenu;
    [SerializeField] private GameObject winSound;



    int retrievedValue = PlayerPrefs.GetInt("winOrLoseInt");

    private void Start()
    {
        if (retrievedValue == 0)
        {
            jumpScare.SetActive(false);
            showMenu.SetActive(true);
            winSound.SetActive(true);
        }
    }
}
