using UnityEngine;

public class pipe : MonoBehaviour
{
    public GameObject player;
    private Animator animator;
    private PlayerController playerController;
    void Start()
    {
        animator = GetComponent<Animator>();
        playerController = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.win)
        {
            animator.SetInteger("suc", 1);
        }
        
    }
}
