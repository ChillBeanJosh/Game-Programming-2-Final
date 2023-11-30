using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    public float enemyTimer;

    void Update()
    {
        enemyTimer += Time.deltaTime;

        if ( enemyTimer >= 5f)
        {
            enemyTimer = 0f;
            Instantiate(enemy, new Vector3(-3, -2, -33), Quaternion.identity);
            Instantiate(enemy, new Vector3(33, -2, 3), Quaternion.identity);
            Instantiate(enemy, new Vector3(-5, -2, 31), Quaternion.identity);
            Instantiate(enemy, new Vector3(-46, -2, -1), Quaternion.identity);
            Instantiate(enemy, new Vector3(-36, -2, -24), Quaternion.identity);
            Instantiate(enemy, new Vector3(-3, -2, -33), Quaternion.identity);
            Instantiate(enemy, new Vector3(17, -2, 24), Quaternion.identity);
            Instantiate(enemy, new Vector3(18, -2, -22), Quaternion.identity);
            Instantiate(enemy, new Vector3(-34, -2, -22), Quaternion.identity);








        }


    }




}
