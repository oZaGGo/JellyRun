using UnityEngine;

public class blade : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 100f;

    [SerializeField]
    private Vector3 rotationAxis = Vector3.forward;
    
    void Start()
    {
        
    }

    void Update()
    {
        float angle = rotationSpeed * Time.deltaTime;
        transform.Rotate(rotationAxis, angle);
    }
}
