using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneToDoors : MonoBehaviour
{
    public void ChangeToDoors2(string Doors2)
    {
        SceneManager.LoadScene(Doors2);
    }
}