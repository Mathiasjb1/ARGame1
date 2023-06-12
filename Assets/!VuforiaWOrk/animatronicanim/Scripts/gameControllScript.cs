using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControllScript : MonoBehaviour
{
    [Header("Entity1")]
    [SerializeField] private GameObject Entity1;
    [SerializeField] private Animator entityAnimator1;

    [Header("Entity2")]
    [SerializeField] private GameObject Entity2;
    [SerializeField] private Animator entityAnimator2;

    [Header("Entity3")]
    [SerializeField] private GameObject Entity3;
    [SerializeField] private Animator entityAnimator3;

    [SerializeField] private bool canPlayerDie;
    private float waitForAnim1 = 13f;

    private Animator[] entityAnimators;
    private GameObject[] entityGameObjects;
    private int numberOfEntities;

    private bool isRunning;

    // Start is called before the first frame update
    void Start()
    {
        canPlayerDie = true;

        // Start the loop
        isRunning = true;
        StartCoroutine(StartCountingDown());

        // Initialize the entity animators
        entityAnimators = new Animator[] { entityAnimator1, entityAnimator2, entityAnimator3 };
        entityGameObjects = new GameObject[] { Entity1, Entity2, Entity3 };

        // Get the number of entities
        numberOfEntities = entityAnimators.Length;
    }

    IEnumerator StartCountingDown()
    {
        while (isRunning)
        {
            yield return new WaitForSeconds(waitForAnim1);

            // Deactivate all entities
            DeactivateAllEntities();

            // Activate a random entity
            ActivateRandomEntity();
        }
    }
    // maybe change this back!!!!
    public void DeactivateAllEntities()
    {
        for (int i = 0; i < numberOfEntities; i++)
        {
            entityGameObjects[i].SetActive(false);
        }
    }

    void ActivateRandomEntity()
    {
        // Select a random entity index
        int randomNumber = Random.Range(1, 3);

        // Activate the selected entity
        entityGameObjects[randomNumber].SetActive(true);
        entityAnimators[randomNumber].SetTrigger("ResetAnimTrigger");
    }

    // Method to stop the loop
    public void StopLoop()
    {
        isRunning = false;
    }
}