using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerScript1 : MonoBehaviour
{
    public bool isDoorDown = false;
    public AudioSource animatronicThud;
    public AudioSource lightBulbGone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int nextSceneIndex;

            if (isDoorDown == false)
            {
                lightBulbGone.Play();
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
