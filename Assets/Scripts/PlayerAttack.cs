
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject hitbox;
    public float attackDuration = 0.2f;
    public float attackDistance = 1f;

    private float attackTimer = 0f;
    private bool isAttacking = false;

    private PlayerMovement movement;

    void Start()
    {
        movement = GetComponent<PlayerMovement>();
        hitbox.SetActive(false);
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !isAttacking)
        {
            isAttacking = true;
            attackTimer = attackDuration;

            Vector2 dir = movement.LastMoveDirection;
            
            if(dir == Vector2.zero)
            {
                dir = Vector2.right;
            }

            if(Mathf.Abs(dir.x) > Mathf.Abs(dir.y))
            {
                dir = new Vector2(Mathf.Sign(dir.x), 0);
            }
            else
            {
                dir = new Vector2(0, Mathf.Sign(dir.y));
            }

            hitbox.transform.localPosition = dir * attackDistance;

            hitbox.SetActive(true);
        }

        if (isAttacking)
        {
            attackTimer = attackTimer - Time.deltaTime;
            if(attackTimer <= 0f)
            {
                isAttacking=false;
                hitbox.SetActive(false);
            }
        }
    }
}
