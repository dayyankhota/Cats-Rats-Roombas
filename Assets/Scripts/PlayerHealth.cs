using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int health;
    private PlayerMovement movement;

    void Start()
    {
        health = maxHealth;
        movement = GetComponent<PlayerMovement>();
    }

    public void TakeDamage(int value)
    {
        if(movement != null && movement.IsInvincible)
        {
            return;
        }

        health = health - value;
        Debug.Log("Player took damage! Health = " + health);
        if (health <= 0)
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
