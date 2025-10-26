using UnityEngine;

public class lava : MonoBehaviour
{
    public GameObject player;
    private PlayerController playerController;
    public float unidadDeAscenso = 0.001f;
    public float intervaloDeAscenso = 0.01f;
    private float temporizadorAscenso;

    public float amplitudOleaje = 0.05f; 
    public float frecuenciaOleaje = 2f; 
    
    public float aceleracionAscensoPorSegundo = 0.002f; 

    private float posicionYBase; 

    void Start()
    {
        posicionYBase = transform.position.y;
        temporizadorAscenso = intervaloDeAscenso;
        playerController = player.GetComponent<PlayerController>();
    }

    void Update()
    {
        if(!playerController.lose && !playerController.isDead)
        {
            unidadDeAscenso += aceleracionAscensoPorSegundo * Time.deltaTime;

            temporizadorAscenso -= Time.deltaTime;

            if (temporizadorAscenso <= 0)
            {
                temporizadorAscenso = intervaloDeAscenso;
                posicionYBase += unidadDeAscenso;
                
                transform.position = new Vector3(transform.position.x, posicionYBase, transform.position.z);
            }
            
            float oleajeY = Mathf.Sin(Time.time * frecuenciaOleaje) * amplitudOleaje;

            transform.position = new Vector3(
                transform.position.x,
                posicionYBase + oleajeY,
                transform.position.z
            );
        }
    }
}