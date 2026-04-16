using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int totalHealth = 20;
    public int health;
    void Start()
    {
        health = totalHealth;
    }


    public void TakeDamage(int amount)
    {
        health = health - amount;
        if(health < 0) health = 0;
        
        if(health <= 0)
        {
            Die();
        }

        
    }

    public void Die()
    {
        Destroy(gameObject);
    }

 
    void Update()
    {
        
    }
}
