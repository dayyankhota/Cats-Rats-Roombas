using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 15;
    public float attackCooldown = 1f;

    private float attackTimer = 0f;

    void Start()
    {
        
    }

    
    void Update()
    {
        attackTimer = attackTimer - Time.deltaTime;
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        Debug.Log("Trigger hit by: " + collider.name + " | Has PlayerHealth: " + (collider.GetComponent<PlayerHealth>() != null));
        //Debug.Log("Trigger hit by: " + collider.name);

        if (attackTimer > 0f) return;

        PlayerHealth player = collider.GetComponent<PlayerHealth>();

        if (player == null)
        {
            player = collider.GetComponentInParent<PlayerHealth>();
        }
        Debug.Log("Player detected, dealing damage" + (player != null));

        if (player != null)
        {
            
            player.TakeDamage(damage);
            attackTimer = attackCooldown;
        }
    }
}
