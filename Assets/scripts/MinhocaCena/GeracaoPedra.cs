using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeracaoPedra : MonoBehaviour
{
    int random;
    public Vector3 posicaoInicial;
    public GameObject[] obstaculos;
    public float spawnTime, spawnDelay;
    public float velocidade = 5.0f;     
    public float velocidadeZigZag;
    public float limiteSuperior;
    public float limiteInferior;
    private int direcaoZ = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandom", spawnTime, spawnDelay);
        transform.position = posicaoInicial;
    }
    void SpawnRandom()
    {
        random = Random.Range(0, obstaculos.Length);
        Instantiate(obstaculos[random], transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 movimentoZigZag = Vector3.forward * direcaoZ * velocidadeZigZag * Time.deltaTime;
        transform.Translate(movimentoZigZag);

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
