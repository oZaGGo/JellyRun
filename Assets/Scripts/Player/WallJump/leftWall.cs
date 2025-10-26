using UnityEngine;

public class leftWall : MonoBehaviour
{
    public GameObject target;
    private PlayerController controller;
    private Rigidbody2D rb;
    private float originalGravityScale;
    
    void Start()
    {
        rb = target.GetComponent<Rigidbody2D>();
        originalGravityScale = rb.gravityScale;
        controller = target.GetComponent<PlayerController>();
    }

    void Update()
    {
    
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("wall"))
        {
            controller.touchingWall = true;
            
            rb.gravityScale = 0.1f;
            
            rb.linearVelocity = Vector2.zero; 
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("wall")) 
        {
            controller.touchingWall = false;

            rb.gravityScale = originalGravityScale; 
            
        }
    }
}