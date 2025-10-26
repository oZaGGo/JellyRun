using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private float jumpForce = 5f;
    private bool shouldJump = false;
    private int direction;
    private int state;
    public bool touchingWall;
    public bool isDead;
    public bool win;
    public bool lose;


    //Enumerado para las animaciones
    private enum STATE{idle,move,jump}

    //Components
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;
    private jumpEnabler jump;
    private DeathFX deathFX;
    private AudioSource audioSource1;
    private AudioSource audioSource2;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        jump = GetComponentInChildren<jumpEnabler>();
        deathFX = GetComponent<DeathFX>();
        isDead = false;
        win = false;
        lose = false;
        audioSource1 = GetComponents<AudioSource>()[0];
        audioSource2 = GetComponents<AudioSource>()[1];
    }

    void Update()
    {
        //Por defecto
        direction = 0;
        state = (int)STATE.idle;
        
        
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            shouldJump = true;
        }

        if(Keyboard.current.aKey.isPressed)
        {
            direction = -1;
            if (jump.isGrounded && !touchingWall)
            {
                state = (int)STATE.move;
            }
            sr.flipX = false; 
        }

        else if(Keyboard.current.dKey.isPressed)
        {
            direction = 1;
            if (jump.isGrounded && !touchingWall)
            {
                state = (int)STATE.move;
            }
            sr.flipX = true; 
        }
        
        animator.SetInteger("state", state);
    }

    void FixedUpdate()
    {

        if ((shouldJump && jump.isGrounded) || (shouldJump && touchingWall))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            state = (int)STATE.jump;
            audioSource1.Play();

        }


        shouldJump = false;


        Vector2 newVelocity = new Vector2(direction * moveSpeed, rb.linearVelocity.y);
        
        rb.linearVelocity = newVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("death"))
        {
            isDead = true;
            lose = true;
            deathFX.RomperSprite();
            audioSource2.Play();
        }
        
        if (collision.gameObject.CompareTag("win"))
        {
            sr.enabled = false;
            win = true;
        }
    }
    
}