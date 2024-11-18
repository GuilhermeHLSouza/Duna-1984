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
        tamanho = new Vector3(10f, 10f, 10f);
        transform.localScale = tamanho;
    }

    // Update is called once per frame
    void Update()
    {
        mov = new Vector3(-0.2f, 0, 0);
        Movimento(mov);
    }

    void Movimento(Vector3 movimento)
    {
        transform.Translate(movimento);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Jogador")
        {
            SceneManager.LoadSceneAsync("Menu");
        }
        if (collision.gameObject.tag == "Final")
        {
            Destroy(this.gameObject);
        }
    }
}
