using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject cubePrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           Vector3 randomSpawnPosition = new Vector3 (Random.Range(-5,20),8,Random.Range(-5,20));
           Instantiate(cubePrefab,randomSpawnPosition,Quaternion.identity);
        }
        
    }
}
