using UnityEngine;

public class sliceRight : MonoBehaviour
{
    public Transform tr;
   
    [SerializeField]
    private float moveDistance = 0.01f; 

    void Start()
    {
    
    }


    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ground"))
        {
           tr.Translate(Vector3.left * moveDistance);     
        }
    }
}
