
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Leo s
public class EnemySpawn : MonoBehaviour
{
  public GameObject theEnemy;

    public int enemyCount = 0;
    int xPos;
    int zPos;
   

    public Transform playerPosition;

    public void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    
        
        
    
    IEnumerator EnemyDrop()
    {
        while(enemyCount < 100000000000000000)
        {
            xPos = Random.Range(-5, 15);
            zPos = Random.Range(-5, 25);
            Vector3 spawnDistance = new Vector3(xPos, 0f, zPos);
            Vector3 spawnpoint = playerPosition.transform.TransformPoint(spawnDistance);
            Instantiate(theEnemy, spawnpoint,playerPosition.transform.rotation);
            yield return new WaitForSeconds(1);
            enemyCount++;
            
        }
    }
   

    
}
