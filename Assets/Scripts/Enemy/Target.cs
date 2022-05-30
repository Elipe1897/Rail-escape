using UnityEngine;
using UnityEngine.UI;

//Elias
public class Target : MonoBehaviour
{
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

    public void TakeDamage(float amount)
    {
        Health -= amount;
        if (Health <= 0f)
        {
            Die();

            GameplayController.instance.EnemyKilled();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

   

    float CalculateHealth()
    {
        return Health / maxHealth;
    }


}
