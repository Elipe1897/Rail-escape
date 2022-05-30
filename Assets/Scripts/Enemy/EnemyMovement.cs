using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Leo s
public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 2.5f;
    public float standStill = 0;
    private Rigidbody rb;
    public Animator anim;
    public float timer;
    public GameObject Players;
    public float Distance_;
    public float attackRadius = 3f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
     void Update()
    {
        
        Vector3 PlayerPosition = new Vector3(player.position.x, 2f, player.position.z);
        Distance_ = Vector3.Distance(Players.transform.position, transform.position);
        if (Distance_ <= attackRadius)
        {
            timer += Time.deltaTime;
            Vector3 pos = Vector3.MoveTowards(transform.position, PlayerPosition, standStill);
            FaceTarget();
            anim.SetBool("IsMoving", false);
            anim.SetBool("IsAttacking", true);
            if (timer >= 1.5)
            {
                Player.instance.DealDamage();
                timer = 0;
            }
        }
        else if(Distance_ >= attackRadius)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, PlayerPosition, moveSpeed * Time.fixedDeltaTime);
            rb.MovePosition(pos);
            FaceTarget();
            anim.SetBool("IsMoving", true);
            anim.SetBool("IsAttacking", false);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }
    void FaceTarget()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
}
