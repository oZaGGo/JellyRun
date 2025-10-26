using UnityEngine;
using UnityEngine.SceneManagement; // 1. Importar la librería SceneManagement

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            CargarJuego();
        }
    }

    public void CargarJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void Start()
    {
        
    }
}