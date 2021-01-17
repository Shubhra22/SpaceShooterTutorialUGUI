using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroid;
    public GameObject enemyShip;
    public GameObject powerUp;
    
    // Start is called before the first frame update
    // auto called by unity
    void Start()
    {
       Invoke("SpawnEnemy",1);
       Invoke("SpawnEnemyShip",2);
       Invoke("SpawnPowerUp",20);
    }

    // Update is called once per frame
    void Update()
    {
       
    }      
    // Methods.
    // 1. return type (void) - dont care always void for now
    // 2. Give a name for ur method.
    // 3. Give a parameter (not mandatory)

    void SpawnEnemy()
    {  
        int spawnTime = Random.Range(1, 3);
        
        Vector3 pos = new Vector3(Random.Range(-4,4),8f,0);
        Instantiate(asteroid,pos,Quaternion.identity);
        
        Invoke("SpawnEnemy",spawnTime);
    }

    void SpawnEnemyShip()
    {
        int spawnTime = Random.Range(5, 10);
        
        Vector3 pos = new Vector3(Random.Range(-4,4),8f,0);
        Instantiate(enemyShip,pos,Quaternion.identity);
        
        Invoke("SpawnEnemyShip",spawnTime);
    }

    void SpawnPowerUp()
    {
        int spawnTime = Random.Range(30, 50);
        
        Vector3 pos = new Vector3(Random.Range(-4,4),8f,0);
        Instantiate(powerUp,pos,Quaternion.identity);
        
        Invoke("SpawnPowerUp",spawnTime);
    }
}
