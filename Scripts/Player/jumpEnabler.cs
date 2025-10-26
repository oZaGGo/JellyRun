using UnityEngine;
using System.Collections;

public class jumpEnabler : MonoBehaviour
{
    public bool isGrounded;
    private const float GROUND_CHECK_DELAY = 0.05f;
    private Coroutine groundCheckCoroutine;
    
    void Start()
    {
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (groundCheckCoroutine != null)
        {
            StopCoroutine(groundCheckCoroutine);
        }
            
        groundCheckCoroutine = StartCoroutine(GroundCheckDelay());
        Debug.Log(isGrounded);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (groundCheckCoroutine != null)
        {
            StopCoroutine(groundCheckCoroutine);
            groundCheckCoroutine = null;
        }
            
        isGrounded = false;
        Debug.Log(isGrounded);
    }
    
    private IEnumerator GroundCheckDelay()
    {
        yield return new WaitForSeconds(GROUND_CHECK_DELAY);

        isGrounded = true;
        
        groundCheckCoroutine = null;
    }
}
