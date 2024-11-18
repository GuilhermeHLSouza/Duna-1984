using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string nomeCena;

   public void Jogar()
    {
        SceneManager.LoadSceneAsync(nomeCena);
    }
    
    public void Sair()
    {
        Application.Quit();
    }
}
