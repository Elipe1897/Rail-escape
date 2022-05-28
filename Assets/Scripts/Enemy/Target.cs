using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public float Health;
    public float maxHealth;

    public GameObject healthBarUi;
    public Slider slider;

     void Start()
    {
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
