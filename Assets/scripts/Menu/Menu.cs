using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string nomeCena;
    //criando o metodo Jogar que será ativo quando o jogador apertar o botão Jogar
    public void Jogar()
    {
        SceneManager.LoadSceneAsync(nomeCena); //chamado uma determinada cena
    }
    
    //criando o metodo Sair que será chamadp quando o jogador apertar o botão sair
    public void Sair()
    {
        Application.Quit(); //saindo do Jogo 
    }
}
