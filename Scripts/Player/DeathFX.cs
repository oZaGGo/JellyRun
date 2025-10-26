using UnityEngine;

public class DeathFX : MonoBehaviour
{
    public GameObject fragmentoPrefab;
    public int cantidadDeFragmentos = 8;
    public float fuerzaDeExplosion = 5f;
    public void RomperSprite()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        for (int i = 0; i < cantidadDeFragmentos; i++)
        {
            GameObject fragmento = Instantiate(fragmentoPrefab, transform.position, Quaternion.identity);
            
            Debug.Log("Fragmento creado: " + i);

            Rigidbody2D rb = fragmento.GetComponent<Rigidbody2D>();
            
            Vector2 direccionAleatoria = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
            
            rb.AddForce(direccionAleatoria * fuerzaDeExplosion, ForceMode2D.Impulse);

            rb.AddTorque(Random.Range(-5f, 5f));

            Destroy(fragmento, 3f); 
        }

        Destroy(gameObject, 0.1f);
    }
}
