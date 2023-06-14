using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChangeScript : MonoBehaviour
{
    [SerializeField] public float transitionTime = 1f;

    [SerializeField] public Animator transition;

    [SerializeField] private GameObject showTextAfter;
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        Invoke("activateText", 3);
    }

    IEnumerator LoadLevel(int LevelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(LevelIndex);
    }

    public void activateText()
    {
        showTextAfter.SetActive(true );
    }

    public void quitTheGame()
    {
       Application.Quit();
    }
}
