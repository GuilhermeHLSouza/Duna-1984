using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Personagem : MonoBehaviour
{
    public Vector3 mov;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //colocando a posição inicial do personagem/minhoca
        transform.position = mov;
        //puxando o componente Animator do personagem/minhoca
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //chamando o metodo Movimento
        Movimento();
    }

    //criando o metodo Movimento
    void Movimento()
    {
        //verificando se a tecla A foi clicada e se não passou do limite do mapa 
        if(Input.GetKey(KeyCode.A) && transform.position.z < 186.15)
        {
            mov = new Vector3 (10f * Time.deltaTime, 0f, 0f);
            transform.Translate(mov);
            anim.SetBool("Esquerda", true);
        }

        //verificando se a tecla A não está ativa 
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {   
            anim.SetBool("Esquerda", false);
        }
         
        //verificando se a tecla D foi clicada e se não passou do limite do mapa 
        if (Input.GetKey(KeyCode.D) && transform.position.z > 162.68)
        {
            mov = new Vector3(-10f * Time.deltaTime, 0f, 0);
            transform.Translate(mov);
            anim.SetBool("Direita", true);
        }
        
        //verificando se a tecla D não está ativa 
        else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("Direita", false);
        }
    }
}
