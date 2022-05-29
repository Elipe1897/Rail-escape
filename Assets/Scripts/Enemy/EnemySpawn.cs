
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject theEnemy;

    public int enemyCount;
    int xPos;
    int zPos;
   

    public Transform playerPosition;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop()
    {
<<<<<<< HEAD
        while(enemyCount < 100000000000000000)
=======
        while(enemyCount < 10)
>>>>>>> parent of f957aee (Merge branch 'main' of https://github.com/Elipe1897/Rail-escape)
        {
            xPos = Random.Range(1, 9);
            zPos = Random.Range(-15, -30);
            Vector3 spawnDistance = new Vector3(xPos, 0f, zPos);
            Vector3 spawnpoint = playerPosition.transform.TransformPoint(spawnDistance);
            Instantiate(theEnemy, spawnpoint,playerPosition.transform.rotation);
            yield return new WaitForSeconds(5);
            enemyCount += 1;
        }
    }
   


}
