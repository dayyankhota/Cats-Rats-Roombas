using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int health;

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int value)
    {
        health = health - value;
        
        if(health <= 0)
        {
            Die();
        }
    }

    public void Heal(int value)
    {
        health = health + value;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    public void Die()
    {
        Debug.Log("YOU DIED");
        gameObject.SetActive(false);
    }

    void Update()
    {
        
    }
}
