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
        posicao.z = personagem.transform.position.z;
        transform.position = posicao;
    }

    // Update is called once per frame
    void Update()
    {
        if(personagem.transform.position.z != transform.position.z) 
        {
            posicao = new Vector3(transform.position.x, transform.position.y, personagem.transform.position.z);
            transform.position = posicao ;
        }
       
    }
}
