using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(SpriteRenderer))]
public class FadeInController : MonoBehaviour
{
    public GameObject player;
    private PlayerController playerController;
    public float duracionFundido = 2f;
    private SpriteRenderer spriteRenderer;
    private Color colorInicial;

    void Start()
    {
        playerController = player.GetComponent<PlayerController>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        colorInicial = spriteRenderer.color;
        colorInicial.a = 0f;
        spriteRenderer.color = colorInicial;

    }

    void Update()
    {
        if (playerController.win)
        {
            StartCoroutine(FundirSprite(2));
        }

        if (playerController.lose)
        {
            StartCoroutine(FundirSprite(1));
        }
    }

    IEnumerator FundirSprite(int escenaIndex = 1)
    {
        float tiempoTranscurrido = 0f;

        Color colorFinal = spriteRenderer.color;
        colorFinal.a = 1f;
        
        Color colorInicio = spriteRenderer.color;
        colorInicio.a = 0f;

        while (tiempoTranscurrido < duracionFundido)
        {
            float t = tiempoTranscurrido / duracionFundido;

            spriteRenderer.color = Color.Lerp(colorInicio, colorFinal, t);

            tiempoTranscurrido += Time.deltaTime;

            yield return null;
        }

        spriteRenderer.color = colorFinal;
        if (escenaIndex == 1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if (escenaIndex == 2)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}