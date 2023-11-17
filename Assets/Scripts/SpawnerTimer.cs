using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTimer : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2.0f; // Adjust this to change spawn interval
    private float timer = 0.0f;
    public int maxEnemies = 5;
    //public float range = 8;
     private List<GameObject> spawnedEnemies = new List<GameObject>();
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // Increment the timer based on real time

        if (timer >= spawnInterval && spawnedEnemies.Count < maxEnemies)
        {
            SpawnEnemy(); // Spawn enemy when the timer reaches the interval
            timer = 0.0f; // Reset the timer
        }
    }
    void SpawnEnemy()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(5, 50), 2, Random.Range(-5, 30)); // Adjust Y position if needed
        //Instantiate(enemyPrefab, randomSpawnPosition, Quaternion.identity);
        GameObject newEnemy = Instantiate(enemyPrefab, randomSpawnPosition, Quaternion.identity);
        spawnedEnemies.Add(newEnemy);
        newEnemy.GetComponent<Target>().OnEnemyDestroyed += HandleEnemyDestroyed;
    }
    void HandleEnemyDestroyed(GameObject destroyedEnemy)
{
    if (destroyedEnemy != null && spawnedEnemies.Contains(destroyedEnemy))
    {
        destroyedEnemy.GetComponent<Target>().OnEnemyDestroyed -= HandleEnemyDestroyed;
        spawnedEnemies.Remove(destroyedEnemy); // Remove destroyed enemy from the list

        // Additional check to ensure no further action is taken if the object is destroyed
        if (destroyedEnemy.activeSelf == false)
        {
            return;
        }
    }
}

}
