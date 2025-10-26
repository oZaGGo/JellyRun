using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    public PlayerController player;

    [SerializeField]
    private float smoothSpeed = 0.125f;

    void Start()
    {
        
    }

    void Update()
    {
        if (!player.isDead && !player.win && !player.lose)
        {
            Vector3 targetPosition = new Vector3(
                transform.position.x, 
                target.position.y + 0.3f, 
                transform.position.z
            );
            

            transform.position = Vector3.Lerp(
                transform.position, 
                targetPosition, 
                smoothSpeed * Time.deltaTime * 50f
            );
        }
    }
}
