using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float damage = 5f;
    public static Player instance;

    public float Health = 50;


    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        
    }
    public void Update()
    {
        if(Health <= 0)
        {
            GameplayController.instance.RestartGame();

        }

    }
    

    public void DealDamage()
    {
            Target target = GetComponent<Target>();
            target.TakeDamage(damage);
        Health -= 10;
    }
     
}
