using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Tempo : MonoBehaviour
{
    public TextMeshProUGUI textTempo;
    public float tempo;
    private int minutos;
    private int segundos;

    // Update is called once per frame
    void Update()
    {
        Cronometro();
    }

    void Cronometro()
    {
        tempo -= Time.deltaTime;
        if (tempo < 0)
        {
            SceneManager.LoadSceneAsync("Menu");
            tempo = 0;
        }
        minutos = Mathf.FloorToInt(tempo / 60);
        segundos = Mathf.FloorToInt(tempo % 60);
        textTempo.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
