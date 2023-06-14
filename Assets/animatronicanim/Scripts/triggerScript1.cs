using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerScript1 : MonoBehaviour
{
    public bool isDoorDown = false;
    [SerializeField] public AudioSource animatronicThud;
    [SerializeField] public AudioSource lightBulbGone;
    [SerializeField] private GameObject blackScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int nextSceneIndex;

            lightBulbGone.Play();
            blackScreen.SetActive(true);
            nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

            if (isDoorDown == false)
            {
                lightBulbGone.Play();
                blackScreen.SetActive(true);
                nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            }
            else
            {
                nextSceneIndex = SceneManager.GetActiveScene().buildIndex;
                animatronicThud.Play();
            }

            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
