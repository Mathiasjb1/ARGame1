using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawner1 : MonoBehaviour
{
    [SerializeField]
    private GameObject skattKista;

    // Start is called before the first frame update
    void Start()
    {
        int skattKistaCount = 5;

        for (int i = skattKistaCount; i > 0; i--)
        {
            SpawnSkattKistaRandom();
        }
    }

    public void SpawnSkattKistaRandom()
    {
        Vector3 randomSpawnPostition = new Vector3(Random.Range(-10, 11), 1, Random.Range(-10, 11));
    }
}
