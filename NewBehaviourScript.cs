using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty
{
    Easy = 1,
    Normal = 2,
    Hard = 4;
}

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] public Difficulty difficulty;

    [SerializeField] private Rigidbody enemyPrefab;  
    
    void Start()
    {
        StartCoroutine(enemySpawn());
    }
    IEnumerator enemySpawn() 
    {
        if (difficulty == Difficulty.Easy)
        {
            print("Set Game Difficulty to Easy");
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
        else if (difficulty == Difficulty.Normal)
        {
            print("Set Game Difficulty to Normal");
            for (int i = 1; i >= 0; i--)
            {
                Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                yield return new WaitForSeconds(1);
            }
        }
        else if (difficulty == Difficulty.Hard)
        {
            print("Set Game Difficulty to Hard");
            for (int i = 2; i >= 0; i--)
            {
                Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                yield return new WaitForSeconds(1);
            }

        }
    }
}
