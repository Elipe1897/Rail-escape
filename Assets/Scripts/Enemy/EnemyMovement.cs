using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 3f;
    private Rigidbody rb;
    public float timer = 0;
    public Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    public void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.fixedDeltaTime);
            rb.MovePosition(pos);
            transform.LookAt(player);
            animator.Play("IsMoving");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
