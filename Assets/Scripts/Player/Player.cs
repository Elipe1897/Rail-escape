using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float damage = 25f;
    public GameObject Players;
    public GameObject Enemy;
    public float Distance_;

     void Start()
    {
        StartCoroutine(EnemyDamage());

    }
    void Update()
    {
        Distance_ = Vector3.Distance(Players.transform.position, Enemy.transform.position);
    }
    IEnumerator EnemyDamage()
    {
        while (Distance_ < 1.5)
        {
            Target target = GetComponent<Target>();
            target.TakeDamage(damage);
            yield return new WaitForSeconds(2);
        }
    }
}
