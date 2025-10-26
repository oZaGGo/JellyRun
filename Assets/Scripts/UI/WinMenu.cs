using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            CargarMenuPrincipal();
        }
    }
    
    public void CargarMenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void Start()
    {
        
    }
}