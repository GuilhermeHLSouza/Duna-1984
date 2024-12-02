using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject personagem;
    public Vector3 posicao;
    // Start is called before the first frame update
    void Start()
    {
        //colocando a camera na posição do personagem/minhoca
        posicao.z = personagem.transform.position.z -2.5f ;
        transform.position = posicao;
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
       
    }

    void Movimento()
    {
        //verificando se camera está na posição do personagem
        if (personagem.transform.position.z != transform.position.z)
        {
            //movendo a minhoca para a posição do personagem
            posicao = new Vector3(transform.position.x, transform.position.y, personagem.transform.position.z - 2.50f);
            transform.position = posicao;
        }
    }
}

