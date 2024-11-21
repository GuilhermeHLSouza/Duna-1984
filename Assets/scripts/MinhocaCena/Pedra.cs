using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pedra : MonoBehaviour
{
    public Vector3 mov;
    public Vector3 tamanho;
    // Start is called before the first frame update
    void Start()
    {
        //definindo um tamanho para a pedra
        tamanho = new Vector3(10f, 10f, 10f);
        transform.localScale = tamanho;
    }

    // Update is called once per frame
    void Update()
    {
        //definindo o valor da velocidade que a pedra vai se mover
        mov = new Vector3(-0.3f, 0, 0);
        //chamando o metodo Movimento
        Movimento(mov);
    }

    //incluindo o metodo Movimento 
    void Movimento(Vector3 movimento)
    {
        //fazendo o movimento
        transform.Translate(movimento);
    }

    //colocando a colisão nas pedras
    private void OnCollisionEnter(Collision collision)
    {
        //verificando em qual objeto está colidindo
        if (collision.gameObject.tag == "Jogador")
        {
            //chamando a cena FimJogo
            SceneManager.LoadSceneAsync("FimJogo");
        }
        if (collision.gameObject.tag == "Final")
        {
            //Destruindo o Objeto 
            Destroy(this.gameObject);
        }
    }
}
