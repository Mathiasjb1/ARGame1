using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class TimerScript : MonoBehaviour
{
    public float totalTime = 60f; // Total time in seconds
    private float timeRemaining;
    public TextMeshProUGUI timerText;
    public bool isTimerFinished = false;

    public void StartTimer()
    {
        timeRemaining = totalTime;
        isTimerFinished = false;
    }

    void Update()
    {
        if (!isTimerFinished)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerText();
            }
            else
            {
                isTimerFinished = true;
                timerText.text = "0:00!";
                StartCoroutine(LoadNextSceneAfterDelay(2f)); // Change scene after a delay of 2 seconds
            }
        }
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60f);
        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = timerString;
    }

    IEnumerator LoadNextSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}