using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 2.5f;
    private Rigidbody rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
       Vector3 pos = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.fixedDeltaTime);
       rb.MovePosition(pos);
       transform.LookAt(player);
    }
   
}
