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
        transform.position = mov;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }

    void Movimento()
    {
        if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow) && transform.position.z < 186.95)
        {
            mov = new Vector3 (0f, 0f, 10f * Time.deltaTime);
            transform.Translate(mov);
            anim.SetBool("Esquerda", true);
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {   
            anim.SetBool("Esquerda", false);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) && transform.position.z > 157.03)
        {
            mov = new Vector3(0f, 0f, -10f * Time.deltaTime);
            transform.Translate(mov);
            anim.SetBool("Direita", true);
        }
        else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetBool("Direita", false);
        }
    }
}
