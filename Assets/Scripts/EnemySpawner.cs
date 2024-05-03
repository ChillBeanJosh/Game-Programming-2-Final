using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int xPos;
    public int zPos;
    public int enemyCount = 0;
    public int enemyLimit = 10;
    public float spawnTime = 3;

 

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    void Update()
    {
        if (enemyCount == enemyLimit)
        {
            enemyCount = 0;
            spawnTime -= 0.5f;
            StartCoroutine(EnemyDrop());

            if(spawnTime <= 0.5f)
            {
                spawnTime = 1.5f;
            }
        }   
     
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < enemyLimit)
        {
            xPos = Random.Range(-50, 40);
            zPos = Random.Range(-40, 50);
            Instantiate(enemy, new Vector3(xPos, 15, zPos), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            enemyCount += 1;
        }

        

    }




}
