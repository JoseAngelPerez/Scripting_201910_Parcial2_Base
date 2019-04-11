using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooler : MonoBehaviour
{
    [SerializeField] GameObject[] spawnPoints= new GameObject[3];

    [SerializeField]
    GameObject[] enemies;

    private int[] tomados;
    public bool thereAreEnemies;
    public int restantes;




     void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        thereAreEnemies = false;
        
    }

    
    void Update()
    {
        if(!thereAreEnemies)
        {
            int enemiesNumber;
            enemiesNumber = Random.Range(1, enemies.Length);
            restantes = enemiesNumber;

            for(int i=0; i<enemiesNumber-1;i++)
            {
                int SpawnPointNumber;
                SpawnPointNumber = Random.Range(0, 3);

                enemies[i].transform.position = spawnPoints[SpawnPointNumber].transform.position;
            }

            thereAreEnemies = true;
        }

        if(restantes==0)
        {
            thereAreEnemies = false;
        }
    }
}
