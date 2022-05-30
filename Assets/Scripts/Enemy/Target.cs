using UnityEngine;

public class Target : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
    public float Health;
    public float maxHealth;

    public static Target instance;


    public GameObject healthBarUi;
    public Slider slider;

     void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        Health = maxHealth;
        slider.value = CalculateHealth();
    }
     void Update()
    {
        slider.value = CalculateHealth();
        if(Health < maxHealth)
        {
            healthBarUi.SetActive(true);
        }
    }
=======
    public float Health = 50f;
>>>>>>> parent of f957aee (Merge branch 'main' of https://github.com/Elipe1897/Rail-escape)
=======
    public float Health = 50f;
>>>>>>> parent of f957aee (Merge branch 'main' of https://github.com/Elipe1897/Rail-escape)

    public void TakeDamage(float amount)
    {
        Health -= amount;
        if (Health <= 0f)
        {
            Die();
<<<<<<< HEAD
<<<<<<< HEAD

            GameplayController.instance.EnemyKilled();
=======
>>>>>>> parent of f957aee (Merge branch 'main' of https://github.com/Elipe1897/Rail-escape)
=======
>>>>>>> parent of f957aee (Merge branch 'main' of https://github.com/Elipe1897/Rail-escape)
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

<<<<<<< HEAD
<<<<<<< HEAD
   

    float CalculateHealth()
    {
        return Health / maxHealth;
    }

=======
>>>>>>> parent of f957aee (Merge branch 'main' of https://github.com/Elipe1897/Rail-escape)
=======
>>>>>>> parent of f957aee (Merge branch 'main' of https://github.com/Elipe1897/Rail-escape)

}
