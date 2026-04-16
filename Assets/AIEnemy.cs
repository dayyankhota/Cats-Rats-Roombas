using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private float distance;
    public float distanceBetween; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

      

        if(distance < distanceBetween)
        {
             transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            // transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
        Vector3 scale = transform.localScale;

        if(player.transform.position.x < transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x) * -1;
        }
        else {
            scale.x = Mathf.Abs(scale.x);
        }

        transform.localScale = scale;
    }
}
