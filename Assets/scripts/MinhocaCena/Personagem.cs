using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Personagem : MonoBehaviour
{
    Vector3 mov;

    // Start is called before the first frame update
    void Start()
    {
        mov = new Vector3(-36.92f, 6.87f, 172.43f);
        transform.position = mov;
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }

    void Movimento()
    {
        if(Input.GetKey(KeyCode.A) && transform.position.z < 184.10)
        {
            mov = new Vector3 (0f, 0f, 10f * Time.deltaTime);
            transform.Translate(mov);
        }
        if (Input.GetKey(KeyCode.D) && transform.position.z > 157.03)
        {
            mov = new Vector3(0f, 0f, -10f * Time.deltaTime);
            transform.Translate(mov);
        }
    }
}
