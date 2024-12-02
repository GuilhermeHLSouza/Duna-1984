using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeracaoPedra : MonoBehaviour
{
    int random;
    public Vector3 posicaoInicial;
    public GameObject[] obstaculos;
    public float spawnTime, spawnDelay, limiteInferior, limiteSuperior, velocidadeZigZag;
    public float velocidade = 5.0f;     
    private int direcaoZ = 1;

    // Start is called before the first frame update
    void Start()
    {
        //invocando os objetos repetidamente utilizando o metodo SpawnRandom
        InvokeRepeating("SpawnAleatorio", spawnTime, spawnDelay);
        //colocando o objeto na posição certa
        transform.position = posicaoInicial;
    }
    
    void SpawnAleatorio()
    {
        //pega um numero aleatorio de 0 até a quandidade de obstaculos que foi colocado na variavel obstaculos
        random = Random.Range(0, obstaculos.Length);
        //coloca um dos objetos presentes na variavel na cena aleatoriamente a partir da variavel random  
        Instantiate(obstaculos[random], transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }

    private void Movimento()
    {
        //define qual a direção o objeto vai estar indo
        Vector3 movimentoZigZag = Vector3.forward * direcaoZ * velocidadeZigZag * Time.deltaTime;
        transform.Translate(movimentoZigZag);

        //verificando se atingiu os limites colocados
        if (transform.position.z >= limiteSuperior)
        {
            direcaoZ = -1;
        }
        else if (transform.position.z <= limiteInferior)
        {
            direcaoZ = 1;
        }
    }
}
