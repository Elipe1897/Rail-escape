using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 2.5f;
    private Rigidbody rb;
    public Animator anim;
   
    public GameObject Players;
    public GameObject Enemy;
    public float Distance_;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
     void Update()
    {

        Vector3 PlayerPosition = new Vector3(player.position.x, 2f, player.position.z);
        Distance_ = Vector3.Distance(Players.transform.position, Enemy.transform.position);
        if (Distance_ > 1.4)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, PlayerPosition , moveSpeed * Time.fixedDeltaTime);
            rb.MovePosition(pos);
            transform.LookAt(player);
            anim.SetBool("IsMoving", true);
            anim.SetBool("IsAttacking", false);

        }
        else
        {
            transform.position += new Vector3(0, 0, 0);
            anim.SetBool("IsMoving", false);
            anim.SetBool("IsAttacking", true);

        }



    }
    
}
